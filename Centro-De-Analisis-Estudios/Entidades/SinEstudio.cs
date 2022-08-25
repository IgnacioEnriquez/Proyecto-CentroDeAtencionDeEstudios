using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class SinEstudio : Persona
    {
        /// <summary>
        /// Constructor que  inicia todos los argumentos
        /// </summary>
        /// <param name="nombre"> Nombre de la persona </param>
        /// <param name="apellido"> Apellido de la persona </param>
        /// <param name="edad"> Edad de la persona </param>
        /// <param name="sexo"> Genero/Sexo de la persona </param>
        /// <param name="clase"> Clase Social de la persona </param>
        /// <param name="tieneHijos"> Si la persona tiene hijos true, si no false</param>        
        /// <param name="razon"> Razon por la que se abandono los estudios </param>
        public SinEstudio(string nombre, string apellido, int edad, ESexo sexo, EClaseSocial clase, bool tieneHijos, string razon)
            : base(nombre, apellido, edad, sexo, clase, tieneHijos, razon)
        {

        }


        /// <summary>
        /// Muestro los datos en formato string de la Persona SinEstudio
        /// </summary>
        /// <returns> Datos en formato string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(" |... Sin Estudio ... |");
            sb.Append(base.ToString());         
            
            return sb.ToString();
        }


        /// <summary>
        /// Sobrecarga del Equals que se encarga de chequear si son iguales
        /// </summary>
        /// <param name="obj"> Objeto que se desea comparar</param>
        /// <returns> retorna true si son iguales,false si no /returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is SinEstudio)
            {
                retorno = this == (SinEstudio)obj;
            }

            return retorno;            
        }


        /// <summary>
        /// Comparo dos "Secundario" por su Nombre,Apellido,Sexo,Edad y maximo año alcanzado
        /// </summary>
        /// <param name="p1"> Persona 1 que se desea comparar</param>
        /// <param name="p2"> Persona 2 que se desea comparar</param>
        /// <returns> True si son iguales, false caso contrario</returns>
        public static bool operator ==(SinEstudio p1, SinEstudio p2)
        {
            bool retorno = false;

            if ((Persona)p1 == (Persona)p2)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(SinEstudio p1, SinEstudio p2)
        {
            return !(p1 == p2);
        }
    }
}
