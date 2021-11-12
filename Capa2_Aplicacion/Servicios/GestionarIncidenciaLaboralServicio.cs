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
        private GestorSQLServer gestorSQL;
        private IncidenciaLaboralSQLServer incidenciaLaboralSQL;
        private GestionarPeriodoNominaServicio periodoNominaServicio;

        public GestionarIncidenciaLaboralServicio()
        {
            incidenciaLaboralSQL = new IncidenciaLaboralSQLServer();
            gestorSQL = GestorSQLServer.getInstance();
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

                throw err;
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

                throw err;
            }
        }

        public List<IncidenciaLaboral> obtenerListaPorIdContrato(string id)
        {
            try
            {
                gestorSQL.AbrirConexion();
                List<IncidenciaLaboral> listaIncidencias = incidenciaLaboralSQL.obtenerListaPorIdContrato(id);
                foreach (IncidenciaLaboral item in listaIncidencias)
                {

                    item.Periodo = periodoNominaServicio.buscarPeriodoPorId(item.Periodo.Periodo_id);

                }

                gestorSQL.CerrarConexion();
                return listaIncidencias;
            }
            catch (Exception err)
            {

                throw err;
            }

        }


    }
}
