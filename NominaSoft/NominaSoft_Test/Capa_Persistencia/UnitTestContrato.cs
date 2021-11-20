using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capa4_Persistencia;
using Capa3_Dominio.Entidades;
using System;

namespace NominaSoft_Test.Capa_Persistencia
{
    [TestClass]
    public class UnitTestContrato
    {
        [TestMethod]
        public void TestGuardar()
        {



            Contrato contrato = new Contrato
            {
                Pagoporhora = 10,
                Contrato_id = "CON_TEST",
                Puesto = "TEST",
                Horasporsemana = 12,
                Tieneasignacionfamiliar = true,
                Cancelado = false,
                Fechainicio = new DateTime(2021, 10, 4),
                Fechafin = new DateTime(2022, 9, 4),

            };

            IncidenciaLaboral incidencia = new IncidenciaLaboral
            {
                Incidencia_id = 2
            };


            Afp afp = new Afp
            {
                Afp_id = 1
            };

            Empleado empleado = new Empleado
            {
                Empleado_id = "EMP47860555"
            };


            contrato.Empleado = empleado;
            contrato.Afp = afp;
            contrato.Incidencias = new System.Collections.Generic.List<IncidenciaLaboral>();
            contrato.Incidencias.Add(incidencia);

            ContratoSqlServer con = new ContratoSqlServer();
            GestorSqlServer  gestorSqlServer = GestorSqlServer.getInstance();

            gestorSqlServer.AbrirConexion();
            con.guardar(contrato);
            gestorSqlServer.CerrarConexion();

            gestorSqlServer.AbrirConexion();
            Contrato contrato1 = con.buscarPorId("CON_TEST");
            gestorSqlServer.CerrarConexion();

            Assert.AreEqual(contrato1.Contrato_id, contrato.Contrato_id);

        }




    }
}
