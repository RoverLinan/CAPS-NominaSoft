using Capa3_Dominio.Entidades;
using Capa4_Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa2_Aplicacion.Servicios
{
    public class GestionarAfpServicio
    {

        private GestorSQLServer gestorSQL;
        private AfpSQLServer afpSQL;

        public GestionarAfpServicio()
        {
            gestorSQL = GestorSQLServer.getInstance();
            afpSQL = new AfpSQLServer();
        }

        public bool guardarAfp(Afp afp)
        {
            try
            {
                gestorSQL.AbrirConexion();
                afpSQL.guardar(afp);
                gestorSQL.CerrarConexion();
                return true;
            }
            catch (Exception err)
            {

                throw err;
            }


        }

        public Afp buscarAfpPorId(int id)
        {
            Afp afp;
            try
            {
                gestorSQL.AbrirConexion();
                afp = afpSQL.buscarAfpPorId(id);
                gestorSQL.CerrarConexion();

                return afp;
            }
            catch (Exception err)
            {

                throw err;
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
            catch (Exception err)
            {

                throw err;
            }
        }
    }
}
