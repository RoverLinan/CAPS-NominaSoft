using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa3_Dominio.Entidades;

namespace Capa4_Persistencia
{
    public class UsuarioSQLServer
    {
        private readonly GestorSQLServer gestorSQL;



        public UsuarioSQLServer()
        {
            gestorSQL = GestorSQLServer.getInstance();
        }

        public bool guardar(Usuario usuario)
        {
            string insertarUsuario = "INSERT INTO usuarios" +
                             "(username,password,fecha,rol) " +
                             "VALUES(@username,@pass,@fecha,@rol);";



            try
            {
                SqlCommand comando;

                comando = gestorSQL.ObtenerComandoSQL(insertarUsuario);
                comando.Parameters.AddWithValue("@username", usuario.Username);
                comando.Parameters.AddWithValue("@pass", usuario.Password);
                comando.Parameters.AddWithValue("@fecha", usuario.FechaCreacion);
                comando.Parameters.AddWithValue("@rol", usuario.Rol);

                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception err)
            {
                throw err;
            }

        }




        public Usuario validarUsuario(string username , string password)
        {
            Usuario user;
            string consultaSQL = "select   * from usuarios where username = '"  + username  + "' and password = '" + password + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    user = ObtenerUsuario(resultadoSQL);
                }
                else
                {
                    throw new Exception("No existe el usuario");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            
            return user;
        }



        private Usuario ObtenerUsuario(SqlDataReader resultado)
        {
            Usuario usuario = new Usuario();
            usuario.Id = resultado.GetInt32(0);
            usuario.Username = resultado.GetString(1);
            usuario.Password = resultado.GetString(2);
            usuario.FechaCreacion = resultado.GetDateTime(3);
            usuario.Rol = resultado.GetString(4);
            return usuario;
        }
    }
}
