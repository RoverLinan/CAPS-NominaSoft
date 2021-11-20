using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    public class Nomina
    {
        public  String Nomina_id { get; set; }
        public DateTime Fecha { get; set; }
        public String Descripcion { get; set; }
        public bool Cerrada { get; set; }

        public PeriodoDeNomina Periodo { get; set; }
        public List<BoletaDePago> BoletaDePagos { get; set; }
        


        //REGLA-06

        public bool ValidarFechaContratos()
        {
            foreach (BoletaDePago item in BoletaDePagos)
            {
                if(item.Contrato.Fechafin.CompareTo(Periodo.Fechainicio) == 1 && !item.Contrato.Cancelado)
                {
                    return true;
                }
            }

            return false;
        }
        //REGLA-06
        public bool ValidarFechaFinPeriodo()
        {
            Console.WriteLine(Periodo.Fechafin.ToString() + "  -----  " + this.Fecha.ToString());
            if (Periodo.Fechafin.CompareTo(this.Fecha) == -1)
            {
                
                return true;
            }
            return false;
        }
        //REGLA-06
        public bool EsFactibleGenerarNomina()
        {
            if(ValidarFechaContratos() && ValidarFechaFinPeriodo())
            {
                return true;
            }

            return false;
        }

        //REGLA-16
        public bool ValidarRestaFechaFinPeriodo()
        {
            var timeSpan = Periodo.Fechafin - Periodo.Fechainicio;
            if (timeSpan.TotalDays > 15 && timeSpan.TotalDays < 30)
            {
                return true;
            }
            return false;
        }




        public bool esValidoFechaGeneracionNomina()
        {

            if(Fecha.CompareTo(Periodo.Fechafin) == 1)
            {
                return true;
            }

            return false;
        }


        //REGLA-17

        public bool TienePagosEmpleados()
        {
            if(BoletaDePagos.Count > 0)
            {
                return true;
            }

            return false;
        }

        //REGLA 20
        public double calcularTotalIngresosNomina()
        {
            double total = 0;   

            foreach (BoletaDePago boleta in BoletaDePagos)
            {
                total += boleta.CalcularTotalIngresos();
            }

            return total;

        }

        //REGLA 21
        public double calcularTotalRetencionesNomina()
        {
            double total = 0;

            foreach (BoletaDePago boleta in BoletaDePagos)
            {
                total += boleta.CalcularTotalRetenciones();
            }

            return total;

        }

        //regla 22
        public double calcularTotalSueldoNetoNomina()
        {
            double total = 0;

            foreach (BoletaDePago boleta in BoletaDePagos)
            {
                total += boleta.CalcularNetoAPagar();
            }

            return total;

        }


        public bool ValidarNomina(out string mensaje)
        {
            bool cumple = true;
            mensaje = "Se incumplen las sguientes reglas: \n";

            if (!TienePagosEmpleados())
            {

             
                mensaje += "* No se puede guardar la Nómina porque se incumple la regla para guardar la Nómina\n";
                cumple = false;

            }

            if (!EsFactibleGenerarNomina())
            {

             
                mensaje += "* No es factible generar la nomina por error en la fecha de periodos\n";
                cumple = false;
            }

            if (!esValidoFechaGeneracionNomina())
            {
        
                mensaje += "* La fecha de  generacion de la nomina es menor que la fecha del periodo";
                cumple = false;
            }

            return cumple;
        }



    }
}
