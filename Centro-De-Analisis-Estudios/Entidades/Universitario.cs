using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public sealed class Universitario : Persona
    {
        private int maximoAnioAlcanzado;       
        public override int MaximoAnioAlcanzado
        {
            get
            {
                return this.maximoAnioAlcanzado;                
            }

            set
            {
                if(value > 0 && value <= 10)
                {
                    this.maximoAnioAlcanzado = value;
                }
                else
                {
                    throw new DatoInvalidoExcepcion("El maximo año alcanzado no puede ser menor que 1 ni mayor a 10");
                }

            }                

        }


        /// <summary>
        /// Constructor que  inicia todos los argumentos
        /// </summary>
        /// <param name="nombre"> Nombre de la persona </param>
        /// <param name="apellido"> Apellido de la persona </param>
        /// <param name="edad"> Edad de la persona </param>
        /// <param name="sexo"> Genero/Sexo de la persona </param>
        /// <param name="clase"> Clase Social de la persona </param>
        /// <param name="tieneHijos"> Si la persona tiene hijos true, si no false</param>
        /// <param name="maximoAño">Maximo año alcanzado en la universidad</param>
        /// <param name="razon"> Razon por la que se abandono los estudios </param>
        public Universitario(string nombre, string apellido, int edad, ESexo sexo, EClaseSocial clase, bool tieneHijos, int maximoAño, string razon)
            : base(nombre, apellido, edad, sexo, clase, tieneHijos, razon)
        {
            this.MaximoAnioAlcanzado = maximoAño;
        }


        /// <summary>
        /// Muestro los datos en formato string de la Persona Universitario
        /// </summary>
        /// <returns> Datos en formato string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(" |... Universitario ... |");
            sb.Append(base.ToString());
            sb.Append(" | El Maximo Año Universitario que alcanzo fue: ");
            sb.Append(this.MaximoAnioAlcanzado.ToString());
            sb.AppendLine(" | ");
            sb.AppendLine();

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

            if (obj is Universitario)
            {
                retorno = this == (Universitario)obj;
            }

            return retorno;
        }         
      

        /// <summary>
        /// Comparo dos Universitarios por su Nombre,Apellido,Sexo,Edad y maximo año alcanzado
        /// </summary>
        /// <param name="p1"> Persona 1 que se desea comparar</param>
        /// <param name="p2"> Persona 2 que se desea comparar</param>
        /// <returns> True si son iguales, false caso contrario</returns>
        public static bool operator ==(Universitario p1, Universitario p2)
        {
            bool retorno = false;

            if ((Persona)p1 == (Persona)p2 && p1.MaximoAnioAlcanzado == p2.MaximoAnioAlcanzado)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Universitario p1, Universitario p2)
        {
            return !(p1 == p2);
        }

    }
}
