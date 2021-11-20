using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa3_Dominio.Entidades;
using Capa4_Persistencia;

namespace Capa2_Aplicacion.Servicios
{
    public class GestionarIncidenciaLaboralServicio
    {
        private readonly GestorSqlServer gestorSQL;
        private readonly IncidenciaLaboralSqlServer incidenciaLaboralSQL;
        private readonly GestionarPeriodoNominaServicio periodoNominaServicio;

        public GestionarIncidenciaLaboralServicio()
        {
            incidenciaLaboralSQL = new IncidenciaLaboralSqlServer();
            periodoNominaServicio = new GestionarPeriodoNominaServicio();
            gestorSQL = GestorSqlServer.getInstance();
        }



        public bool guardar(IncidenciaLaboral incidencia)
        {
            try
            {
                gestorSQL.AbrirConexion();
                bool guardado = incidenciaLaboralSQL.guardar(incidencia);
                gestorSQL.CerrarConexion();
                return guardado;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
                throw;
            }
        }


        public List<IncidenciaLaboral> obtenerPorIdPeriodo(string id)
        {
            try
            {
                gestorSQL.AbrirConexion();
                List<IncidenciaLaboral> lista = incidenciaLaboralSQL.obtenerPorIdPeriodo(id);
                gestorSQL.CerrarConexion();
                return lista;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
                throw;
            }
        }

        public List<IncidenciaLaboral> obtenerListaPorIdContrato(string id)
        {
            try
            {
                gestorSQL.AbrirConexion();
                List<IncidenciaLaboral> listaIncidencias = incidenciaLaboralSQL.obtenerListaPorIdContrato(id);
                gestorSQL.CerrarConexion();

                if(listaIncidencias.Count > 0)
                {
                    foreach (IncidenciaLaboral item in listaIncidencias)
                    {

                        item.Periodo = periodoNominaServicio.buscarPeriodoPorId(item.Periodo.Periodo_id);

                    }

                }
               
                return listaIncidencias;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                throw;

            }

        }


    }
}
