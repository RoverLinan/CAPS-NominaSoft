﻿using Capa3_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa4_Persistencia
{
    public class NominaSQLServer
    {
        private GestorSQLServer gestorSQL;

        public NominaSQLServer()
        {
            gestorSQL = GestorSQLServer.getInstance();
        }

        public bool guardar(Nomina nomina)
        {

            string insertarNomina = "INSERT INTO nomina(nomina_id,periodo_id,fecha,descripcion,cerrada) " +
                                    "VALUES(@id,@per_id,@fecha,@descripcion,@cerrada)";


            try
            {
                SqlCommand comando = new SqlCommand();
                comando = gestorSQL.ObtenerComandoSQL(insertarNomina);
                comando.Parameters.AddWithValue("@id", "NOM" + new Random().Next(1000, 9999));
                comando.Parameters.AddWithValue("@per_id", nomina.Periodo.Periodo_id);
                comando.Parameters.AddWithValue("@fecha", nomina.Fecha);
                comando.Parameters.AddWithValue("@descripcion", nomina.Descripcion);
                comando.Parameters.AddWithValue("@cerrada", nomina.Cerrada);
     
                comando.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {

                throw err;
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

                if (listaNomina.Count == 0)
                {
                    throw new Exception("No hay coincidencias de nominas");
                }

                return listaNomina;
            }
            catch (Exception err)
            {

                throw err;
            }
        }


        private Nomina obtenerNomina(SqlDataReader resultado)
        {
            Nomina nomina = new Nomina();
            PeriodoDeNomina periodo = new PeriodoDeNomina();
            nomina.Periodo = periodo;

            nomina.Nomina_id = resultado.GetString(0);
            nomina.Periodo.Periodo_id = resultado.GetString(1);
            nomina.Fecha = resultado.GetDateTime(2);
            nomina.Descripcion = resultado.GetString(3);
            nomina.Cerrada = resultado.GetBoolean(5);

            return nomina;
        }


    }
}
