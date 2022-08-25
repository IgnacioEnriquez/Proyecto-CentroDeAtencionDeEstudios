using System;
using System.Linq;
using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected ESexo sexo;
        protected EClaseSocial clase;        
        protected bool tieneHijos;
        protected string razon;       
        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {

                if (value.Length < 11 && value.Any(char.IsDigit) == false)
                {
                    this.nombre = value;
                }
                else
                {
                    throw new DatoInvalidoExcepcion("El Nombre no puede superar las 10 letras ni tener numeros");
                }

            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }

            set
            {

                if (value.Length < 21 && value.Any(char.IsDigit) == false)
                {
                    this.apellido = value;
                }
                else
                {
                    throw new DatoInvalidoExcepcion("El Apellido no puede superar las 20 letras ni tener numeros");
                }

            }
        }
        public int Edad
        {
            get
            {
                return this.edad;
            }


            set
            {
                if (value >= 18 && value < 125)
                {

                    this.edad = value;
                }
                else
                {
                    throw new DatoInvalidoExcepcion("La edad no puede ser menor a 18,ni mayor a 125");
                }
            }


        }
        public EClaseSocial Clase
        {
            get
            {
                return this.clase;
            }


            set
            {
                this.clase = value;
            }
        }

        public ESexo Sexo
        {
            get
            {
                return this.sexo;
            }


            set
            {
                this.sexo = value;
            }
        }        

        public string Razon 
        {
            get
            {
                return this.razon;
            }


            set
            {
                if(value.Length <= 256)
                {
                    this.razon = value;
                }
                else
                {
                    throw new DatoInvalidoExcepcion("La razon de abandono no puede superar los 256 caracteres");
                }

            }               
        }

        public bool Hijos 
        {
            get
            {
                return this.tieneHijos;
            }

            set
            {
                this.tieneHijos = value;
            }

        }

        public virtual int MaximoAnioAlcanzado { get; set; }


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
        public Persona(string nombre, string apellido, int edad, ESexo sexo, EClaseSocial clase, bool tieneHijos, string razon)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Clase = clase;
            this.Razon = razon;
            this.tieneHijos = tieneHijos;
        }


        /// <summary>
        /// Muestro los datos en formato string de la Persona
        /// </summary>
        /// <returns> Datos en formato string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append(" | Nombre Completo : ");
            sb.AppendLine(this.Nombre + " " + this.Apellido + " |");
            sb.Append(" | Edad : ");
            sb.AppendLine(this.Edad.ToString() + " |");
            sb.Append(" | Sexo : ");
            sb.AppendLine(this.Sexo.ToString() + " |");
            sb.Append(" | Clase Social :  ");
            sb.AppendLine(this.Clase.ToString() + " |");
            


            if (tieneHijos == true)
            {
                sb.AppendLine(" | Tiene Hijos |");
            }
            else
            {
                sb.AppendLine(" | No Tiene Hijos | ");
            }

            sb.Append(" | Razon por la que dejo de estudiar : ");

            sb.Append(this.Razon);

            sb.AppendLine(" |..| ");

            return sb.ToString();

        }                             


        /// <summary>
        /// Comparo dos personas por su Nombre,Apellido,Sexo y Edad
        /// </summary>
        /// <param name="p1"> Persona 1 que se desea comparar</param>
        /// <param name="p2"> Persona 2 que se desea comparar</param>
        /// <returns> True si son iguales, false caso contrario</returns>
        public static bool operator ==(Persona p1, Persona p2)
        {
            bool retorno = false;

            if(p1.Nombre == p2.Nombre && p1.Apellido == p2.Apellido && p1.Sexo == p2.Sexo && p1.Edad == p2.Edad)
            {
                retorno = true;
            }
           
            return retorno;
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }


    }
}
