using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa3_Dominio.Entidades;

namespace Capa4_Persistencia
{
    public class EmpleadoSQLServer
    {

        private GestorSQLServer gestorSQL;
        

        public EmpleadoSQLServer()
        {
            gestorSQL = GestorSQLServer.getInstance();
        }

        public bool guardar(Empleado empleado)
        {
            string insertarEmpleado = "INSERT INTO empleado(empleado_id,nombres,apellidos,dni,fechanacimiento,telefono,correo,direccion)" +
                                        "VALUES(@id,@nom,@ape,@dni,@fecha,@tele,@correo,@dir)";


            try
            {
                SqlCommand comando = new SqlCommand();
                comando = gestorSQL.ObtenerComandoSQL(insertarEmpleado);
                comando.Parameters.AddWithValue("@id","EMP" + empleado.Dni);
                comando.Parameters.AddWithValue("@nom", empleado.Nombres);
                comando.Parameters.AddWithValue("@ape", empleado.Apellidos);
                comando.Parameters.AddWithValue("@dni", empleado.Dni);
                comando.Parameters.AddWithValue("@fecha", empleado.Fechanacimiento);
                comando.Parameters.AddWithValue("@tele", empleado.Telefono);
                comando.Parameters.AddWithValue("@correo", empleado.Correo);
                comando.Parameters.AddWithValue("@dir", empleado.Direccion);
                comando.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {

                throw err;
            }
        }

        public Empleado buscarEmpleadoPorDni(string dni)
        {
            Empleado empleado;
            string consultaSQL = "select   * from empleado where dni = '" + dni + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    empleado = obtenerEmpleado(resultadoSQL);
                }
                else
                {
                    throw new Exception("El empleado no existe");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return empleado;
        }
        public Empleado obtenerEmpleado( SqlDataReader resultado)
        {
            Empleado empleado = new Empleado();
            empleado.Empleado_id = resultado.GetString(0);
            empleado.Nombres = resultado.GetString(1);
            empleado.Apellidos = resultado.GetString(2);
            empleado.Dni = resultado.GetString(3);
            empleado.Fechanacimiento = resultado.GetDateTime(4);
            empleado.Telefono = resultado.GetString(5);
            empleado.Correo = resultado.GetString(6);
            empleado.Direccion = resultado.GetString(7);

            return empleado;

        }



    }
}
