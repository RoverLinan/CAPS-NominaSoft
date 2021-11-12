using Capa3_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa4_Persistencia
{
    public class IncidenciaLaboralSQLServer
    {
        private GestorSQLServer gestorSQL;

        public IncidenciaLaboralSQLServer()
        {
            gestorSQL = GestorSQLServer.getInstance();
        }


        public bool guardar(IncidenciaLaboral incidencia)
        {

            try
            {

                string insertarSql = "INSERT INTO incidencialaboral(incidencia_id,periodo_id,contrato_id,totalhorasdefalta,totalhorasextras) " +
                                     "VALUES(@id,@pe_id,@c_id,@totalhfalta,@totalhxtras)";


                SqlCommand comando = new SqlCommand();
                comando = gestorSQL.ObtenerComandoSQL(insertarSql);
                comando.Parameters.AddWithValue("@id", new Random().Next(1, 10001));
                comando.Parameters.AddWithValue("@pe_id", incidencia.Periodo.Periodo_id);
                comando.Parameters.AddWithValue("@c_id", incidencia.Contrato.Contrato_id);
                comando.Parameters.AddWithValue("@totalhfalta", incidencia.Totalhorasdefalta);
                comando.Parameters.AddWithValue("@totalhxtras", incidencia.Totalhorasextras);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw err;
            }

        }

        public List<IncidenciaLaboral> listaIncidenciasPorIdContrato(string id)
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

                if (listaIncidencias.Count == 0)
                {
                    throw new Exception("No hay incidencias para este contrato");
                }

                return listaIncidencias;
            }
            catch (Exception err)
            {

                throw err;
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

                if (listaIncidencias.Count == 0)
                {
                    throw new Exception("No hay incidencias para este contrato");
                }

                return listaIncidencias;
            }
            catch (Exception err)
            {

                throw err;
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

                if (listaIncidencias.Count == 0)
                {
                    throw new Exception("No hay incidencias para este periodo");
                }

                return listaIncidencias;
            }
            catch (Exception err)
            {

                throw err;
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
