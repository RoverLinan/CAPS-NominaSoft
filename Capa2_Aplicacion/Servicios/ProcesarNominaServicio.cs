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

        public ProcesarNominaServicio()
        {
            gestorSql = GestorSQLServer.getInstance();  
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

                return listaNomina;
            }
            catch (Exception err)
            {

                throw err;
            }
        }


    }
}
