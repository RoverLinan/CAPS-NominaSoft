using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    public class Contrato
    {
        public String Contrato_id { get; set; }
        public DateTime Fechainicio { get; set; }
        public DateTime Fechafin { get; set; }
        public bool Tieneasignacionfamiliar { get; set; }
        public int Horasporsemana { get; set; }
        public double Pagoporhora { get; set; }
        public String Puesto { get; set; }
        public bool Cancelado { get; set; }

        public Afp Afp { get; set; }
        public Empleado Empleado { get; set; }
        public List<IncidenciaLaboral> Incidencias { get; set; }


      


        //REGLA-01
        public bool EstaVigente()
        {
            bool estado = false;



            DateTime fechaActual = DateTime.Parse(DateTime.Now.ToShortDateString());

            if ((Fechafin.CompareTo(fechaActual) == 0 || Fechafin.CompareTo(fechaActual)==1) && !Cancelado)
            {
                estado = true;
            }
            

            return estado;
        }


        //REGLA-02
        public bool ValidarFechaInicio()
        {
            bool estado = false;
            

         
            DateTime fechaActual = DateTime.Parse(DateTime.Now.ToShortDateString());

            if (Fechainicio.CompareTo(fechaActual) == 0 || Fechainicio.CompareTo(fechaActual) == 1)
            {
                estado = true;
            }
            return estado;
        }

        //regla-03
        public bool ValidarFechaFin()
        {
            bool estado = false;
            Console.WriteLine(Fechafin.ToShortDateString() + "  " + Fechainicio.ToShortDateString());
            if(Fechafin.CompareTo(Fechainicio) == 1)
            {
                if((Fechafin.Year - Fechainicio.Year == 0) &&  (Fechafin.Month - Fechainicio.Month) >= 3)
                {
                    estado = true;
                }
                if(Fechafin.Year - Fechainicio.Year == 1)
                {
                    int cantidadmeses = (12 - Fechainicio.Month) + Fechafin.Month;
                    if(cantidadmeses >=3  && cantidadmeses <= 12)
                    {
                        estado = true;
                    }

                }

            }
            Console.WriteLine(estado);
            return estado;

        }
        

        //REGLA-04

        public bool ViladarHorasPorSemana()
        {
            if((Horasporsemana >= 8 && Horasporsemana <= 40 ) && Horasporsemana % 4 == 0)
            {
                return true;
            }
            return false;
        }

        //REGLA-05
        public bool ValidarPagoPorHora()
        {
            if(Pagoporhora >= 10 && Pagoporhora <= 60)
            {
                return true;
            }

            return false;
        }

        
        //REGLA-10
        public double CalcularMontoPorHorasExtras(string periodo_id)
        {
            int totalHorasExtras = 0;
            foreach (IncidenciaLaboral item in Incidencias)
            {
                if (item.Periodo.Periodo_id.Equals(periodo_id))
                {
                    totalHorasExtras += item.Totalhorasextras;
                }
               
            }

            return totalHorasExtras * Pagoporhora;
        }

        //REGLA-13
        public double CalcularHorasFalta(string periodo_id)
        {
            double totalHorasFalta = 0;
            if (Incidencias.Count > 0)
            {
                foreach (IncidenciaLaboral incidenciaLaboral in Incidencias)
                {
                    if (incidenciaLaboral.Periodo.Periodo_id.Equals(periodo_id))
                    {
                        totalHorasFalta += incidenciaLaboral.Totalhorasdefalta;
                    }
                    
                }
            }
            return totalHorasFalta;
        }

        //REGLA-13
        public double CalcularMontoHorasFalta(string periodo_id)
        {

            return CalcularHorasFalta(periodo_id) * Pagoporhora;
        }





        public bool ValidarContrato(out String mensaje)
        {
            mensaje = "Se incumplen las sguientes reglas: \n";
            bool cumple = true;
            if (!ValidarFechaInicio())
            {
                
                mensaje += "* fecha inicio incorrecta \n";
                cumple = false;
            }

            if (!ValidarFechaFin())
            {
                
                mensaje += "* fecha fin incorrecta\n";
                cumple = false;
            }

            if (!ValidarPagoPorHora())
            {
              
                mensaje += "* pago por hora incorrecta\n";
                cumple = false;
            }
            if (!ViladarHorasPorSemana())
            {
                
                mensaje += "* horas por semana incorrecta";
                cumple = false;
            }

            return cumple;

        }

    }
}
