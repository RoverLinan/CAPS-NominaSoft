using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Capa2_Aplicacion.Servicios
{
    public  static class GenerarNumeroAleatorio
    {


        public static String ObtenerNumeroAleatorio()
        {


            var randomGenerator = RandomNumberGenerator.Create(); // Compliant for security-sensitive use cases
            byte[] data = new byte[2];
            randomGenerator.GetBytes(data);
            return BitConverter.ToString(data);

        }

    }
}
