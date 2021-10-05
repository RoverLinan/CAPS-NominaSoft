using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Capa3_Dominio.Entidades;
using System.Collections.Generic;
using System.Text;

namespace NominaSoft_Test.Capa_Dominio
{
    /// <summary>
    /// Descripción resumida de UnitTestPeriodoDeNomina
    /// </summary>
    [TestClass]
    public class UnitTestPeriodoDeNomina
    {

        //Regla-7
        [TestMethod]
        public void Test_Regla7_CalcularTotalSemanas()
        {
            DateTime fechaInicio = new DateTime(2021, 7, 1);
            DateTime fechaFin = new DateTime(2021, 8, 1); ;
            PeriodoDeNomina periodo = new PeriodoDeNomina();
            periodo.Fechainicio = fechaInicio;
            periodo.Fechafin = fechaFin;
            int esperado = 4;
            int obtenido = periodo.CalcularTotalSemanas();
            Assert.AreEqual(esperado,obtenido);
        }



        
    }
}
