using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    class Empleado
    {
        private String empleado_id;
        private String nombres;
        private String apellidos;
        private String dni;
        private DateTime fechanacimiento;
        private String telefono;
        private String correo;
        private String direccion;


        public string Empleado_id { get => empleado_id; set => empleado_id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateTime Fechanacimiento { get => fechanacimiento; set => fechanacimiento = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
