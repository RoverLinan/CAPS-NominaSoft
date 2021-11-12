using Capa3_Dominio.Entidades;
using Capa4_Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa2_Aplicacion.Servicios
{
    public class GestionarBoletaDePagoServicio
    {
        private GestorSQLServer gestorSQL;
        private BoletaDePagoSQLServer boletaDePagoSQL;
        private GestionarContratoServicio gestionarContratoServicio;

        public GestionarBoletaDePagoServicio()
        {
            gestorSQL = GestorSQLServer.getInstance();
            boletaDePagoSQL = new BoletaDePagoSQLServer();
            gestionarContratoServicio = new GestionarContratoServicio();
        }
            

        public bool guardar(BoletaDePago boleta)
        {


            try
            {
                gestorSQL.AbrirConexion();
                bool completado = boletaDePagoSQL.guardar(boleta);
                gestorSQL.CerrarConexion();
                return completado;
            }
            catch (Exception err)
            {

                throw err;
            }

           
        }


        public List<BoletaDePago> buscarBoletasPorIdNomina(Nomina nomina)
        {
            try
            {
                gestorSQL.AbrirConexion();
                List<BoletaDePago> listaBoletas = boletaDePagoSQL.buscarPorIdNomina(nomina);
                gestorSQL.CerrarConexion();




                return listaBoletas;
            }
            catch (Exception err) 
            {

                throw err;
            }



        }




    }
}
