using Capa3_Dominio.Entidades;
using Capa4_Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa2_Aplicacion.Servicios
{
    public class GestionarPeriodoNominaServicio
    {
        private readonly GestorSqlServer gestorSQL;
        private readonly PeriodoDeNominaSqlServer periodoNominaSQL;

        public GestionarPeriodoNominaServicio()
        {
            gestorSQL = GestorSqlServer.getInstance();
            periodoNominaSQL = new PeriodoDeNominaSqlServer();
        }

        public bool guardarPeriodoDeNomina(PeriodoDeNomina periodoDeNomina)
        {
            try
            {

               

                gestorSQL.AbrirConexion();
                periodoNominaSQL.guardar(periodoDeNomina);
                gestorSQL.CerrarConexion();
                return true;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
                throw;
            }


        }

        public PeriodoDeNomina buscarPeriodoPorId(string id)
        {
            PeriodoDeNomina periodoDeNomina;
            try
            {
                gestorSQL.AbrirConexion();
                periodoDeNomina = periodoNominaSQL.buscarPeriodoPorId(id);
                gestorSQL.CerrarConexion();

                return periodoDeNomina;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
                throw;
            }

        }



        public List<PeriodoDeNomina> buscarPeriodoPorIdNomina(Nomina nomina)
        {

          
            try
            {
                List<PeriodoDeNomina> listaPeriodoDeNomina;
                gestorSQL.AbrirConexion();
                listaPeriodoDeNomina = periodoNominaSQL.buscarPeriodosPorIdNomina(nomina);
                gestorSQL.CerrarConexion();

                return listaPeriodoDeNomina;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
                throw;
            }




        }

        public List<PeriodoDeNomina> obtenerListaPeriodo()
        {
            try
            {
                gestorSQL.AbrirConexion();
                List<PeriodoDeNomina> listaPeriodo = periodoNominaSQL.listarPeriodo();
                gestorSQL.CerrarConexion();

                return listaPeriodo;
            }
            catch (SqlException err)
            {

                Console.WriteLine(err.ToString());
                throw;
            }
        }

    }
}
