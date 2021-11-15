using Capa3_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa4_Persistencia
{
    public class BoletaDePagoSQLServer
    {
        private GestorSQLServer gestorSQL;


        public BoletaDePagoSQLServer()
        {
            gestorSQL = GestorSQLServer.getInstance();
        }



        public bool guardar(BoletaDePago boleta)
        {
            string insertarBoleta = "INSERT INTO boletadepago(boleta_id,contrato_id,nomina_id,sueldobasico,asignacionfamiliar,montoporhorasextras" +
                                      ",reintegros,movilidad,otrosingresos,regimenpensionario,montoporhorasdefalta,adelantos,otrosdescuentos) " +
                                      "VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13)";


            try
            {
                SqlCommand comando = new SqlCommand();
                comando = gestorSQL.ObtenerComandoSQL(insertarBoleta);
                comando.Parameters.AddWithValue("@1", boleta.Boleta_id);
                comando.Parameters.AddWithValue("@2", boleta.Contrato.Contrato_id);
                comando.Parameters.AddWithValue("@3", boleta.Nomina.Nomina_id);
                comando.Parameters.AddWithValue("@4", boleta.Sueldobasico);
                comando.Parameters.AddWithValue("@5", boleta.Asignacionfamiliar);
                comando.Parameters.AddWithValue("@6", boleta.Montoporhoraextras);
                comando.Parameters.AddWithValue("@7", boleta.Reintegros = 0);
                comando.Parameters.AddWithValue("@8", boleta.Movilidad = 0);
                comando.Parameters.AddWithValue("@9", boleta.Otrosingresos = 0);
                comando.Parameters.AddWithValue("@10", boleta.Regimenpensionario);
                comando.Parameters.AddWithValue("@11", boleta.Montoporhorasdefalta);
                comando.Parameters.AddWithValue("@12", boleta.Adelantos = 0);
                comando.Parameters.AddWithValue("@13", boleta.Otrosdescuentos = 0);
                comando.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {

                throw err;
            }

        }


        public List<BoletaDePago> buscarPorIdNomina(Nomina nomina)
        {

            string selectBoletas = "SELECT * FROM boletadepago where nomina_id = '" + nomina.Nomina_id + "'";
            List<BoletaDePago> listaBoletas = new List<BoletaDePago>();
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(selectBoletas);
                while (resultadoSQL.Read())
                {
                    BoletaDePago boletaDePago = obtenerBoleta(resultadoSQL);
                    boletaDePago.Nomina = nomina;

                    listaBoletas.Add(boletaDePago);
                }

                if (listaBoletas.Count == 0)
                {
                    throw new Exception("No hay boletas generadas para esta nomina");
                }
                return listaBoletas;
            }
            catch (Exception err)
            {
                throw err;
            }

        }


        public void eliminarPorIdNomina(string id)
        {
            
            try
            {
                string eliminarSql = "DELETE FROM boletadepago  where nomina_id = '" + id + "'";
                SqlCommand comando = new SqlCommand();
                comando = gestorSQL.ObtenerComandoSQL(eliminarSql);
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {

                throw err;
            }


        }






        public BoletaDePago obtenerBoleta(SqlDataReader resultado)
        {
            BoletaDePago boleta = new BoletaDePago();
            boleta.Contrato = new Contrato();
            boleta.Nomina = new Nomina();

            boleta.Boleta_id =              resultado.GetString(0);
            boleta.Contrato.Contrato_id =   resultado.GetString(1);
            boleta.Nomina.Nomina_id =       resultado.GetString(2);
            boleta.Sueldobasico =           double.Parse(resultado.GetDecimal(3).ToString());
            boleta.Asignacionfamiliar =     double.Parse(resultado.GetDecimal(4).ToString());
            boleta.Montoporhoraextras =     double.Parse(resultado.GetDecimal(5).ToString());
            boleta.Reintegros =             double.Parse(resultado.GetDecimal(6).ToString());
            boleta.Movilidad =              double.Parse(resultado.GetDecimal(7).ToString());
            boleta.Otrosingresos =          double.Parse(resultado.GetDecimal(8).ToString());
            boleta.Regimenpensionario =     double.Parse(resultado.GetDecimal(9).ToString());
            boleta.Montoporhorasdefalta =   double.Parse(resultado.GetDecimal(10).ToString());
            boleta.Adelantos =              double.Parse(resultado.GetDecimal(11).ToString());
            boleta.Otrosdescuentos =        double.Parse(resultado.GetDecimal(12).ToString());

            return boleta;

        }


    }
}
