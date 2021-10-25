using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa3_Dominio.Entidades;
using Capa4_Persistencia;

namespace Capa2_Aplicacion.Servicios
{
    public class GestionarUsuarioServicio
    {
        private UsuarioSQLServer usuarioSQL;
        private GestorSQLServer gestorSQL;

        
        public GestionarUsuarioServicio()
        {
            this.usuarioSQL = new UsuarioSQLServer();
            this.gestorSQL = GestorSQLServer.getInstance();
        }


        public bool guardar(Usuario usuario)
        {
            gestorSQL.AbrirConexion();
            usuarioSQL.guardar(usuario);
            gestorSQL.CerrarConexion();
            return true;
        }


        public Usuario iniciarSesion(string username, string password)
        {
            try
            {
                gestorSQL.AbrirConexion();
                Usuario usuario = usuarioSQL.validarUsuario(username, password);
                gestorSQL.CerrarConexion();
                return usuario;
            }
            catch (Exception err)
            {
                throw err;
            }
            
        
        }










    }
}
