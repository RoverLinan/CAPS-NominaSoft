using Capa3_Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace NominaSoft_Test.Capa_Dominio
{
    /// <summary>
    /// Descripción resumida de UnitTestNomina
    /// </summary>
    [TestClass]
    public class UnitTestNomina
    {

        [TestMethod]
        public void Test_Regla6()
        {
            PeriodoDeNomina periodoDeNomina = new PeriodoDeNomina();
            DateTime testFecha1 = new DateTime(2021, 09, 15, 11, 15, 16);
            DateTime testFecha2 = new DateTime(2021, 10, 4, 11, 15, 16);
            periodoDeNomina.Fechainicio = testFecha1;
            periodoDeNomina.Fechafin = testFecha2;
            Nomina nomina = new Nomina();
            nomina.Periodo = periodoDeNomina;
            nomina.Fecha = new DateTime(2021, 10, 5, 11, 15, 16);
            Contrato contrato = new Contrato();
            contrato.Horasporsemana = 10;
            contrato.Cancelado = false;
            contrato.Fechainicio = testFecha1;
            contrato.Fechafin = testFecha2;
            BoletaDePago boletadePago = new BoletaDePago();
            boletadePago.Contrato = contrato;
            boletadePago.Nomina = nomina;
            nomina.BoletaDePagos = new List<BoletaDePago>();
            nomina.BoletaDePagos.Add(boletadePago);
            bool esperado = true;
            bool obtenido = nomina.EsFactibleGenerarNomina();
            Assert.AreEqual(esperado, obtenido);
        }



        [TestMethod]
        public void Test_Regla16()
        {
            PeriodoDeNomina periodoDeNomina = new PeriodoDeNomina();
            DateTime testFecha1 = new DateTime(2021, 09, 15, 11, 15, 16);
            DateTime testFecha2 = new DateTime(2021, 10, 5, 11, 15, 16);
            periodoDeNomina.Fechainicio = testFecha1;
            periodoDeNomina.Fechafin = testFecha2;
            Nomina nomina = new Nomina();
            nomina.Periodo = periodoDeNomina;
            bool esperado = true;
            bool obtenido = nomina.ValidarRestaFechaFinPeriodo();
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void Test_Regla17()
        {
            BoletaDePago boletaDePago = new BoletaDePago();
            BoletaDePago boletaDePago2 = new BoletaDePago();

            List<BoletaDePago> boletaDePagos = new List<BoletaDePago>();
            boletaDePagos.Add(boletaDePago);
            boletaDePagos.Add(boletaDePago2);

            Nomina nomina = new Nomina();
            nomina.BoletaDePagos = boletaDePagos;

            bool esperado = true;
            bool obtenido = nomina.TienePagosEmpleados();
            Assert.AreEqual(esperado, obtenido);
        }




    }


}