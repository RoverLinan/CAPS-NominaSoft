using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    public class BoletaDePago
    {
        public String Boleta_id { get; set; }
        public double Sueldobasico { get; set; }
        public double Asignacionfamiliar { get; set; }
        public double Montoporhoraextras { get; set; }
        public double Reintegros { get; set; }
        public double Movilidad { get; set; }
        public double Otrosingresos { get; set; }
        public double Regimenpensionario { get; set; }
        public double Montoporhorasdefalta { get; set; }
        public double Adelantos { get; set; }
        public double Otrosdescuentos { get; set; }


        public Contrato Contrato { get; set; }
        public Nomina Nomina { get; set; }
        

      




        //REGLA-7
        public int CalcularTotalHoras()
        {
            return Nomina.Periodo.CalcularTotalSemanas() * Contrato.Horasporsemana;

        }

        //REGLA-08
        public void CalcularSueldoBasico()
        {
             this.Sueldobasico = CalcularTotalHoras() * Contrato.Pagoporhora;
        }

        //REGLA-09
        public void CalcularMontoAsignacionFamiliar()
        {
            if (Contrato.Tieneasignacionfamiliar)
            {
                this.Asignacionfamiliar = this.Sueldobasico * 0.1;
            }
            else {
                this.Asignacionfamiliar = 0;
            }

          
        }


        //REGLA-10
        public void CalcularMontoPorHorasExtras()
        {

             Montoporhoraextras = Contrato.CalcularMontoPorHorasExtras(Nomina.Periodo.Periodo_id);
        }


          //REGLA-11
        public double CalcularTotalIngresos()
        {

            return Sueldobasico + Asignacionfamiliar + Montoporhoraextras+ Reintegros + Movilidad + Otrosingresos;
        }

        //REGLA-12
        public void CalcularRegimenPensionario()
        {

            Regimenpensionario = Sueldobasico * (Contrato.Afp.Porcentajedescuento/100);
        }

        //REGLA-13
        public void CalcularMontoHorasFalta()
        {

            Montoporhorasdefalta =  Contrato.CalcularMontoHorasFalta(Nomina.Periodo.Periodo_id);
        }

        //REGLA-14
        public double CalcularTotalRetenciones()
        {

            return Regimenpensionario + Montoporhorasdefalta + Adelantos + Otrosdescuentos;
        }
		
		//REGLA-15
        public double CalcularNetoAPagar()
        {
            return CalcularTotalIngresos() - CalcularTotalRetenciones();
        }

    }
}
