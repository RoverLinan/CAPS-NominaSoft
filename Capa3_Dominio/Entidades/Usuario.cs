using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    public class Usuario
    {
        private int id;
        private String username;
        private String password;
        private DateTime fechaCreacion;
        private string rol;

        
        
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public int Id { get => id; set => id = value; }
        public string Rol { get => rol; set => rol = value; }

       

    }
}
