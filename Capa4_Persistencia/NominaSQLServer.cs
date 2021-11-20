using Capa3_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa4_Persistencia
{
    public class NominaSqlServer
    {
        private readonly GestorSqlServer gestorSQL;

        public NominaSqlServer()
        {
            gestorSQL = GestorSqlServer.getInstance();
        }

        public bool guardar(Nomina nomina)
        {

            string insertarNomina = "INSERT INTO nomina(nomina_id,periodo_id,fecha,descripcion,cerrada) " +
                                    "VALUES(@id,@per_id,@fecha,@descripcion,@cerrada)";


            try
            {

                SqlCommand comando = gestorSQL.ObtenerComandoSQL(insertarNomina);
                comando.Parameters.AddWithValue("@id", nomina.Nomina_id);
                comando.Parameters.AddWithValue("@per_id", nomina.Periodo.Periodo_id);
                comando.Parameters.AddWithValue("@fecha", nomina.Fecha);
                comando.Parameters.AddWithValue("@descripcion", nomina.Descripcion);
                comando.Parameters.AddWithValue("@cerrada", nomina.Cerrada);
     
                comando.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                throw;
            }

        }


        public List<Nomina> buscarPorDescripcion(string descripcion)
        {
            string buscarSql = "SELECT * FROM nomina where descripcion LIKE '%" + descripcion + "%'";
            List<Nomina> listaNomina = new List<Nomina>();

            try
            {
                SqlDataReader resultado = gestorSQL.EjecutarConsulta(buscarSql);

                while (resultado.Read())
                {
                    listaNomina.Add(obtenerNomina(resultado));
                }

                return listaNomina;
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
                string actualizarrSql = "UPDATE  nomina SET cerrada = 'true' where nomina_id = '" + nomina.Nomina_id + "'";

                SqlCommand comando = gestorSQL.ObtenerComandoSQL(actualizarrSql);
                comando.ExecuteNonQuery();
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
                string eliminarSql = "DELETE FROM nomina  where nomina_id = '" + nomina.Nomina_id + "'";
         
                SqlCommand  comando = gestorSQL.ObtenerComandoSQL(eliminarSql);
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
                throw;
            }

        }


        private Nomina obtenerNomina(SqlDataReader resultado)
        {
            Nomina nomina = new Nomina();
            nomina.Periodo = new PeriodoDeNomina(); 

            nomina.Nomina_id = resultado.GetString(0);
            nomina.Periodo.Periodo_id = resultado.GetString(1);
            nomina.Fecha = resultado.GetDateTime(2);
            nomina.Descripcion = resultado.GetString(3);
            nomina.Cerrada = resultado.GetBoolean(4);

            return nomina;
        }


    }
}
