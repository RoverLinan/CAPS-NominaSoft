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
            DateTime fechafin = new DateTime(2021, 10, 10);
        
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
            DateTime fechainicio = new DateTime(2021, 10, 10);
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
    }
}
