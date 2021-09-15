using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    public class Nomina
    {
        private String nomina_id;
        private DateTime fecha;
        private String descripcion;
        private bool cerrada;

        private PeriodoDeNomina periodo;
        private List<BoletaDePago> boletaDePagos;
        

        public string Nomina_id { get => nomina_id; set => nomina_id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Cerrada { get => cerrada; set => cerrada = value; }
    }
}
