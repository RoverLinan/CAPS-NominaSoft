using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    public class PeriodoDeNomina
    {
        public String Periodo_id { get; set; }
        public String Descripcion { get; set; }
        public DateTime Fechainicio { get; set; }
        public DateTime Fechafin { get; set; }

   

    


        //implementacion para cumplir con la REGLA 7
        public int CalcularTotalSemanas()
        {
            
            if (Fechafin.CompareTo(Fechainicio) == 1)
            {
                TimeSpan diffechas = Fechafin - Fechainicio;
                int dias = diffechas.Days;
                return dias / 7;

            }
            return 0;
        }

        //REGLA -16
        public bool tieneFechaFinValida()
        {
            TimeSpan diffechas = Fechafin - Fechainicio;
            Console.WriteLine("diferencia de dias: " + diffechas.Days);
            if(diffechas.Days > 15 && diffechas.Days < 30)
            {
                return true;
            }

            return false;

        }

    }
}
