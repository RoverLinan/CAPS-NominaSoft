using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    public class SesionSingleton
    {
        private Usuario usuario;
        private static SesionSingleton instance;


        private SesionSingleton()
        {

        }

        public static SesionSingleton getInstance()
        {
            if(instance == null)
            {
                instance = new SesionSingleton();
            }

            return instance;
        }

        public static Usuario getUsuarioSingleton()
        {
            return instance.GetUsuario();
        }

        public static void setUsuarioSingleton(Usuario user)
        {
            instance.SetUsuario(user);
        }

        public Usuario GetUsuario()
        {
            return usuario;
        }
        public void SetUsuario(Usuario user)
        {
            this.usuario = user;
        }



    }
}
