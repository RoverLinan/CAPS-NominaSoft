using Capa3_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa4_Persistencia
{
    public class ContratoSQLServer
    {
        private GestorSQLServer gestorSQL;

        public ContratoSQLServer()
        {
            gestorSQL = GestorSQLServer.getInstance();
        }

        public bool guardar(Contrato contrato, Empleado empleado, Afp afp)
        {
            string insertarContrato = "INSERT INTO contrato(contrato_id,empleado_id,afp_id,fechainicio,fechafin" +
                                       ",tieneasignacionfamiliar,horasporsemana,pagoporhora,puesto,cancelado)" +
                                       " VALUES(@c_id,@e_id,@afp_id,@feini,@fefin,@asigfami,@hxsema,@pagxh,@puesto,@canc)";

            try
            {
                SqlCommand comando = new SqlCommand();
                comando = gestorSQL.ObtenerComandoSQL(insertarContrato);
                comando.Parameters.AddWithValue("@c_id", "CON" + empleado.Dni);
                comando.Parameters.AddWithValue("@e_id", empleado.Empleado_id);
                comando.Parameters.AddWithValue("@afp_id", afp.Afp_id);
                comando.Parameters.AddWithValue("@feini", contrato.Fechainicio);
                comando.Parameters.AddWithValue("@fefin", contrato.Fechafin);
                comando.Parameters.AddWithValue("@asigfami", contrato.Tieneasignacionfamiliar);
                comando.Parameters.AddWithValue("@hxsema", contrato.Horasporsemana);
                comando.Parameters.AddWithValue("@pagxh", decimal.Parse( contrato.Pagoporhora.ToString()));
                comando.Parameters.AddWithValue("@puesto", contrato.Puesto);
                comando.Parameters.AddWithValue("@canc", contrato.Cancelado);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw err;
            }

         
        }

        public List<Contrato> buscarContratosPorIdEmpleado(string id)
        {
            List<Contrato> contratos = new List<Contrato>();
            string consultaSQL = "select   * from contrato where empleado_id = '" + id + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    contratos.Add(obtenerContrato(resultadoSQL));
                }
                else
                {
                    throw new Exception("No hay contratos asignados");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return contratos;
        }


        public Contrato buscarContratoVigentePorIdEmpleado(string id)
        {
            Contrato contrato = new Contrato();
            DateTime fechActual = DateTime.Now;

            string consultaSQL = "select   * from contrato where empleado_id = '" + id + "' and fechafin >= '"+fechActual.ToShortDateString()+"'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    contrato = obtenerContrato(resultadoSQL);
                }
                else
                {
                    throw new Exception("No hay contratos vigentes ");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return contrato;
        }

        public Contrato obtenerContrato(SqlDataReader resultado)
        {
            Contrato contrato = new Contrato();

            contrato.Contrato_id = resultado.GetString(0);
            contrato.Fechainicio = resultado.GetDateTime(3);
            contrato.Fechafin = resultado.GetDateTime(4);
            contrato.Tieneasignacionfamiliar = resultado.GetBoolean(5);
            contrato.Horasporsemana = resultado.GetInt32(6);
            contrato.Pagoporhora =  Double.Parse( resultado.GetDecimal(7).ToString());
            contrato.Puesto = resultado.GetString(8);
            contrato.Cancelado = resultado.GetBoolean(9);

            return contrato;
        }

    }
}
