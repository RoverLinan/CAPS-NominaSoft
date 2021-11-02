using Capa3_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa4_Persistencia
{
    public class PeriodoDeNominaSQLServer
    {
        private GestorSQLServer gestorSQL;

        public PeriodoDeNominaSQLServer()
        {
            gestorSQL = GestorSQLServer.getInstance();
        }

        public bool guardar(PeriodoDeNomina periodoDeNomina)
        {
            string insertarPeriodo = "INSERT INTO periodonomina(periodo_id,descripcion,fechainicio,fechafin)" +
                                        "VALUES(@id,@desc,@fecini,@fecfin)";


            try
            {
                SqlCommand comando = new SqlCommand();
                comando = gestorSQL.ObtenerComandoSQL(insertarPeriodo);
                comando.Parameters.AddWithValue("@id", "PNOM" + periodoDeNomina.Periodo_id);
                comando.Parameters.AddWithValue("@desc", periodoDeNomina.Descripcion);
                comando.Parameters.AddWithValue("@fecini", periodoDeNomina.Fechainicio);
                comando.Parameters.AddWithValue("@fecfin", periodoDeNomina.Fechafin);
                comando.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {

                throw err;
            }
        }

        public PeriodoDeNomina buscarPeriodoPorId(string id)
        {
            PeriodoDeNomina periodoDeNomina;
            string consultaSQL = "select   * from periodonomina where periodo_id = '" + id + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    periodoDeNomina = obtenerPeriodoDeNomina(resultadoSQL);
                }
                else
                {
                    throw new Exception("El periodo no existe");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return periodoDeNomina;
        }
        public PeriodoDeNomina obtenerPeriodoDeNomina(SqlDataReader resultado)
        {
            PeriodoDeNomina periodoDeNomina = new PeriodoDeNomina();
            periodoDeNomina.Periodo_id = resultado.GetString(0);
            periodoDeNomina.Descripcion = resultado.GetString(1);
            periodoDeNomina.Fechainicio = resultado.GetDateTime(2);
            periodoDeNomina.Fechafin = resultado.GetDateTime(3);
            return periodoDeNomina;

        }

        public List<PeriodoDeNomina> listarPeriodo()
        {
            List<PeriodoDeNomina> listaPeriodo = new List<PeriodoDeNomina>();
            string consultaSQL = "select * from periodonomina";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                while (resultadoSQL.Read())
                {
                    listaPeriodo.Add(obtenerPeriodoDeNomina(resultadoSQL));
                }

                if (listaPeriodo.Count == 0)
                {
                    throw new Exception("No hay Periodos registradas");
                }

            }
            catch (Exception err)
            {
                throw err;
            }
            return listaPeriodo;
        }
    }
}
