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
               
                if (nomina.TienePagosEmpleados() == false)
                {

                    throw new Exception("No se puede guardar la Nómina porque se incumple la regla para guardar la Nómina");

                }

                if (nomina.EsFactibleGenerarNomina() == false)
                {

                    throw new Exception("No es factible generar la nomina");

                }

                if (nomina.esValidoFechaGeneracionNomina() == false)
                {
                    throw new Exception("La fecha de  generacion de la nomina es menor que la fecha del periodo");
                }


                gestorSql.AbrirConexion();
                nominaSQL.guardar(nomina);
                gestorSql.CerrarConexion();

                // guardamos las boletas 
                Random random = new Random();

                foreach (BoletaDePago boleta in nomina.BoletaDePagos)
                {
                    boleta.Boleta_id = "BOL" + random.Next(1000, 9999);
                    boletaDePagoServicio.guardar(boleta);
                }

            }
            catch (Exception err)
            {

                throw err;
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

                throw err;
            }
        }


        public void eliminar(Nomina nomina)
        {
            try
            {
                if (nomina.Cerrada)
                {
                    throw new Exception("No se puede eliminar la nomina por estar cerrada");
                }

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
