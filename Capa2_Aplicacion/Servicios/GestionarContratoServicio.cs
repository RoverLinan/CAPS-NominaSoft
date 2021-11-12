using Capa3_Dominio.Entidades;
using Capa4_Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa2_Aplicacion.Servicios
{
    public class GestionarContratoServicio
    {
        private ContratoSQLServer contratoSQLServer;
        private GestionarAfpServicio afpServicio;
        private GestionarEmpleadoServicio empleadoServicio;
        private GestionarIncidenciaLaboralServicio incidenciaLaboralServicio;
        private GestorSQLServer gestorSQL;


        public GestionarContratoServicio()
        {
            contratoSQLServer = new ContratoSQLServer();
            afpServicio = new GestionarAfpServicio();
            empleadoServicio =  new GestionarEmpleadoServicio();    
            incidenciaLaboralServicio = new GestionarIncidenciaLaboralServicio();
           
            gestorSQL = GestorSQLServer.getInstance();
        }


        public Contrato buscarPorId(string id)
        {
            try
            {
                gestorSQL.AbrirConexion();
                Contrato contrato = contratoSQLServer.buscarPorId(id);
                gestorSQL.CerrarConexion();
                return contrato;
            }
            catch (Exception err)
            {

                throw err;
            }
          
        }





        public bool guardarContrato(Contrato contrato, Empleado empleado, Afp afp)
        {


            


            try
            {


                if (!contrato.ValidarFechaInicio())
                {
                    throw new Exception("fecha inicio incorrecta");
                }

                if (!contrato.ValidarFechaFin())
                {
                    throw new Exception("fecha fin incorrecta");
                }

                if (!contrato.ValidarPagoPorHora())
                {
                    throw new Exception("pago por hora incorrecta");
                }
                if (!contrato.ViladarHorasPorSemana())
                {
                    throw new Exception("horas por semana incorrecta");
                }



                gestorSQL.AbrirConexion();
                bool guardado = contratoSQLServer.guardar(contrato, empleado, afp);
                gestorSQL.CerrarConexion();
                return guardado;
            }
            catch (Exception err)
            {

                throw err;
            }
           
        }

        public Contrato buscarContratoVigentePorIdEmpleado(string id)
        {
            Contrato contrato;
            try
            {
                gestorSQL.AbrirConexion();
                contrato = contratoSQLServer.buscarContratoVigentePorIdEmpleado(id);
                gestorSQL.CerrarConexion();
                return contrato;
            }
            catch (Exception err)
            {

                throw err;
            }

        }

        public List<Contrato> buscarContratosPorIdEmpleado(string id)
        {
            List<Contrato> contratos;
            try
            {
                gestorSQL.AbrirConexion();
                contratos = contratoSQLServer.buscarContratosPorIdEmpleado(id);
                gestorSQL.CerrarConexion();
                return contratos;
            }
            catch (Exception err)
            {

                throw err;
            }

        }


        public List<Contrato> obtenerContratos()
        {
         
            try
            {
                List<Contrato> contratos;
                gestorSQL.AbrirConexion();
                contratos = contratoSQLServer.obtenerContratos();
                gestorSQL.CerrarConexion();
                foreach (Contrato item in contratos)
                {
                    item.Afp = afpServicio.buscarAfpPorId(item.Afp.Afp_id);
                    item.Empleado = empleadoServicio.buscarEmpleadoPorId(item.Empleado.Empleado_id);
                    item.Incidencias = incidenciaLaboralServicio.obtenerListaPorIdContrato(item.Contrato_id);
                }
              
                return contratos;
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        public bool actualizarContrato(Contrato contrato)
        {


            try
            {


                if (!contrato.ValidarFechaInicio())
                {
                    throw new Exception("fecha inicio incorrecta");
                }

                if (!contrato.ValidarFechaFin())
                {
                    throw new Exception("fecha fin incorrecta");
                }

                if (!contrato.ValidarPagoPorHora())
                {
                    throw new Exception("pago por hora incorrecta");
                }
                if (!contrato.ViladarHorasPorSemana())
                {
                    throw new Exception("horas por semana incorrecta");
                }



                gestorSQL.AbrirConexion();
                bool guardado = contratoSQLServer.actualizar(contrato);
                gestorSQL.CerrarConexion();
                return guardado;
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        public bool cancelarContrato(string id)
        {
           
            try
            {
                gestorSQL.AbrirConexion();
                bool cancelado = contratoSQLServer.cancelar(id);
                gestorSQL.CerrarConexion();
                return cancelado;
            }
            catch (Exception err)
            {

                throw err;
            }
        }

    }
}
