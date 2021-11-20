using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa3_Dominio.Entidades;
using Capa4_Persistencia;

namespace Capa2_Aplicacion.Servicios
{
    
    public class GestionarEmpleadoServicio
    {
        private readonly GestorSqlServer gestorSQL;
        private readonly EmpleadoSqlServer empleadoSQL;

        public GestionarEmpleadoServicio()
        {
            gestorSQL = GestorSqlServer.getInstance();
            empleadoSQL = new EmpleadoSqlServer();
        }

        public bool guardarEmpleado(Empleado empleado)
        {
            try
            {
                gestorSQL.AbrirConexion();
                empleadoSQL.guardar(empleado);
                gestorSQL.CerrarConexion();
                return true;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
                throw;
            }
          
            
        }

        public Empleado buscarEmpleadoPorDni(string dni)
        {
          
            try
            {
                gestorSQL.AbrirConexion();
                Empleado empleado = empleadoSQL.buscarEmpleadoPorDni(dni);
                gestorSQL.CerrarConexion();
                
                return empleado;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
                throw;
            }

        }

        public Empleado buscarEmpleadoPorId(string id)
        {
           
            try
            {
               
                gestorSQL.AbrirConexion();
                Empleado empleado = empleadoSQL.buscarEmpleadoPorId(id);
                gestorSQL.CerrarConexion();

                return empleado;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                throw;
            }

        }



    }
}
