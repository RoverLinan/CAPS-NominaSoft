﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    public class BoletaDePago
    {
        private String boleta_id;
        private double sueldobasico;
        private double asignacionfamiliar;
        private double montoporhoraextras;
        private double reintegros;
        private double movilidad;
        private double otrosingresos;
        private double regimenpensionario;
        private double montoporhorasdefalta;
        private double adelantos;
        private double otrosdescuentos;


        private Contrato contrato;
        private Nomina nomina;
        

        public string Boleta_id { get => boleta_id; set => boleta_id = value; }
        public double Sueldobasico { get => sueldobasico; set => sueldobasico = value; }
        public double Asignacionfamiliar { get => asignacionfamiliar; set => asignacionfamiliar = value; }
        public double Montoporhoraextras { get => montoporhoraextras; set => montoporhoraextras = value; }
        public double Reintegros { get => reintegros; set => reintegros = value; }
        public double Movilidad { get => movilidad; set => movilidad = value; }
        public double Otrosingresos { get => otrosingresos; set => otrosingresos = value; }
        public double Regimenpensionario { get => regimenpensionario; set => regimenpensionario = value; }
        public double Montoporhorasdefalta { get => montoporhorasdefalta; set => montoporhorasdefalta = value; }
        public double Adelantos { get => adelantos; set => adelantos = value; }
        public double Otrosdescuentos { get => otrosdescuentos; set => otrosdescuentos = value; }
        public Contrato Contrato { get => contrato; set => contrato = value; }




        //REGLA-7
        public int CalcularTotalHoras()
        {
            return nomina.Periodo.CalcularTotalSemanas() * contrato.Horasporsemana;

        }

        //REGLA-08
        public double CalcularSueldoBasico()
        {
            return this.sueldobasico = CalcularTotalHoras() * contrato.Pagoporhora;
        }

        //REGLA-09
        public double CalcularMontoAsignacionFamiliar()
        {
            if (contrato.Tieneasignacionfamiliar)
            {
                return CalcularSueldoBasico() * 0.1;
            }
            return 0;
        }


        //REGLA-10
        public void CalcularMontoPorHorasExtras()
        {
            montoporhoraextras = this.contrato.CalcularMontoPorHorasExtras();
         
        }




    }
}
