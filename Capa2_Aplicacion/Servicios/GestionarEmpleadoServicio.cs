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
        private GestorSQLServer gestorSQL;
        private EmpleadoSQLServer empleadoSQL;

        public GestionarEmpleadoServicio()
        {
            gestorSQL = GestorSQLServer.getInstance();
            empleadoSQL = new EmpleadoSQLServer();
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

                throw err;
            }
          
            
        }

        public Empleado buscarEmpleadoPorDni(string dni)
        {
            Empleado empleado;
            try
            {
                gestorSQL.AbrirConexion();
                empleado = empleadoSQL.buscarEmpleadoPorDni(dni);
                gestorSQL.CerrarConexion();
                
                return empleado;
            }
            catch (Exception err)
            {

                throw err;
            }

        }



    }
}
