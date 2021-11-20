using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa3_Dominio.Entidades;

namespace Capa4_Persistencia
{
    public class AfpSqlServer
    {


        private readonly GestorSqlServer gestorSQL;

        public AfpSqlServer()
        {
            gestorSQL = GestorSqlServer.getInstance();
        }

        public bool guardar(Afp afp)
        {
            string insertarAfp = "INSERT INTO afp(afp_id,nombre,porcentajedescuento)" +
                                        " VALUES(@id,@nom,@pdscto)";

            try
            {
         
                SqlCommand comando = gestorSQL.ObtenerComandoSQL(insertarAfp);
                comando.Parameters.AddWithValue("@id", afp.Afp_id);
                comando.Parameters.AddWithValue("@nom", afp.Nombre);
                comando.Parameters.AddWithValue("@pdscto", afp.Porcentajedescuento);
                comando.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
                throw;
            }
        }

        public Afp buscarAfpPorId(int id)
        {
            
            string consultaSQL = "select   * from afp where afp_id = '" + id + "'";
            try
            {
                Afp afp = null;
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    afp = obtenerAfp(resultadoSQL);
                }
                return afp;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                throw;
            }
           
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

                return listaAfp;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                throw;
            }
           
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
