using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Capa3_Dominio.Entidades;
using System.Collections.Generic;

namespace NominaSoft_Test.Capa_Dominio
{
    [TestClass]
    public class UnitTestContrato
    {
        [TestMethod]
        public void Test_Regla01_1()
        {
            DateTime fechafin = new DateTime(2022, 10, 1);

            bool esperado = true;
            Contrato contrato = new Contrato();
            contrato.Fechafin = fechafin;
            contrato.Cancelado = false;
            bool obtenido = contrato.EstaVigente();
            Assert.AreEqual(esperado, obtenido);
        }


        [TestMethod]
        public void Test_Regla01_2()
        {
            DateTime fechafin = new DateTime(2021, 10, 4);
            bool esperado = false;
            Contrato contrato = new Contrato();
            contrato.Cancelado = true;
            contrato.Fechafin = fechafin;
            bool obtenido = contrato.EstaVigente();
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void Test_Regla02()
        {
            DateTime fechainicio = new DateTime(2022, 5, 10);
            bool esperado = true;
            Contrato contrato = new Contrato();
            contrato.Fechainicio = fechainicio;
            bool obtenido = contrato.ValidarFechaInicio();
            Assert.AreEqual(esperado, obtenido);


        }

        [TestMethod]
        public void Test_Regla03()
        {
            DateTime fechafin = new DateTime(2022, 2, 6);
            DateTime fechainicio = new DateTime(2021, 10, 4);
            bool esperado = true;
            Contrato contrato = new Contrato();
            contrato.Fechainicio = fechainicio;
            contrato.Fechafin = fechafin;
            bool obtenido = contrato.ValidarFechaFin();
            Assert.AreEqual(esperado, obtenido);


        }

        [TestMethod]
        public void Test_Regla04()
        {
            Contrato contrato = new Contrato();
            contrato.Horasporsemana = 12;
            bool esperado = true;
            bool obtenido = contrato.ViladarHorasPorSemana();
            Assert.AreEqual(esperado, obtenido);
        }



        [TestMethod]
        public void Test_Regla05()
        {
            Contrato contrato = new Contrato();
            bool esperado = true;
            contrato.Pagoporhora = 11;
            bool obtenido = contrato.ValidarPagoPorHora();
            Assert.AreEqual(esperado, obtenido);


        }


        [TestMethod]
        public void Test_Regla10()
        {

            PeriodoDeNomina periodoDeNomina = new PeriodoDeNomina();
            periodoDeNomina.Periodo_id = "PNOM123";
            periodoDeNomina.Fechainicio = new DateTime(2021, 10, 4);
            periodoDeNomina.Fechafin = new DateTime(2021, 11, 4);


            Contrato contrato = new Contrato
            {
                Pagoporhora = 10,
                Incidencias = new List<IncidenciaLaboral>()
            };

            Nomina nomina = new Nomina
            {
                Periodo = periodoDeNomina,

            };

     

            IncidenciaLaboral incidenciaLaboral = new IncidenciaLaboral();
            incidenciaLaboral.Periodo = periodoDeNomina;
            incidenciaLaboral.Totalhorasextras = 10;

            contrato.Incidencias.Add(incidenciaLaboral);

            BoletaDePago boletadePago = new BoletaDePago();
            boletadePago.Contrato = contrato;
            boletadePago.Nomina = nomina;
        
            boletadePago.CalcularMontoPorHorasExtras();


            double esperado = 100;
            double obtenido = boletadePago.Montoporhoraextras;
            Assert.AreEqual(esperado, obtenido);
        }
    }
}
