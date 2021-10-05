using Capa3_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa2_Aplicacion.Servicios
{
    public class ProcesarNominaServicio
    {


        public ProcesarNominaServicio()
        {

        }


        public bool GenerarNomina(List<Contrato> listaContratos, PeriodoDeNomina periodo, Nomina nomina )
        {
            foreach (Contrato item in listaContratos)
            {
                if (item.Fechafin.CompareTo(periodo.Fechainicio) == 1 && item.Cancelado == false)
                {
                    return false;
                }
            }


            return true;

        }








    }
}
