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


        //REGLA-01
        public bool EstaVigente()
        {
            bool estado = false;

            if (cancelado)
            {
                
            }
            else
            {
                DateTime fechaActual = DateTime.Now;
                if (fechafin.CompareTo(fechaActual) == 0 || fechafin.CompareTo(fechaActual)==1)
                {
                    estado = true;
                }
            }

            return estado;
        }


        //REGLA-02
        public bool ValidarFechaInicio()
        {
            bool estado = false;
            DateTime fechaActual = DateTime.Now;
            if (fechainicio.CompareTo(fechaActual) == 0 || fechainicio.CompareTo(fechaActual) == 1)
            {
                estado = true;
            }
            return estado;
        }

        //regla-03
        public bool ValidarFechaFin()
        {
            bool estado = false;

            if(fechafin.CompareTo(fechainicio) == 1)
            {
                if((fechafin.Year - fechainicio.Year == 0) && fechainicio.Month >= 3)
                {
                    estado = true;
                }
                if(fechafin.Year - fechainicio.Year == 1)
                {
                    int cantidadmeses = (12 - fechainicio.Month) + fechafin.Month;
                    if(cantidadmeses >=3  && cantidadmeses <= 12)
                    {
                        estado = true;
                    }

                }

            }

            return estado;

        }
        

        //REGLA-04

        public bool ViladarHorasPorSemana()
        {
            if(horasporsemana >= 8 && horasporsemana <= 40)
            {
                if(horasporsemana % 4 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        //REGLA-06
        public bool ValidarPagoPorHora()
        {
            if(pagoporhora >= 10.0 && pagoporhora <= 60.0)
            {
                return true;
            }

            return false;
        }





    }
}
