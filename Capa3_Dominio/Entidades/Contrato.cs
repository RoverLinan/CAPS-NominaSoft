using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    public class Contrato
    {
        private String contrato_id;
        private DateTime fechainicio;
        private DateTime fechafin;
        private bool tieneasignacionfamiliar;
        private int horasporsemana;
        private double pagoporhora;
        private String puesto;
        private bool cancelado;

        private Afp afp;
        private Empleado empleado;
        private List<IncidenciaLaboral> incidencias;


        public string Contrato_id { get => contrato_id; set => contrato_id = value; }
        public DateTime Fechainicio { get => fechainicio; set => fechainicio = value; }
        public DateTime Fechafin { get => fechafin; set => fechafin = value; }
        public bool Tieneasignacionfamiliar { get => tieneasignacionfamiliar; set => tieneasignacionfamiliar = value; }
        public int Horasporsemana { get => horasporsemana; set => horasporsemana = value; }
        public double Pagoporhora { get => pagoporhora; set => pagoporhora = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public bool Cancelado { get => cancelado; set => cancelado = value; }
    }
}
