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
        private readonly GestorSqlServer gestorSql;
        private readonly NominaSqlServer nominaSQL;
        private readonly GestionarBoletaDePagoServicio boletaDePagoServicio;
        private readonly GestionarPeriodoNominaServicio periodoNominaServicio;

        public ProcesarNominaServicio()
        {
            gestorSql = GestorSqlServer.getInstance();
            nominaSQL = new NominaSqlServer();
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

                // guardamos las boletas 
               

                foreach (BoletaDePago boleta in nomina.BoletaDePagos)
                {
                    boleta.Boleta_id = "BOL" + GenerarNumeroAleatorio.ObtenerNumeroAleatorio() + DateTime.Now.Millisecond;
                    boleta.Reintegros = 0;
                    boleta.Movilidad = 0;
                    boleta.Otrosingresos = 0;
                    boleta.Adelantos = 0;
                    boleta.Otrosdescuentos = 0;
                    boletaDePagoServicio.guardar(boleta);
                }

            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
                throw;
            }
        }


        public void cerrar(Nomina nomina)
        {
            try
            {
                gestorSql.AbrirConexion();
                nominaSQL.cerrar(nomina);
                gestorSql.CerrarConexion();
            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
                throw;
            }
        }


        public void eliminar(Nomina nomina)
        {
            try
            {
               

                foreach (BoletaDePago boleta in nomina.BoletaDePagos)
                {
                    boletaDePagoServicio.eliminarPorIdNomina(nomina.Nomina_id);
                }
                gestorSql.AbrirConexion();
                nominaSQL.eliminar(nomina);
                gestorSql.CerrarConexion();

                
            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
                throw;
            }
        }

        public List<Nomina> buscarNominaPorDescripcion(string descripcion)
        {
            try
            {
                gestorSql.AbrirConexion();
                List<Nomina> listaNomina = nominaSQL.buscarPorDescripcion(descripcion);
                gestorSql.CerrarConexion();

                if(listaNomina.Count > 0)
                {
                    foreach (Nomina nomina in listaNomina)
                    {
                        nomina.BoletaDePagos = boletaDePagoServicio.buscarBoletasPorIdNomina(nomina);
                        nomina.Periodo = periodoNominaServicio.buscarPeriodoPorId(nomina.Periodo.Periodo_id);
                    }
                }
                return listaNomina;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
                throw;
            }
        }


    }
}
