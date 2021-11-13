using Capa3_Dominio.Entidades;
using Capa4_Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa2_Aplicacion.Servicios
{
    public class GestionarPeriodoNominaServicio
    {
        private GestorSQLServer gestorSQL;
        private PeriodoDeNominaSQLServer periodoNominaSQL;

        public GestionarPeriodoNominaServicio()
        {
            gestorSQL = GestorSQLServer.getInstance();
            periodoNominaSQL = new PeriodoDeNominaSQLServer();
        }

        public bool guardarPeriodoDeNomina(PeriodoDeNomina periodoDeNomina)
        {
            try
            {

                if (periodoDeNomina.tieneFechaFinValida() == false)
                {
                    throw new Exception("fecha fin: El periodo no cumple con la regla 16");
                }

                gestorSQL.AbrirConexion();
                periodoNominaSQL.guardar(periodoDeNomina);
                gestorSQL.CerrarConexion();
                return true;
            }
            catch (Exception err)
            {

                throw err;
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

                throw err;
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

                throw err;
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
            catch (Exception err)
            {

                throw err;
            }
        }

    }
}
