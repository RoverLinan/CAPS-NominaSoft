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
                                      ",reintegros,movilidad,otrosigresos,regimenpensionario,montoporhorasdefalta,adelantos,otrosdescuentos) " +
                                      "VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13)";


            try
            {
                SqlCommand comando = new SqlCommand();
                comando = gestorSQL.ObtenerComandoSQL(insertarBoleta);
                comando.Parameters.AddWithValue("@1", "BOL" + new Random().Next(1000, 9999));
                comando.Parameters.AddWithValue("@2", boleta.Contrato.Contrato_id);
                comando.Parameters.AddWithValue("@3", boleta.Nomina.Nomina_id);
                comando.Parameters.AddWithValue("@4", boleta.Sueldobasico);
                comando.Parameters.AddWithValue("@5", boleta.Asignacionfamiliar);
                comando.Parameters.AddWithValue("@6", boleta.Montoporhoraextras);
                comando.Parameters.AddWithValue("@7", boleta.Reintegros);
                comando.Parameters.AddWithValue("@8", boleta.Movilidad);
                comando.Parameters.AddWithValue("@9", boleta.Otrosingresos);
                comando.Parameters.AddWithValue("@10", boleta.Regimenpensionario);
                comando.Parameters.AddWithValue("@11", boleta.Montoporhorasdefalta);
                comando.Parameters.AddWithValue("@12", boleta.Adelantos);
                comando.Parameters.AddWithValue("@13", boleta.Otrosdescuentos);
                comando.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {

                throw err;
            }

        }


        public BoletaDePago obtenerBoleta(SqlDataReader resultado)
        {
            BoletaDePago boleta = new BoletaDePago();

            boleta.Sueldobasico =  double.Parse(resultado.GetDecimal(1).ToString());
            boleta.Asignacionfamiliar = double.Parse(resultado.GetDecimal(2).ToString());
            boleta.Montoporhoraextras = double.Parse(resultado.GetDecimal(3).ToString());
            boleta.Reintegros = double.Parse(resultado.GetDecimal(4).ToString());
            boleta.Movilidad = double.Parse(resultado.GetDecimal(5).ToString());

            return boleta;

        }


    }
}
