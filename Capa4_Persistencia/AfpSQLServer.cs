using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa3_Dominio.Entidades;

namespace Capa4_Persistencia
{
    public class AfpSQLServer
    {


        private GestorSQLServer gestorSQL;

        public AfpSQLServer()
        {
            gestorSQL = GestorSQLServer.getInstance();
        }

        public bool guardar(Afp afp)
        {
            string insertarAfp = "INSERT INTO afp(afp_id,nombre,porcentajedescuento)" +
                                        " VALUES(@id,@nom,@pdscto)";

            try
            {
                SqlCommand comando = new SqlCommand();
                comando = gestorSQL.ObtenerComandoSQL(insertarAfp);
                comando.Parameters.AddWithValue("@id", afp.Afp_id);
                comando.Parameters.AddWithValue("@nom", afp.Nombre);
                comando.Parameters.AddWithValue("@pdscto", afp.Porcentajedescuento);
                comando.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {

                throw err;
            }
        }

        public Afp buscarAfpPorId(int id)
        {
            Afp afp;
            string consultaSQL = "select   * from afp where afp_id = '" + id + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    afp = obtenerAfp(resultadoSQL);
                }
                else
                {
                    throw new Exception("La afp no existe");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return afp;
        }

        public List<Afp> listaAfp()
        {
            List<Afp> listaAfp = new List<Afp>();
            string consultaSQL = "select * from afp";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                while(resultadoSQL.Read())
                {
                    listaAfp.Add(obtenerAfp(resultadoSQL));
                }

                if(listaAfp.Count == 0)
                {
                    throw new Exception("No hay AFP registradas");
                }
               
            }
            catch (Exception err)
            {
                throw err;
            }
            return listaAfp;
        }

        public Afp obtenerAfp(SqlDataReader resultado)
        {
            Afp afp = new Afp();
            afp.Afp_id = resultado.GetInt32(0);
            afp.Nombre = resultado.GetString(1);
            afp.Porcentajedescuento = double.Parse(resultado.GetDecimal(2).ToString());
            return afp;

        }

    }
}
