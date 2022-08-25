using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Entidades
{
    public class CentroDeAnalisis : IArchivos<string>
    {
        private List<Persona> personas;
        private string nombreDelCentro;       
        public string NombreDelCentro 
        {
            get { return this.nombreDelCentro; }
        }      
        
        /// <summary>
        /// Constructor privado sin argumentos que solo inicia la lista de personas
        /// </summary>
        private CentroDeAnalisis()
        {
            this.personas = new List<Persona>();
        }

        /// <summary>
        /// Constructor que inicia el Centro con su nombre
        /// </summary>
        /// <param name="nombre"> Nombre del centro</param>
        public CentroDeAnalisis(string nombre) : this()
        {
            this.nombreDelCentro = nombre;                               
        }

        #region Metodos Estaticos

        /// <summary>
        /// Muestra todas las personas  del Centro de Analisis pedido
        /// </summary>
        /// <param name="c1"> Centro que se desea obtener las personas</param>
        /// <returns> Devuelve las personas mostradas o "" si no hay personas </returns>
        public static string MostrarPersonas(CentroDeAnalisis c1)
        {
            StringBuilder sb = new StringBuilder();


            foreach (Persona item in c1.personas)
            {
                if (item is SinEstudio)
                {
                    sb.AppendLine(((SinEstudio)item).ToString());
                }

                if (item is Primaria)
                {
                    sb.AppendLine(((Primaria)item).ToString());
                }

                if (item is Secundario)
                {
                    sb.AppendLine(((Secundario)item).ToString());
                }

                if (item is Universitario)
                {
                    sb.AppendLine(((Universitario)item).ToString());
                }
            }

            return sb.ToString();
        }


        /// <summary>
        /// Muestra las personas del Centro de Analisis filtrandolo por tipo,sexo y clase social
        /// </summary>
        /// <param name="c1"> Centro de Analisis que se desea mostrar las personas</param>
        /// <param name="filtro"> Segun el numero indicado filtro por tipo, 1 = Secundario, 2 = Primaria, 3 = SinEstudio, mayor que 4 = todos </param>
        /// <param name="sexo"> Ingreso el sexo como enumerado o como int,si en formato int es mayor a 3 mostrara todos </param>
        /// <param name="claseSocial"> Ingreso el enumerado como enumerado o como int,si en formato int es mayor a 2 mostrara todos</param>
        /// <returns> Muestra las personas filtradas como se desea </returns>
        public static string MostrarPersonas(CentroDeAnalisis c1, int filtro, ESexo sexo, EClaseSocial claseSocial)
        {
            StringBuilder sb = new StringBuilder();


            foreach (Persona item in c1.personas)
            {
                
                if (filtro < 4 && (item.Sexo == sexo || (int)sexo > 3) && (item.Clase == claseSocial || (int)claseSocial > 2))
                {

                    switch (filtro)
                    {
                        case 3:

                            if (item is SinEstudio)
                            {
                                sb.AppendLine(((SinEstudio)item).ToString());
                            }
                            break;

                        case 2:

                            if (item is Primaria)
                            {
                                sb.AppendLine(((Primaria)item).ToString());
                            }

                            break;

                        case 1:

                            if (item is Secundario)
                            {
                                sb.AppendLine(((Secundario)item).ToString());
                            }
                            break;

                        case 0:

                            if (item is Universitario)
                            {
                                sb.AppendLine(((Universitario)item).ToString());
                            }
                            break;

                        default:
                            break;
                    }

                }
                else
                {
                    if ((item.Sexo == sexo || (int)sexo > 3) && (item.Clase == claseSocial || (int)claseSocial > 2))
                    {

                        if (item is SinEstudio)
                        {
                            sb.AppendLine(((SinEstudio)item).ToString());
                        }


                        if (item is Primaria)
                        {
                            sb.AppendLine(((Primaria)item).ToString());
                        }

                        if (item is Secundario)
                        {
                            sb.AppendLine(((Secundario)item).ToString());
                        }


                        if (item is Universitario)
                        {
                            sb.AppendLine(((Universitario)item).ToString());
                        }


                    }
                }
            }

            return sb.ToString();
        }


        /// <summary>
        /// Retorna que genero y la cantidad de personas que son mayoria en el centro,si no hay personas,o no hay uno que predomine,lanza DatoInvalidoException
        /// </summary>
        /// <param name="centro"> Centro que se desea analizar </param>
        /// <param name="mayoria"> Retorna el sexo predominante en caso de que haya </param>
        /// <param name="numero"> Retorna el numero de personas predominante en caso de que haya </param>
        public static void ContarMayorias(CentroDeAnalisis centro, out ESexo mayoria, out int numero)
        {
            
            int[] contadorDePersonas = new int[4];
            int retornoNum = -1;
            ESexo retornoEnum = ESexo.Otros;          

            if (centro.personas.Count != 0)
            {
                foreach (Persona item in centro.personas)
                {
                    switch (item.Sexo)
                    {
                        case ESexo.Hombre:
                            contadorDePersonas[0]++;
                            break;

                        case ESexo.Mujer:
                            contadorDePersonas[1]++;
                            break;

                        case ESexo.NoBinarie:
                            contadorDePersonas[2]++;
                            break;

                        case ESexo.Otros:
                            contadorDePersonas[3]++;                            
                            break;

                        default:
                            break;
                    }
                }

                for (int i = 0; i < 4; i++)
                {
                    bool flag = false;

                    if(contadorDePersonas.Max() == contadorDePersonas[i])
                    {                      
                        if(flag == true)
                        {
                            throw new DatoInvalidoExcepcion("No predomina ningun sexo en este analisis");
                        }

                        flag = true;
                        retornoNum = contadorDePersonas[i];
                        retornoEnum = (ESexo)i;
                    }
                }                

            }
            else
            {
                throw new DatoInvalidoExcepcion("Se necesita agregar una persona para realizar el analisis ");
            }

            mayoria = retornoEnum;
            numero = retornoNum;
            
        }


        /// <summary>
        /// Retorna la Clase social predominante y la cantidad de personas que son mayoria en el centro,si no hay personas,o no hay uno que predomine,lanza DatoInvalidoException  
        /// </summary>
        /// <param name="centro"> Centro que se desea analiza </param>
        /// <param name="mayoria"> Retorna la clase social predominante en caso de que haya </param>
        /// <param name="numero"> Retorna el numero de personas predominante en caso de que haya </param>
        public static void ContarMayorias(CentroDeAnalisis centro, out EClaseSocial mayoria, out int numero)
        {
            int[] contadorDePersonas = new int[3];
            int retornoNum = -1;
            EClaseSocial retornoEnum = EClaseSocial.Clase_Baja;
           
            if (centro.personas.Count != 0)
            {
                foreach (Persona item in centro.personas)
                {
                    switch (item.Clase)
                    {
                        case EClaseSocial.Clase_Alta:
                            contadorDePersonas[0]++;
                            break;

                        case EClaseSocial.Clase_Baja:
                            contadorDePersonas[1]++;
                            break;

                        case EClaseSocial.Clase_Media:
                            contadorDePersonas[2]++;
                            break;

                        default:
                            break;
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    bool flag = false;

                    if (contadorDePersonas.Max() == contadorDePersonas[i])
                    {
                        if (flag == true)
                        {
                            throw new DatoInvalidoExcepcion("No predomina ningun sexo en este analisis");
                        }

                        flag = true;
                        retornoNum = contadorDePersonas[i];
                        retornoEnum = (EClaseSocial)i;
                    }
                }

            }
            else
            {
                throw new DatoInvalidoExcepcion("Se necesita agregar una persona para realizar el analisis ");
            }

            mayoria = retornoEnum;
            numero = retornoNum;
          
        }


        /// <summary>
        /// Retorna la tenencia de hijos predominante y la cantidad de personas que son mayoria en el centro,si no hay personas,o no hay uno que predomine,lanza DatoInvalidoException
        /// </summary>
        /// <param name="centro"> Centro que se desea analiza </param>
        /// <param name="hijos"> Retorna true si predominan las personas con hijos,caso contrario retorna false </param>
        /// <param name="numero"> Retorna la clase social predominante en caso de que haya </param>
        public static void ContarMayorias(CentroDeAnalisis centro, out bool hijos, out int numero)
        {
            int retornoNum;
            bool retornoHijos;

            int contadorTieneHijos = 0;
            int contadorNoTieneHijos = 0;


            if (centro.personas.Count != 0)
            {
                foreach (Persona item in centro.personas)
                {
                    if (item.Hijos == true)
                    {
                        contadorTieneHijos++;
                    }
                    else
                    {
                        contadorNoTieneHijos++;
                    }
                }

                if (contadorTieneHijos > contadorNoTieneHijos)
                {
                    retornoHijos = true;
                    retornoNum = contadorTieneHijos;                    
                }
                else if(contadorNoTieneHijos > contadorTieneHijos)
                {
                    retornoHijos = false;
                    retornoNum = contadorNoTieneHijos;                    
                }
                else
                {
                    throw new DatoInvalidoExcepcion("No predomina ningun sexo en este analisis");
                }

            }
            else
            {
                throw new DatoInvalidoExcepcion("Se necesita agregar una persona para realizar el analisis ");
            }

            hijos = retornoHijos;
            numero = retornoNum;         


        }


        /// <summary>
        /// Retorna los rangos de las personas con mas edad,con menos edad,con el mayor año de estudio alcanzado y con el menor,en caso de no haber personas lanza DatoInvalidoException
        /// </summary>
        /// <param name="centro"> Centro que se desea analiza </param>
        /// <param name="edadMenor"> Retorno de la edad menor de una persona </param>
        /// <param name="edadMayor"> Retorno de la edad mayor de una persona </param>
        /// <param name="añoMenor"> Retorno el menor año alcanzado de una persona  </param>
        /// <param name="añoMayor"> Retorno el mayor año alcanzado de una persona</param>
        public static void ObtenerRangos(CentroDeAnalisis centro, out int edadMenor, out int edadMayor, out int añoMenor, out int añoMayor)
        {            
            List<int> edades = new List<int>();
            List<int> añosAlcanzados = new List<int>();


            if (centro.personas.Count != 0)
            {
                foreach (Persona item in centro.personas)
                {
                    edades.Add(item.Edad);

                    if (!(item is SinEstudio))
                    {
                        añosAlcanzados.Add(item.MaximoAnioAlcanzado);
                    }
                }
               
                edadMenor = edades.Min();
                edadMayor = edades.Max();
                añoMayor = añosAlcanzados.Max();
                añoMenor = añosAlcanzados.Min();
            }
            else
            {
                throw new DatoInvalidoExcepcion("Se necesita agregar una persona para realizar el analisis ");
            }

        }


        /// <summary>
        /// Retorna el promedio de edad y de año maximo alcanzado por persona, en caso de no haber personas lanza DatoInvalidoException
        /// </summary>
        /// <param name="centro"> Centro que se desea analiza </param>
        /// <param name="promedioEdad"> Retorno el promedio de edad de una persona </param>
        /// <param name="promedioAño"> Retorno el promedio de mayor año alcanzado de una persona </param>
        public static void ObtenerPromedios(CentroDeAnalisis centro, out float promedioEdad, out float promedioAño)
        {
            
            float acumuladorEdad = 0;
            float acumuladorAño = 0;
            float contadorPersonasConEstudio = 0;

            if (centro.personas.Count != 0)
            {
                foreach (Persona item in centro.personas)
                {
                    acumuladorEdad += item.Edad;

                    if (!(item is SinEstudio))
                    {
                        acumuladorAño += item.MaximoAnioAlcanzado;
                        contadorPersonasConEstudio++;
                    }
                }
                
                promedioEdad = acumuladorEdad / centro.personas.Count;
                promedioAño = acumuladorAño / contadorPersonasConEstudio;
            }
            else
            {
                throw new DatoInvalidoExcepcion("Se necesita agregar una persona para realizar el analisis ");
            }
        }


        /// <summary>
        /// Retorna el porcentaje promedio de personas del mismo sexo, en caso de no haber personas lanza DatoInvalidoException
        /// </summary>
        /// <param name="centro"> Centro que se desea analiza </param>
        /// <param name="sexo"> Sexo que se desea saber el porcentaje </param>
        /// <param name="promedioSexo"> Promedio de personas del mismo sexo </param>
        public static void ObtenerPorcentajePromedio(CentroDeAnalisis centro, ESexo sexo, out float promedioSexo)
        {            
            float contadorMismoSexo = 0;

            if (centro.personas.Count != 0)
            {
                foreach (Persona item in centro.personas)
                {
                    if (item.Sexo == sexo)
                    {
                        contadorMismoSexo++;
                    }
                }
                
                promedioSexo = (contadorMismoSexo * 100) / centro.personas.Count;
            }
            else
            {
                throw new DatoInvalidoExcepcion("Se necesita agregar una persona para realizar el analisis ");
            }

        }


        /// <summary>
        /// Retorna el porcentaje promedio de personas del mismo sexo, en caso de no haber personas lanza DatoInvalidoException
        /// </summary>
        /// <param name="centro"> Centro que se desea analiza </param>
        /// <param name="claseSocial"> Clase Social que se desea saber el porcentaje </param>
        /// <param name="promedioClaseSocial"> Promedio de personas de la misma Clase Social </param>
        public static void ObtenerPorcentajePromedio(CentroDeAnalisis centro, EClaseSocial claseSocial, out float promedioClaseSocial)
        {
           
            float contadorMismaClaseSocial = 0;

            if (centro.personas.Count != 0)
            {
                foreach (Persona item in centro.personas)
                {
                    if (item.Clase == claseSocial)
                    {
                        contadorMismaClaseSocial++;
                    }
                }
                
                promedioClaseSocial = (contadorMismaClaseSocial * 100) / centro.personas.Count;
            }
            else
            {
                throw new DatoInvalidoExcepcion("Se necesita agregar una persona para realizar el analisis ");
            }

            
        }




        #endregion

        #region Metodos NO Estaticos

        /// <summary>
        /// Agrega una persona al centro de Analisis,en caso de ya existir lanza PersonaExistenteException
        /// </summary>
        /// <param name="p"> Persona que se desea agregar </param>
        public void AgregarPersona(Persona p)
        {

            if (this.ChequearExistencia(p) == false)
            {
                this.personas.Add(p);
            }
            else
            {
                throw new PersonaExistenteException("La persona ya existe en este Centro de Analisis");
            }
        }


        /// <summary>
        /// Elimina una persona al centro de Analisis,en caso de no existir lanza PersonaInexistenteException
        /// </summary>
        /// <param name="p"> Persona que se desea agregar </param>
        public void EliminarPersona(Persona p)
        {

            if (this.ChequearExistencia(p) == true)
            {
                this.personas.Remove(p);
            }
            else
            {
                throw new PersonaInexistenteException("La persona no existe en este Centro de Analisis");
            }
        }

        /// <summary>
        /// Elimina todas las personas del Centro de Atencion
        /// </summary>
        public void EliminarTodos()
        {
            if(this.personas.Count != 0)
            {                
                this.personas.Clear();
            }
            else
            {
                throw new PersonaInexistenteException("Se deben agregar personas para poder eliminar ");
            }
        }

        /// <summary>
        /// Retorno en un array de Personas todas las personas del Centro
        /// </summary>
        /// <returns> Retorna un array de "Persona" que contiene todas las personas </returns>
        public Persona[] ObtenerTodos()
        {
            Persona[] retorno = null;

            if (this.personas.Count != 0)
            {
                retorno = new Persona[this.personas.Count];
                this.personas.CopyTo(retorno);                
            }
            else
            {
                throw new DatoInvalidoExcepcion("Se debe agregar una persona para obtenerlos");
            }

            return retorno;
        }

        /// <summary>
        /// Chequeo la existencia de la persona pasada por parametro
        /// </summary>
        /// <param name="p"> Persona que se desea chequear la existencia </param>
        /// <returns> Retorna true si existe,false caso contrario </returns>
        public bool ChequearExistencia(Persona p)
        {
            bool retorno = false;

            foreach (Persona item in this.personas)
            {
                if (item.Equals(p) == true)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Guarda las personas del Centro en un archivo .TXT o .JSON,en caso de errores lanza ErrorArchivoException
        /// </summary>
        /// <param name="path"> Ruta de archivo donde se desea guardar </param>
        /// <param name="tipoDeArchivo"> Tipo de archivo que se desea guardar (.TXT o .JSON) </param>
        public void Guardar(string path, string tipoDeArchivo)
        {
            string formato = tipoDeArchivo.ToUpper();          

            if(!(String.IsNullOrEmpty(path)))
            {
                try
                {
                    if (formato == ".TXT")
                    {
                        using (StreamWriter sw = new StreamWriter(path, false))
                        {
                            sw.WriteLine(CentroDeAnalisis.MostrarPersonas(this));                            
                        }
                    }
                    else if (formato == ".JSON")
                    {
                        StringBuilder jsonCompleto = new StringBuilder();
                        string obj_json = "";

                        foreach (Persona item in this.personas)
                        {
                            obj_json = JsonSerializer.Serialize(item);
                            jsonCompleto.AppendLine(obj_json);
                        }

                        using (StreamWriter sw = new StreamWriter(path, false))
                        {
                            sw.WriteLine(jsonCompleto.ToString());
                        }                        
                    }
                    else
                    {
                        throw new ErrorEnArchivoException("El formato de archivo no es valido");
                    }

                }
                catch (Exception ex)
                {                                    
                    throw new ErrorEnArchivoException(ex.Message,ex.InnerException);
                }

            }
            else
            {
                throw new ErrorEnArchivoException("La ruta de archivo esta vacia");
            }         


            
        }

        /// <summary>
        /// Leo un archivo .TXT con el formato y la forma que se pide.
        /// </summary>
        /// <param name="path"> Ruta donde se desee leer el archivo </param>
        /// <returns></returns>
        public int Leer(string path)
        {
            string linea;                       
            int contadorPersonasExistentes = 0;            
            Persona pAux = null;


            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream == false)
                {
                    linea = sr.ReadLine();

                    if (string.IsNullOrEmpty(linea) == false)
                    {
                        object[] datos = new object[9];

                        //Guardo en el primer lugar la clase de la persona
                        datos[0] = linea;

                        ////Leo la proxima linea y remuevo los primeros 22 caracteres (si el formato es el correcto) no nos sirve 
                        linea = sr.ReadLine();
                        linea = linea.Remove(0, 21);

                        //Queda el nombre y lo guardo en el segundo lugar
                        datos[1] = linea.Substring(0, linea.IndexOf(" "));

                        //Borro desde el principio del nombre hasta el apellido
                        linea = linea.Remove(0, linea.IndexOf(" ") + 1);

                        //Queda el apellido y lo guardo en el tercer lugar
                        datos[2] = linea.Substring(0, linea.IndexOf(" "));

                        ////Leo la proxima linea y remuevo lo que no nos sirve 
                        linea = sr.ReadLine();                        
                        linea = linea.Remove(0, 10);

                        //Guardo la edad en el cuarto lugar
                        datos[3] = int.Parse(linea.Substring(0, linea.IndexOf(" ")));

                        //Leo la proxima linea y remuevo lo que no nos sirve 
                        linea = sr.ReadLine();                        
                        linea = linea.Remove(0, 10);

                        //Guardo el sexo en el quinto lugar
                        datos[4] = (ESexo)Enum.Parse(typeof(ESexo), linea.Substring(0, linea.IndexOf(" ")));


                        //Leo la proxima linea y remuevo lo que no nos sirve 
                        linea = sr.ReadLine();
                        linea = linea.Remove(0, 19);

                        //Guardo la clase social en el cuarto lugar
                        datos[5] = (EClaseSocial)Enum.Parse(typeof(EClaseSocial), linea.Substring(0, linea.IndexOf(" ")));

                        ////Leo la proxima linea
                        linea = sr.ReadLine();

                        //Si esta linea contiene "No tiene hijos" guardo el false en atributo "tieneHijos"
                        if (linea.Contains("No Tiene Hijos"))
                        {
                            datos[6] = false;
                        }
                        else
                        {
                            datos[6] = true;
                        }

                        ////Leo la proxima linea y remuevo lo que no nos sirve 
                        linea = sr.ReadLine();
                        linea = linea.Remove(0, 39);

                        //Guardo la razon en el octavo lugar
                        datos[7] = linea.Substring(0, linea.IndexOf("|..|") - 1);

                        //Dependiendo la clase de la persona instancio el tipo de persona que corresponda
                        switch ((string)datos[0])
                        {
                            case " |... Sin Estudio ... |":

                                pAux = new SinEstudio((string)datos[1], (string)datos[2], (int)datos[3], (ESexo)datos[4], (EClaseSocial)datos[5], (bool)datos[6], (string)datos[7]);
                                break;

                            case " |... Primaria ... |":

                                //En caso de no ser Sin Estudio,leo la proxima linea que seria el Año Maximo alcanzado,remuevo lo que no sirve y lo asigno
                                linea = sr.ReadLine();
                                linea = linea.Remove(0, 48);

                                datos[8] = int.Parse(linea.Substring(0, linea.IndexOf(" ")));

                                pAux = new Primaria((string)datos[1], (string)datos[2], (int)datos[3], (ESexo)datos[4], (EClaseSocial)datos[5], (bool)datos[6], (int)datos[8], (string)datos[7]);

                                break;

                            case " |... Secundario ... |":

                                //En caso de no ser Sin Estudio,leo la proxima linea que seria el Año Maximo alcanzado,remuevo lo que no sirve y lo asigno
                                linea = sr.ReadLine();
                                linea = linea.Remove(0, 48);

                                datos[8] = int.Parse(linea.Substring(0, linea.IndexOf(" ")));

                                pAux = new Secundario((string)datos[1], (string)datos[2], (int)datos[3], (ESexo)datos[4], (EClaseSocial)datos[5], (bool)datos[6], (int)datos[8], (string)datos[7]);

                                break;

                            case " |... Universitario ... |":

                                //En caso de no ser Sin Estudio,leo la proxima linea que seria el Año Maximo alcanzado,remuevo lo que no sirve y lo asigno
                                linea = sr.ReadLine();
                                linea = linea.Remove(0, 48);

                                datos[8] = int.Parse(linea.Substring(0, linea.IndexOf(" ")));

                                pAux = new Universitario((string)datos[1], (string)datos[2], (int)datos[3], (ESexo)datos[4], (EClaseSocial)datos[5], (bool)datos[6], (int)datos[8], (string)datos[7]);

                                break;


                            default:
                                throw new ErrorEnArchivoException("La clase del archivo es incorrecto o esta mal escrito");
                                
                        }                                                                                      

                        try
                        {
                            this.AgregarPersona(pAux);
                        }
                        catch (PersonaExistenteException)
                        {
                            contadorPersonasExistentes++;
                        }

                    }
                }

            }


            return contadorPersonasExistentes;
        }

        /// <summary>
        /// Ingreso una letra para saber cuantos nombres empiezan con esa inicial
        /// </summary>
        /// <param name="letra">Inicial que se quiera buscar</param>
        /// <returns>Retorna la cantidad de personas con esa inicial</returns>
        public int ContarIniciales(char letra)
        {
            return this.ContadorInicialesCentro(letra);
        }



        #endregion



    }
}
