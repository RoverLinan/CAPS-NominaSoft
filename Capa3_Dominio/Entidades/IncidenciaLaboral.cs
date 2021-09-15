using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    public class IncidenciaLaboral
    {
        private int incidencia_id;
        private int totalhorasdefalta;
        private int totalhorasextras;

        private PeriodoDeNomina periodo;

        public int Incidencia_id { get => incidencia_id; set => incidencia_id = value; }
        public int Totalhorasdefalta { get => totalhorasdefalta; set => totalhorasdefalta = value; }
        public int Totalhorasextras { get => totalhorasextras; set => totalhorasextras = value; }
    }
}
