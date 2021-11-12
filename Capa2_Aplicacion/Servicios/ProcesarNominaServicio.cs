using Capa3_Dominio.Entidades;
using Capa4_Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa2_Aplicacion.Servicios
{
    public class ProcesarNominaServicio
    {
        private GestorSQLServer gestorSql;
        private NominaSQLServer nominaSQL;
        private GestionarBoletaDePagoServicio boletaDePagoServicio;
        private GestionarPeriodoNominaServicio periodoNominaServicio;

        public ProcesarNominaServicio()
        {
            gestorSql = GestorSQLServer.getInstance();
            nominaSQL = new NominaSQLServer();
            boletaDePagoServicio = new GestionarBoletaDePagoServicio();
            periodoNominaServicio = new GestionarPeriodoNominaServicio();
        }


        public void guardar(Nomina nomina)
        {



            try
            {
                if (nomina.BoletaDePagos.Count == 0)
                {

                    throw new Exception("No se han generado boletas de pago");

                }

                if (nomina.EsFactibleGenerarNomina() == false)
                {

                    throw new Exception("No es factible generar la nomina");

                }


                gestorSql.AbrirConexion();
                nominaSQL.guardar(nomina);
                gestorSql.CerrarConexion();

                // guardamos las boletas 
                foreach (BoletaDePago boleta in nomina.BoletaDePagos)
                {
                    boletaDePagoServicio.guardar(boleta);
                }

            }
            catch (Exception err)
            {

                throw err;
            }
        }

        public List<Nomina> buscarNominaPorDescripcion(string descripcion)
        {
            try
            {
                gestorSql.AbrirConexion();
                List<Nomina> listaNomina = nominaSQL.buscarPorDescripcion(descripcion);
                gestorSql.CerrarConexion();

                foreach (Nomina nomina in listaNomina)
                {
                    nomina.BoletaDePagos = boletaDePagoServicio.buscarBoletasPorIdNomina(nomina);
                    nomina.Periodo = periodoNominaServicio.buscarPeriodoPorId(nomina.Periodo.Periodo_id);
                }



                return listaNomina;
            }
            catch (Exception err)
            {

                throw err;
            }
        }


    }
}
