using Capa3_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa4_Persistencia
{
    public class ContratoSqlServer
    {
        private readonly GestorSqlServer gestorSQL;

        public ContratoSqlServer()
        {
            gestorSQL = GestorSqlServer.getInstance();
        }

        public void guardar(Contrato contrato)
        {
            string insertarContrato = "INSERT INTO contrato(contrato_id,empleado_id,afp_id,fechainicio,fechafin" +
                                       ",tieneasignacionfamiliar,horasporsemana,pagoporhora,puesto,cancelado)" +
                                       " VALUES(@c_id,@e_id,@afp_id,@feini,@fefin,@asigfami,@hxsema,@pagxh,@puesto,@canc)";

            try
            {

                SqlCommand comando  = gestorSQL.ObtenerComandoSQL(insertarContrato);
                comando.Parameters.AddWithValue("@c_id", contrato.Contrato_id);
                comando.Parameters.AddWithValue("@e_id", contrato.Empleado.Empleado_id);
                comando.Parameters.AddWithValue("@afp_id", contrato.Afp.Afp_id);
                comando.Parameters.AddWithValue("@feini", contrato.Fechainicio);
                comando.Parameters.AddWithValue("@fefin", contrato.Fechafin);
                comando.Parameters.AddWithValue("@asigfami", contrato.Tieneasignacionfamiliar);
                comando.Parameters.AddWithValue("@hxsema", contrato.Horasporsemana);
                comando.Parameters.AddWithValue("@pagxh", decimal.Parse( contrato.Pagoporhora.ToString()));
                comando.Parameters.AddWithValue("@puesto", contrato.Puesto);
                comando.Parameters.AddWithValue("@canc", contrato.Cancelado);
                comando.ExecuteNonQuery();
               
            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
                throw;
            }

         
        }

        public List<Contrato> obtenerContratos()
        {

            List<Contrato> contratos = new List<Contrato>();
            string consultaSQL = "select   * from contrato where cancelado = 'false'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                while(resultadoSQL.Read())
                {
                    contratos.Add(obtenerContrato(resultadoSQL));
                }

               return contratos;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                throw;
            }
     

        }

        public bool actualizar(Contrato contrato)
        {

            string actualizarContrato = "UPDATE contrato set afp_id = @afp_id, fechainicio = @fechaini, fechafin=@fechafin" +
                                       ",tieneasignacionfamiliar=@asigfami,horasporsemana=@hxsema,pagoporhora=@pagxh,puesto=@puesto,cancelado=@canc" +
                                       " where contrato_id=@c_id";

            try
            {

                SqlCommand comando = gestorSQL.ObtenerComandoSQL(actualizarContrato);
                comando.Parameters.AddWithValue("@afp_id", contrato.Afp.Afp_id);
                comando.Parameters.AddWithValue("@fechaini", contrato.Fechainicio);
                comando.Parameters.AddWithValue("@fechafin", contrato.Fechafin);
                comando.Parameters.AddWithValue("@asigfami", contrato.Tieneasignacionfamiliar);
                comando.Parameters.AddWithValue("@hxsema", contrato.Horasporsemana);
                comando.Parameters.AddWithValue("@pagxh", decimal.Parse(contrato.Pagoporhora.ToString()));
                comando.Parameters.AddWithValue("@puesto", contrato.Puesto);
                comando.Parameters.AddWithValue("@canc", contrato.Cancelado);
                comando.Parameters.AddWithValue("@c_id", contrato.Contrato_id);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (SqlException err)
            {

                Console.WriteLine(err.ToString());
                throw;
            }


        }



        public Contrato buscarPorId(string id)
        {
            string consultaSQL = "select   * from contrato where contrato_id = '" + id + "'";

         

            try
            {
                Contrato contrato = null;
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                while (resultadoSQL.Read())
                {
                    if (obtenerContrato(resultadoSQL).EstaVigente())
                    {
                        contrato = obtenerContrato(resultadoSQL);
                        break;
                    }

                }
                return contrato;

            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                throw;
            }
            
        }



        public List<Contrato> buscarContratosPorIdEmpleado(string id)
        {
           
            string consultaSQL = "select   * from contrato where empleado_id = '" + id + "'";
            try
            {
                List<Contrato> contratos = new List<Contrato>();
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    contratos.Add(obtenerContrato(resultadoSQL));
                }
                return contratos;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                throw;
            }
          
        }


        public Contrato buscarContratoVigentePorIdEmpleado(string id)
        {
            

            DateTime fechActual = DateTime.Now;
            Console.WriteLine("fecha cortaaaaaa  :  " + fechActual.ToString("dd-MM-yyyy"));
            string consultaSQL = "select   * from contrato where empleado_id = '" + id + "' and fechafin > '"+fechActual.ToString("MM-dd-yyyy") +"'";
            Console.WriteLine(consultaSQL);

            try
            {
                Contrato contrato = null;
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                while(resultadoSQL.Read())
                {
                    if (obtenerContrato(resultadoSQL).EstaVigente())
                    {
                        contrato = obtenerContrato(resultadoSQL);
                        break;
                    }
                   
                }

                return contrato;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                throw;
            }
        
        }


        public bool cancelar(string idContrato)
        {
            try
            {
                string consultaSQL = "update contrato set cancelado = @valor where contrato_id = '" + idContrato + "'";


                SqlCommand comando = gestorSQL.ObtenerComandoSQL(consultaSQL);
                comando.Parameters.AddWithValue("@valor", true);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
                throw;
            }
           
        }

        public Contrato obtenerContrato(SqlDataReader resultado)
        {
            Contrato contrato = new Contrato();
            Afp afp = new Afp();
            Empleado empleado = new Empleado();

            contrato.Afp = afp;
            contrato.Empleado = empleado;

            contrato.Contrato_id = resultado.GetString(0);
            contrato.Empleado.Empleado_id = resultado.GetString(1);
            contrato.Afp.Afp_id = resultado.GetInt32(2);
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
