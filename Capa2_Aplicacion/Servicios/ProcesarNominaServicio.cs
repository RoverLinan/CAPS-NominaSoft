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
            boletaDePagoServicio = new GestionarBoletaDePagoServicio();
            periodoNominaServicio = new GestionarPeriodoNominaServicio();
        }


        public void guardar(Nomina nomina)
        {
            try
            {
                gestorSql.AbrirConexion();
                nominaSQL.guardar(nomina);
                gestorSql.CerrarConexion();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        public List<Nomina> buscarPorDescripcion(string descripcion)
        {
            try
            {
                gestorSql.AbrirConexion();
                List<Nomina> listaNomina = nominaSQL.buscarPorDescripcion(descripcion);
                gestorSql.CerrarConexion();

                foreach (Nomina nomina in listaNomina)
                {
                    nomina.BoletaDePagos = boletaDePagoServicio.buscarBoletasPorIdNomina(nomina);
                    nomina.Periodo = periodoNominaServicio.buscarPeriodoPorIdNomina();


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
