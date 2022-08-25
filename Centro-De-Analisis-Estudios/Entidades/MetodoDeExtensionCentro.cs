using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodoDeExtensionCentro
    {
        /// <summary>
        /// Cuenta cuantas personas con la inicial seleccionada hay en el centro de analisis
        /// </summary>
        /// <param name="centro"> Centro donde se desea buscar</param>
        /// <param name="letra"> Letra con la que se desea buscar </param>
        /// <returns> Retorno la cantidad de personas</returns>
        public static int ContadorInicialesCentro(this CentroDeAnalisis centro,char letra)
        {
            int contadorRetorno = 0;
            object[] personas = centro.ObtenerTodos();

            if(personas.Length != 0)
            {
                foreach (object item in personas)
                {
                    if (((Persona)item).Nombre[0] == letra)
                    {
                        contadorRetorno++;
                    }
                }
            }

            return contadorRetorno;
        }

    }   
}
