using Capa3_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa4_Persistencia
{
    public class IncidenciaLaboralSqlServer
    {
        private readonly GestorSqlServer gestorSQL;

        public IncidenciaLaboralSqlServer()
        {
            gestorSQL = GestorSqlServer.getInstance();
        }


        public bool guardar(IncidenciaLaboral incidencia)
        {

            try
            {

                string insertarSql = "INSERT INTO incidencialaboral(incidencia_id,periodo_id,contrato_id,totalhorasdefalta,totalhorasextras) " +
                                     "VALUES(@id,@pe_id,@c_id,@totalhfalta,@totalhxtras)";



                SqlCommand comando = gestorSQL.ObtenerComandoSQL(insertarSql);
                comando.Parameters.AddWithValue("@id",incidencia.Incidencia_id);
                comando.Parameters.AddWithValue("@pe_id", incidencia.Periodo.Periodo_id);
                comando.Parameters.AddWithValue("@c_id", incidencia.Contrato.Contrato_id);
                comando.Parameters.AddWithValue("@totalhfalta", incidencia.Totalhorasdefalta);
                comando.Parameters.AddWithValue("@totalhxtras", incidencia.Totalhorasextras);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
                throw;
            }

        }


        public List<IncidenciaLaboral> obtenerListaPorIdContrato(string id)
        {

            string buscarSql = "SELECT * FROM incidencialaboral where contrato_id ='" + id + "'";
            List<IncidenciaLaboral> listaIncidencias = new List<IncidenciaLaboral>();

            try
            {
                SqlDataReader resultado = gestorSQL.EjecutarConsulta(buscarSql);

                while (resultado.Read())
                {
                    listaIncidencias.Add(obtenerIncidencia(resultado));
                }


                return listaIncidencias;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
                throw;
            }



        }






        public List<IncidenciaLaboral> obtenerPorIdPeriodo(string id)
        {
            string buscarSql = "SELECT * FROM incidencialaboral where periodo_id ='" + id + "'";
            List<IncidenciaLaboral> listaIncidencias = new List<IncidenciaLaboral>();

            try
            {
                SqlDataReader resultado = gestorSQL.EjecutarConsulta(buscarSql);

                while (resultado.Read())
                {
                    listaIncidencias.Add(obtenerIncidencia(resultado));
                }

             
                return listaIncidencias;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
                throw;
            }

        }

        private IncidenciaLaboral obtenerIncidencia(SqlDataReader resultado)
        {
            IncidenciaLaboral incidencia = new IncidenciaLaboral();
            incidencia.Periodo = new PeriodoDeNomina();
            incidencia.Contrato = new Contrato();

            incidencia.Incidencia_id = resultado.GetInt32(0);
            incidencia.Periodo.Periodo_id = resultado.GetString(1);
            incidencia.Contrato.Contrato_id = resultado.GetString(2);
            incidencia.Totalhorasdefalta = resultado.GetInt32(3);
            incidencia.Totalhorasextras = resultado.GetInt32(4);
            return incidencia;

        }




    }
}
