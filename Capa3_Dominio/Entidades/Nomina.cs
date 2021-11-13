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
        private List<BoletaDePago> boletaDePagos = new List<BoletaDePago>();
        

        public string Nomina_id { get => nomina_id; set => nomina_id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Cerrada { get => cerrada; set => cerrada = value; }
        public PeriodoDeNomina Periodo { get => periodo; set => periodo = value; }
        public List<BoletaDePago> BoletaDePagos { get => boletaDePagos; set => boletaDePagos = value; }

        //REGLA-06

        public bool ValidarFechaContratos()
        {
            foreach (BoletaDePago item in boletaDePagos)
            {
                if(item.Contrato.Fechafin.CompareTo(periodo.Fechainicio) == 1 && item.Contrato.Cancelado == false)
                {
                    return true;
                }
            }

            return false;
        }
        //REGLA-06
        public bool ValidarFechaFinPeriodo()
        {
            Console.WriteLine(periodo.Fechafin.ToString() + "  -----  " + this.fecha.ToString());
            if (periodo.Fechafin.CompareTo(this.fecha) == -1)
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
            var timeSpan = periodo.Fechafin - periodo.Fechainicio;
            if (timeSpan.TotalDays > 15 && timeSpan.TotalDays < 30)
            {
                return true;
            }
            return false;
        }




        public bool esValidoFechaGeneracionNomina()
        {

            if(fecha.CompareTo(Periodo.Fechafin) == 1)
            {
                return true;
            }

            return false;
        }


        //REGLA-17

        public bool TienePagosEmpleados()
        {
            if(boletaDePagos.Count > 0)
            {
                return true;
            }

            return false;
        }

        //REGLA 20
        public double calcularTotalIngresosNomina()
        {
            double total = 0;   

            foreach (BoletaDePago boleta in boletaDePagos)
            {
                total += boleta.CalcularTotalIngresos();
            }

            return total;

        }

        //REGLA 21
        public double calcularTotalRetencionesNomina()
        {
            double total = 0;

            foreach (BoletaDePago boleta in boletaDePagos)
            {
                total += boleta.CalcularTotalRetenciones();
            }

            return total;

        }

        //regla 22
        public double calcularTotalSueldoNetoNomina()
        {
            double total = 0;

            foreach (BoletaDePago boleta in boletaDePagos)
            {
                total += boleta.CalcularNetoAPagar();
            }

            return total;

        }



    }
}
