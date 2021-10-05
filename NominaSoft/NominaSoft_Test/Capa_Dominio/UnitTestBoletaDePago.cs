using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capa3_Dominio.Entidades;

namespace NominaSoft_Test.Capa_Dominio
{
    /// <summary>
    /// Descripción resumida de UnitTestBoletaDePago
    /// </summary>
    [TestClass]
    public class UnitTestBoletaDePago
    {


        [TestMethod]
        public void Test_Regla8()
        {
            PeriodoDeNomina periodoDeNomina = new PeriodoDeNomina();
            DateTime testFecha1 = new DateTime(2021, 09, 15, 11, 15, 16);
            DateTime testFecha2 = new DateTime(2021, 10, 5, 11, 15, 16);
            periodoDeNomina.Fechainicio = testFecha1;
            periodoDeNomina.Fechafin = testFecha2;
            Nomina nomina = new Nomina();
            nomina.Periodo = periodoDeNomina;
            Contrato contrato = new Contrato();
            contrato.Horasporsemana = 10;
            contrato.Pagoporhora = 10;
            BoletaDePago boletadePago = new BoletaDePago();
            boletadePago.Contrato = contrato;
            boletadePago.Nomina = nomina;
            double esperado = 200;
            double obtenido = boletadePago.CalcularSueldoBasico();
            Assert.AreEqual(esperado, obtenido);
        }



        [TestMethod]
        public void Test_Regla09()
        {
            PeriodoDeNomina periodoDeNomina = new PeriodoDeNomina();
            DateTime testFecha1 = new DateTime(2021, 09, 15, 11, 15, 16);
            DateTime testFecha2 = new DateTime(2021, 10, 5, 11, 15, 16);
            periodoDeNomina.Fechainicio = testFecha1;
            periodoDeNomina.Fechafin = testFecha2;
            Nomina nomina = new Nomina();
            nomina.Periodo = periodoDeNomina;
            Contrato contrato = new Contrato();
            contrato.Horasporsemana = 10;
            contrato.Pagoporhora = 10;
            contrato.Tieneasignacionfamiliar = true;
            BoletaDePago boletadePago = new BoletaDePago();
            boletadePago.Contrato = contrato;
            boletadePago.Nomina = nomina;
            double esperado = 20;
            double resultado = boletadePago.CalcularMontoAsignacionFamiliar();
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Test_Regla11()
        {
            Contrato contrato = new Contrato();
            contrato.Tieneasignacionfamiliar = false;
            contrato.Incidencias = new List<IncidenciaLaboral>();
            BoletaDePago boletadePago = new BoletaDePago();
            boletadePago.Sueldobasico = 100;
            boletadePago.Reintegros = 100;
            boletadePago.Movilidad = 100;
            boletadePago.Otrosingresos = 100;
            boletadePago.Contrato = contrato;
            double esperado = 400;
            double obtenido = boletadePago.CalcularTotalIngresos();
            Assert.AreEqual(esperado, obtenido);
        }


        [TestMethod]
        public void Test_Regla12()
        {
            Contrato contrato = new Contrato();
            Afp afp = new Afp();
            afp.Porcentajedescuento = 0.1;
            afp.Nombre = "Habitad";
            BoletaDePago boletadePago = new BoletaDePago();
            boletadePago.Sueldobasico = 930;
            boletadePago.Contrato = contrato;
            contrato.Afp = afp;
            double esperado = 93;
            double obtenido = boletadePago.CalcularRegimenPensionario();
            Assert.AreEqual(esperado, obtenido);
        }


        [TestMethod]
        public void Test_Regla13()
        {
            Contrato contrato = new Contrato();
            contrato.Pagoporhora = 10;
            contrato.Incidencias = new List<IncidenciaLaboral>();
            IncidenciaLaboral incidenciaLaboral = new IncidenciaLaboral();
            incidenciaLaboral.Totalhorasdefalta = 10;
            contrato.Incidencias.Add(incidenciaLaboral);
            BoletaDePago boletadePago = new BoletaDePago();
            boletadePago.Contrato = contrato;
            double esperado = 100;
            double obtenido = boletadePago.CalcularMontoHorasFalta();
            Assert.AreEqual(esperado, obtenido);
        }


        [TestMethod]
        public void Test_Regla14()
        {
            Contrato contrato = new Contrato();
            contrato.Tieneasignacionfamiliar = false;
            contrato.Incidencias = new List<IncidenciaLaboral>();
            BoletaDePago boletadePago = new BoletaDePago();
            boletadePago.Regimenpensionario = 100;
            boletadePago.Adelantos = 100;
            boletadePago.Otrosdescuentos = 100;
            boletadePago.Contrato = contrato;
            double esperado = 300;
            double obtenido = boletadePago.CalcularTotalRetenciones();
            Assert.AreEqual(esperado, obtenido);
        }


        [TestMethod]
        public void Test_Regla15()
        {
            Contrato contrato = new Contrato();
            contrato.Tieneasignacionfamiliar = false;
            contrato.Incidencias = new List<IncidenciaLaboral>();
            BoletaDePago boletadePago = new BoletaDePago();
            boletadePago.Sueldobasico = 100;
            boletadePago.Reintegros = 100;
            boletadePago.Movilidad = 100;
            boletadePago.Otrosingresos = 100;
            boletadePago.Regimenpensionario = 100;
            boletadePago.Adelantos = 100;
            boletadePago.Otrosdescuentos = 100;
            boletadePago.Contrato = contrato;
            double esperado = 100;
            double obtenido = boletadePago.CalcularNetoAPagar();
            Assert.AreEqual(esperado, obtenido);
        }

        


    }
}
