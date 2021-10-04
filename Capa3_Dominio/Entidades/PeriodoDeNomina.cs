using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    public class PeriodoDeNomina
    {
        private String periodo_id;
        private String descripcion;
        private DateTime fechainicio;
        private DateTime fechafin;

        List<IncidenciaLaboral> incidenciasLaborales;
        List<Nomina> listaNominas;

        public string Periodo_id { get => periodo_id; set => periodo_id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fechainicio { get => fechainicio; set => fechainicio = value; }
        public DateTime Fechafin { get => fechafin; set => fechafin = value; }


        //REGLA-06
        public int CalcularTotalSemanas()
        {
            
            if (fechafin.CompareTo(fechainicio) == 1)
            {
                TimeSpan diffechas = fechafin - fechainicio;
                int dias = diffechas.Days;

                return dias / 7;

            }
            return 0;
        }

    }
}
