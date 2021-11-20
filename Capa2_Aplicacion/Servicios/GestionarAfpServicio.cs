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
    public class GestionarAfpServicio
    {

        private readonly GestorSqlServer gestorSQL = GestorSqlServer.getInstance();
        private readonly AfpSqlServer afpSQL  = new AfpSqlServer();

        public GestionarAfpServicio()
        {
            
        }

        public void guardarAfp(Afp afp)
        {
            try
            {
                gestorSQL.AbrirConexion();
                afpSQL.guardar(afp);
                gestorSQL.CerrarConexion();
              
            }
            catch (SqlException err)
            {
                Console.WriteLine(err.ToString());
                throw;
            }


        }

        public Afp buscarAfpPorId(int id)
        {
           
            try
            {
                gestorSQL.AbrirConexion();
                Afp afp = afpSQL.buscarAfpPorId(id);
                gestorSQL.CerrarConexion();

                return afp;
            }
            catch (SqlException err)
            {
                Console.WriteLine(err.ToString());
                throw;
            }

        }

        public List<Afp> obtenerListaAfp()
        {
            try
            {
                gestorSQL.AbrirConexion();
                List<Afp> listaAfp = afpSQL.listaAfp();
                gestorSQL.CerrarConexion();

                return listaAfp;
            }
            catch (SqlException err)
            {
                Console.WriteLine(err.ToString());
                throw;
            }
        }
    }
}
