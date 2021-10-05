using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capa3_Dominio.Entidades;
using System;

namespace NominaSoft_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Regla01_1()
        {
            DateTime fechafin = new DateTime(2021, 10, 4);
        
            bool esperado = true;
            Contrato Vigente = new Contrato();
            Vigente.Fechafin = DateTime.Today;
            Vigente.Cancelado = false;
            bool obtenido = Vigente.EstaVigente();
            Assert.AreEqual(esperado, obtenido);
        }
        [TestMethod]
        public void Test_Regla01_2()
        {
            DateTime fechafin = new DateTime(2021, 10, 4);
            bool cancelado = true;
            bool esperado = false;
            Contrato Vigente = new Contrato();
            bool obtenido = Vigente.EstaVigente();
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void Test_Regla02()
        {
            DateTime fechainicio = new DateTime(2021, 10, 6);
            bool esperado = true;
            Contrato Fecha_2 = new Contrato();
            bool obtenido = Fecha_2.ValidarFechaInicio();
            Assert.AreEqual(esperado, obtenido);


        }

        [TestMethod]
        public void Test_Regla03()
        {
            DateTime fechafin = new DateTime(2022, 2, 6);
            DateTime fechainicio = new DateTime(2021, 10, 4);
            bool esperado = true;
            Contrato Fecha_3 = new Contrato();
            bool obtenido = Fecha_3.ValidarFechaFin();
            Assert.AreEqual(esperado, obtenido);


        }

        [TestMethod]
        public void Test_Regla04()
        {
            int hora1 = 12;
            bool esperado = true;
            Contrato Horas = new Contrato();
            bool obtenido = Horas.ViladarHorasPorSemana();
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
    }
}
