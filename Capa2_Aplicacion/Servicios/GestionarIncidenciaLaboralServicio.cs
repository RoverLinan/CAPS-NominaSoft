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


    }
}
