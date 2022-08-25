using System;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            CentroDeAnalisis c1 = new CentroDeAnalisis("Centro de Pruebas");

            //Creo 3 personas,2 con Nombre,Edad,Sexo y Clase social igual para que haya excepcion
            SinEstudio s1 = new SinEstudio("Ignacio", "Enriquez", 20, ESexo.Hombre, EClaseSocial.Clase_Media, false, "No pudo completar el tp 3 y abandono todo");
            SinEstudio s2 = new SinEstudio("Ignacio", "Enriquez", 20, ESexo.Hombre, EClaseSocial.Clase_Alta, true, "No pudo y abandono todo");
            SinEstudio s3 = new SinEstudio("Josefa", "Fernandez", 18, ESexo.Hombre, EClaseSocial.Clase_Alta, true, "No pudo y abandono todo");

            //Creo 3 personas,2 con Nombre,Edad,Sexo y Clase social igual para que haya excepcion
            Primaria p1 = new Primaria("Castro", "Alvaro", 20, ESexo.Hombre, EClaseSocial.Clase_Media, false, 6, "No pudo completar el tp 3 y abandono todo");
            Primaria p2 = new Primaria("Pepina", "Argento", 18, ESexo.Mujer, EClaseSocial.Clase_Alta, true, 4, "No pudo y abandono todo");

            //Creo 3 personas,2 con Nombre,Edad,Sexo y Clase social igual para que haya excepcion
            Secundario sec1 = new Secundario("Coqui", "Argento", 20, ESexo.Hombre, EClaseSocial.Clase_Media, false, 4, "No pudo completar el tp 3 y abandono todo");
            Secundario sec2 = new Secundario("Maira", "Ladrona", 18, ESexo.Mujer, EClaseSocial.Clase_Alta, true, 4, "No pudo y abandono todo");

            //Creo 3 personas,2 con Nombre,Edad,Sexo y Clase social igual para que haya excepcion
            Universitario u1 = new Universitario("Nosemeo", "Nada", 20, ESexo.Hombre, EClaseSocial.Clase_Media, false, 2, "No pudo completar el tp 3 y abandono todo");
            Universitario u2 = new Universitario("Aprobame", "Porfavor", 18, ESexo.Mujer, EClaseSocial.Clase_Alta, true, 4, "No pudo y abandono todo");

            //Agrego las 4 personas,no tiene que haber problemas
            c1.AgregarPersona(u1);
            c1.AgregarPersona(sec1);
            c1.AgregarPersona(p1);
            c1.AgregarPersona(s1);

            //Muestro el centro
            Console.Write(CentroDeAnalisis.MostrarPersonas(c1));
            Console.ReadKey();

            try
            {
                //Intento agregar una persona repetida
                c1.AgregarPersona(s2);
            }
            catch (PersonaExistenteException ex)
            {
                //Tiene que lanzar PersonaExistenteException
                Console.WriteLine(ex.Message);
                
                Console.ReadKey();
            }

            try
            {
                //Intento eliminar una persona que no existe en el centro
                c1.EliminarPersona(new Secundario("Persona", "Inexistente", 50, ESexo.Mujer, EClaseSocial.Clase_Alta, false, 5, "Porque no existe"));
            }
            catch (PersonaInexistenteException ex)
            {
                //Tiene que lanzar PersonaInexistenteException
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

            Console.Clear();

            //Agrego una persona mas Sin estudio para mostrarla
            c1.AgregarPersona(s3);

            //Debe mostrar solamente las personas "Sin Estudio" que sean del sexo hombre y de todas las clases sociales;
            Console.WriteLine(CentroDeAnalisis.MostrarPersonas(c1, 3, ESexo.Hombre, (EClaseSocial)3));

            Console.ReadKey();

            Console.Clear();

            try
            {
                ESexo mayoria;
                int numero;

                //Me fijo que sexo predomina y lo guardo los datos en la variable
                CentroDeAnalisis.ContarMayorias(c1, out mayoria, out numero);

                //Muestro que genero y cantidad predomina
                Console.WriteLine("La mayoria es de sexo {0} con una cantidad de {1} personas", mayoria, numero);
            }
            catch (DatoInvalidoExcepcion ex)
            {
                //Si no hay una mayoria o esta vacio el centro muestro la excepcion
                Console.WriteLine(ex.Message);
            }

            try
            {
                EClaseSocial mayoria;
                int numero;

                //Me fijo que Clase Social predomina y lo guardo los datos en la variable
                CentroDeAnalisis.ContarMayorias(c1, out mayoria, out numero);

                //Muestro que Clase Social y cantidad predomina
                Console.WriteLine("La mayoria es de Clase :  {0} con una cantidad de {1} personas", mayoria, numero);
            }
            catch (DatoInvalidoExcepcion ex)
            {
                //Si no hay una mayoria o esta vacio el centro muestro la excepcion
                Console.WriteLine(ex.Message);
            }

            try
            {
                bool mayoria;
                int numero;

                //Me fijo que Clase Social predomina y lo guardo los datos en la variable
                CentroDeAnalisis.ContarMayorias(c1, out mayoria, out numero);

                //Muestro que Clase Social y cantidad predomina
                if (mayoria == true)
                {
                    Console.WriteLine("La mayoria tiene hijos con una cantidad de {1} personas con hijos", mayoria, numero);
                }
                else
                {
                    Console.WriteLine("La mayoria no tiene hijos con una cantidad de {1} personas sin hijos", mayoria, numero);

                }
            }
            catch (DatoInvalidoExcepcion ex)
            {
                //Si no hay una mayoria o esta vacio el centro muestro la excepcion
                Console.WriteLine(ex.Message);
            }

            int edadMenor;
            int edadMayor;
            int añoMayor;
            int añoMenor;

            //Obtengo rangos maximos y minimos
            CentroDeAnalisis.ObtenerRangos(c1, out edadMenor, out edadMayor, out añoMenor, out añoMayor);

            //Los muestro
            Console.WriteLine("La edad menor es {0},la edad mayor es {1} , el anio maximo alcanzado menor es {2} y el anio maximo alcanzado mayor es {3}", edadMenor, edadMayor, añoMenor, añoMayor);

            Console.ReadKey();

            Console.Clear();

            //Guardo los datos en un archivo .TXT en el escritorio
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            c1.Guardar(path + @"/Prueba.txt", ".TXT");

            //Elimino todos los elementos del centro
            c1.EliminarTodos();

            //Muestro que la lista no tiene a nadie
            Console.WriteLine(CentroDeAnalisis.MostrarPersonas(c1));
            Console.ReadKey();
            //Abro el mismo archivo txt y cargo las mismas personas
            c1.Leer(path + @"/Prueba.txt");

            Console.Clear();

            //Muestro que la lista tiene a todos devuelta
            Console.WriteLine(CentroDeAnalisis.MostrarPersonas(c1));
            Console.ReadKey();


        }
    }
}
