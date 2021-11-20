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
        private readonly ContratoSqlServer contratoSQLServer;
        private readonly GestionarAfpServicio afpServicio;
        private readonly GestionarEmpleadoServicio empleadoServicio;
        private readonly GestionarIncidenciaLaboralServicio incidenciaLaboralServicio;
        private readonly GestorSqlServer gestorSQL;


        public GestionarContratoServicio()
        {
            contratoSQLServer = new ContratoSqlServer();
            afpServicio = new GestionarAfpServicio();
            empleadoServicio =  new GestionarEmpleadoServicio();    
            incidenciaLaboralServicio = new GestionarIncidenciaLaboralServicio();
           
            gestorSQL = GestorSqlServer.getInstance();
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

                Console.WriteLine(err.ToString());
                throw;
            }
          
        }





        public void guardarContrato(Contrato contrato)
        {

            try
            {
                
                gestorSQL.AbrirConexion();
                contratoSQLServer.guardar(contrato);
                gestorSQL.CerrarConexion();
              
            }
            catch (Exception err)
            {
                Console.WriteLine (err.ToString());
                throw;
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
                Console.WriteLine (err.ToString());
                throw;
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
                Console.WriteLine(err.ToString());
                throw;
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
                Console.WriteLine(err.ToString());
                throw;
            }
        }

        public bool actualizarContrato(Contrato contrato)
        {


            try
            {
                gestorSQL.AbrirConexion();
                bool guardado = contratoSQLServer.actualizar(contrato);
                gestorSQL.CerrarConexion();
                return guardado;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
                throw;
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

                Console.WriteLine(err.ToString());
                throw;
            }
        }

    }
}
