using System;
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
        public Nomina Nomina { get => nomina; set => nomina = value; }




        //REGLA-7
        public int CalcularTotalHoras()
        {
            return Nomina.Periodo.CalcularTotalSemanas() * contrato.Horasporsemana;

        }

        //REGLA-08
        public void CalcularSueldoBasico()
        {
             this.sueldobasico = CalcularTotalHoras() * contrato.Pagoporhora;
        }

        //REGLA-09
        public void CalcularMontoAsignacionFamiliar()
        {
            if (contrato.Tieneasignacionfamiliar)
            {
                this.asignacionfamiliar = this.sueldobasico * 0.1;
            }

            this.asignacionfamiliar = 0;
        }


        //REGLA-10
        public void CalcularMontoPorHorasExtras()
        {

             this.montoporhoraextras = this.contrato.CalcularMontoPorHorasExtras(nomina.Periodo.Periodo_id);
        }


          //REGLA-11
        public double CalcularTotalIngresos()
        {

            return this.sueldobasico + asignacionfamiliar + montoporhoraextras+ Reintegros + Movilidad + Otrosingresos;
        }

        //REGLA-12
        public void CalcularRegimenPensionario()
        {

            regimenpensionario = this.sueldobasico * (contrato.Afp.Porcentajedescuento/100);
        }

        //REGLA-13
        public void CalcularMontoHorasFalta()
        {

            montoporhorasdefalta =  contrato.CalcularMontoHorasFalta(nomina.Periodo.Periodo_id);
        }

        //REGLA-14
        public double CalcularTotalRetenciones()
        {

            return Regimenpensionario + montoporhorasdefalta + Adelantos + Otrosdescuentos;
        }
		
		//REGLA-15
        public double CalcularNetoAPagar()
        {
            return CalcularTotalIngresos() - CalcularTotalRetenciones();
        }

    }
}
