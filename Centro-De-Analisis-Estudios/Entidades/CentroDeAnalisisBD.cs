using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Entidades
{
    public class CentroDeAnalisisBD
    {
       
        string nombreDelCentroBD;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader lector;
        private  string connectionString;

        /// <summary>
        /// Constructor privado que inicializa los datos del servidor y su conexion
        /// </summary>
        private CentroDeAnalisisBD()
        {            
            this.command = new SqlCommand();
            this.connectionString = @"Server=localhost\SQLEXPRESS; Database=PersonasCentroDeAnalisis; Integrated Security=True";
            this.connection = new SqlConnection(connectionString);
            
        }

        //Constructor con 1 parametro que asigna el nombre
        public CentroDeAnalisisBD(string nombreDelCentro) : this()
        {
            this.nombreDelCentroBD = nombreDelCentro;
        }

        /// <summary>
        /// Pruebo si la conexion es correcta,caso contrario la cierro.
        /// </summary>
        /// <returns> Retorna true si la conexion funciona,caso contrario false </returns>
        public bool ProbarConexion()
        {
            bool rta = true;

            try
            {
                this.connection.Open();
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return rta;
        }

        /// <summary>
        /// Lee todas las personas de la base de datos y la retorna en una lista de personas
        /// </summary>
        /// <returns> Retorna una lista con todas las personas de la base de datos</returns>
        public List<Persona> ReadAllPersonas()
        {
            object[] persona = new object[9];
            List<Persona> auxPersonas = new List<Persona>();            

            //Si la conexion funciona sigo
            if(this.ProbarConexion() == true)
            {
                //Seleciono todas las personas de la BD
                this.command.CommandText = "SELECT * FROM PersonasCentro";
                this.command.Connection = this.connection;

                //Abro la conexion
                this.connection.Open();

                //Ejecuto el lector 
                this.lector = command.ExecuteReader();

                
                while (lector.Read())
                {
                    Persona p1 = null;

                    persona[0] = (string)lector["TipoDePersona"];
                    persona[1] = (string)lector["Nombre"];
                    persona[2] = (string)lector["Apellido"];
                    persona[3] = (int)lector["Edad"];
                    persona[4] = (int)lector["Sexo"];
                    persona[5] = (int)lector["ClaseSocial"];
                    persona[6] = (bool)lector["TieneHijos"];
                    persona[7] = (string)lector["Razon"];                                        
                    persona[8] = (int)lector["AnioMaximo"];

                    try
                    {
                        //Dependiendo que tipo de persona es,creo la clase
                        switch ((string)persona[0])
                        {
                            case "SinEstudio":
                                p1 = new SinEstudio((string)persona[1], (string)persona[2], (int)persona[3], (ESexo)persona[4], (EClaseSocial)persona[5], (bool)persona[6], (string)persona[7]);
                                break;

                            case "Primaria":
                                p1 = new Primaria((string)persona[1], (string)persona[2], (int)persona[3], (ESexo)persona[4], (EClaseSocial)persona[5], (bool)persona[6], (int)persona[8], (string)persona[7]);
                                break;

                            case "Secundario":
                                p1 = new Secundario((string)persona[1], (string)persona[2], (int)persona[3], (ESexo)persona[4], (EClaseSocial)persona[5], (bool)persona[6], (int)persona[8], (string)persona[7]);
                                break;

                            case "Universitario":
                                p1 = new Universitario((string)persona[1], (string)persona[2], (int)persona[3], (ESexo)persona[4], (EClaseSocial)persona[5], (bool)persona[6], (int)persona[8], (string)persona[7]);
                                break;

                            default:
                                break;
                        }
                    }
                    catch (DatoInvalidoExcepcion)
                    {
                        this.connection.Close();
                        throw;
                    }

                    auxPersonas.Add(p1);
                }            

            }
            else
            {
                throw new DatoInvalidoExcepcion("No se pudo realizar correctamente la conexion");
            }

            this.connection.Close();
            return auxPersonas;

        }

        /// <summary>
        /// Crea una persona en la base de datos,a partir de la persona pasada
        /// </summary>
        /// <param name="p1"> Persona que se queire guardar en la Base de Datos</param>
        public void CreatePersona(Persona p1)
        {
            //Si la conexion funciona sigo
            if(this.ProbarConexion() == true)
            {
                try
                {
                    //Guardo todas las personas en una lista para chequear que esa persona no existe
                    List<Persona> existentes = this.ReadAllPersonas();

                    //Si esa persona no existe(Verifico con el metodo Contains que llama a Equals de cada Persona en la lista) continuo
                    if(!(existentes.Contains(p1)))
                    {
                        //Limpio los parametros
                        this.command.Parameters.Clear();

                        
                        this.command.CommandText = "INSERT INTO PersonasCentro (TipoDePersona,Nombre,Apellido,Edad,Sexo,ClaseSocial,TieneHijos,Razon,AnioMaximo) " +
                      "VALUES (@tipoDePersona, @nombre, @apellido, @edad, @sexo, @claseSocial, @tieneHijos, @razon, @anioMaximo)";                       

                        if (p1 is Universitario)
                        {
                            this.command.Parameters.AddWithValue("tipoDePersona", "Universitario");
                        }
                        else if (p1 is SinEstudio)
                        {
                            this.command.Parameters.AddWithValue("tipoDePersona", "SinEstudio");
                        }
                        else if (p1 is Secundario)
                        {
                            this.command.Parameters.AddWithValue("tipoDePersona", "Secundario");
                        }
                        else if (p1 is Primaria)
                        {
                            this.command.Parameters.AddWithValue("tipoDePersona", "Primaria");
                        }

                        this.command.Parameters.AddWithValue("@nombre", p1.Nombre);
                        this.command.Parameters.AddWithValue("@apellido", p1.Apellido);
                        this.command.Parameters.AddWithValue("@edad", p1.Edad);
                        this.command.Parameters.AddWithValue("@sexo", p1.Sexo);
                        this.command.Parameters.AddWithValue("@claseSocial", p1.Clase);
                        this.command.Parameters.AddWithValue("@tieneHijos", p1.Hijos);
                        this.command.Parameters.AddWithValue("@razon", p1.Razon);
                        this.command.Parameters.AddWithValue("@anioMaximo", p1.MaximoAnioAlcanzado);

                        this.connection.Open();

                        this.command.ExecuteNonQuery();

                        this.connection.Close();
                    }
                    else
                    {
                        throw new PersonaExistenteException("La persona ya existe en esta Base De Datos");
                    }
                    
                    

                }
                catch (Exception)
                {
                    throw;
                }               

            }
            
        }

        /// <summary>
        /// Elimino la persona de la base de datos
        /// </summary>
        /// <param name="p1"> Persona que se quiere eliminar de la base de datos</param>
        public void DeletePersona(Persona p1)
        {

            //Pruebo la conexion si funciona correctamente
            if(this.ProbarConexion() == true)
            {
                try
                {
                    //Guardo todas las personas en una lista para chequear que esa persona existe
                    List<Persona> existentes = this.ReadAllPersonas();

                    //Si esa persona existe(Verifico con el metodo Contains que llama a Equals de cada Persona en la lista) continuo
                    if (existentes.Contains(p1))
                    {
                        this.command.Parameters.Clear();

                        if (p1 is Universitario)
                        {
                            this.command.Parameters.AddWithValue("tipoDePersona", "Universitario");
                        }
                        else if (p1 is SinEstudio)
                        {
                            this.command.Parameters.AddWithValue("tipoDePersona", "SinEstudio");
                        }
                        else if (p1 is Secundario)
                        {
                            this.command.Parameters.AddWithValue("tipoDePersona", "Secundario");
                        }
                        else if (p1 is Primaria)
                        {
                            this.command.Parameters.AddWithValue("tipoDePersona", "Primaria");
                        }

                        this.command.Parameters.AddWithValue("@nombre", p1.Nombre);
                        this.command.Parameters.AddWithValue("@apellido", p1.Apellido);
                        this.command.Parameters.AddWithValue("@edad", p1.Edad);
                        this.command.Parameters.AddWithValue("@sexo", p1.Sexo);
                        this.command.Parameters.AddWithValue("@claseSocial", p1.Clase);
                        this.command.Parameters.AddWithValue("@tieneHijos", p1.Hijos);
                        this.command.Parameters.AddWithValue("@razon", p1.Razon);
                        this.command.Parameters.AddWithValue("@anioMaximo", p1.MaximoAnioAlcanzado);

                        this.command.CommandText = "DELETE FROM PersonasCentro" +
                        " WHERE TipoDePersona = @tipoDePersona AND Nombre = @nombre AND Apellido = @apellido AND Edad =  @edad AND Sexo = @sexo AND ClaseSocial =  @claseSocial AND TieneHijos =  @tieneHijos AND Razon =  @razon AND AnioMaximo = @anioMaximo";

                        this.connection.Open();

                        this.command.ExecuteNonQuery();

                        this.connection.Close();

                    }
                    else
                    {
                        throw new PersonaInexistenteException("La persona no existe en la base de datos.");
                    }

                    

                }
                catch (Exception)
                {

                    throw;
                }

            }

        }

    }
}
