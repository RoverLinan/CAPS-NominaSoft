using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    public class Afp
    {
        private int afp_id;
        private String nombre;
        private double porcentajedescuento;

        public int Afp_id { get => afp_id; set => afp_id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Porcentajedescuento { get => porcentajedescuento; set => porcentajedescuento = value; }
    }
}
