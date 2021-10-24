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


        public void guardar(Usuario usuario)
        {
            gestorSQL.AbrirConexion();
            usuarioSQL.guardar(usuario);
            gestorSQL.CerrarConexion();
        }










    }
}
