using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormCentrodeAnalisis
{
    public partial class FormMenu : Form
    {

        private CentroDeAnalisis centro;
        public delegate void DelegadoInformacion(string info,string titulo,MessageBoxIcon icon);
        public event DelegadoInformacion InformarAccion;

        int tiempoTranscurrido = 0;        

        /// <summary>
        /// Constructor publico que inicializa el centro de Analisis
        /// </summary>
        public FormMenu()
        {
            this.centro = new CentroDeAnalisis("Centro de Analisis de Abandonos De Estudios");
            this.InformarAccion += this.InformarAccionMessage;
            InitializeComponent();
        }

        #region Botones Click

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                //Instancio un formulario para agregar persona
                FormAgregarPersona f1 = new FormAgregarPersona();

                //lo muestro
                if (f1.ShowDialog() == DialogResult.OK)
                {
                    //Agrego la persona si todo fue correcto
                    centro.AgregarPersona(f1.Retorno);  
                    
                    if(this.InformarAccion != null)
                    {
                        this.InformarAccion("Se genero correctamente la persona nueva", "Informacion", MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                this.InformarAccion(ex.Message, "Advertencia", MessageBoxIcon.Error);              
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Instancio un formulario para eliminar persona
                FormEliminarPersona fp = new FormEliminarPersona();

                //lo muestro
                if (fp.ShowDialog() == DialogResult.OK)
                {
                    //Elimino la persona si todo fue correcto
                    centro.EliminarPersona(fp.Retorno);
                    this.InformarAccion("Se elimino correctamente la persona nueva", "Informacion", MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                this.InformarAccion(ex.Message, "Advertencia", MessageBoxIcon.Error);
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Instancio el formulario para mostrar persona
            FormMostrarPersonas fm = new FormMostrarPersonas(this.centro);

            //Abro el formulario
            fm.ShowDialog();
        }
        
        private void btnGuardarTXT_Click(object sender, EventArgs e)
        {
            //Instancio la ventana para elegir el lugar donde guardar el archivo
            SaveFileDialog sb = new SaveFileDialog();

            //Filtro el tipo de archivo que quiero recibir y su titulo
            sb.Filter = "Archivos de texto(*.txt)|*.txt";
            sb.Title = "Guardar las persona en un archivo TXT";

            if (sb.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Si todo esta bien lo guardo al archivo
                    this.centro.Guardar(sb.FileName, ".TXT");
                    this.InformarAccion("El Archivo fue guardado correctamente", "Informacion", MessageBoxIcon.Information);

                }
                catch (ErrorEnArchivoException ex)
                {                
                    this.InformarAccion(ex.Message, "Advertencia", MessageBoxIcon.Error);              
                }
            }

        }

        private void btnGuardarEnArchivoJson_Click(object sender, EventArgs e)
        {
            //Instancio la ventana para elegir el lugar donde guardar el archivo
            SaveFileDialog sb = new SaveFileDialog();

            //Filtro el tipo de archivo que quiero recibir y su titulo
            sb.Filter = "Archivos Json(*.json)|*.json";
            sb.Title = "Guardar las persona es un archivo Json";

            if (sb.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Si todo esta bien lo guardo al archivo
                    this.centro.Guardar(sb.FileName, ".JSON");
                    this.InformarAccion("Archivo JSON guardado correctamente", "Informacion", MessageBoxIcon.Information);            
                }
                catch (ErrorEnArchivoException ex)
                {
                    this.InformarAccion(ex.Message, "Advertencia", MessageBoxIcon.Error);
                }
            }

        }

        private void btnCargarArchivoTXT_Click(object sender, EventArgs e)
        {
            //Mensaje para aclarar el tema del formato y la forma de escribir el archivo
            string texto = "El Archivo tiene que tener el mismo formato que los archivos guardados por este programa " +
                ", respetando espacios y |..| , las personas que ya existan no seran agregadas.";

            if (MessageBox.Show(texto, "Desea Continuar con la carga?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                try
                {
                    //Instancio la ventana para elegir el lugar donde cargar el archivo
                    OpenFileDialog of = new OpenFileDialog();

                    //Filtro el tipo de archivo que quiero leer y su titulo
                    of.Filter = "Archivos de texto(*.txt)|*.txt";
                    of.Title = "Cargar personas desde un archivo txt";

                    if (of.ShowDialog() == DialogResult.OK)
                    {
                        //si todo sale bien recibo la cantidad de personas repetidas 
                        int cantidadPersonas = this.centro.Leer(of.FileName);

                        //si todo sale bien recibo la cantidad de personas repetidas
                        this.InformarAccion("Se cargo el archivo correctamente. " + cantidadPersonas + " Persona/s ya existian en el Centro", "Informacion", MessageBoxIcon.Information);                        
                    }

                }
                catch (Exception ex)
                {
                    this.InformarAccion("No se pudo continuar con la carga debido a que el formato o algun dato del txt eran incorrectos (" + ex.Message + ")", "Advertencia", MessageBoxIcon.Error);      
                }
            }

        }

        private void btnCargarBD_Click(object sender, EventArgs e)
        {

            try
            {
                //Inicio el centro de carga de Base de datos
                CentroDeAnalisisBD BD = new CentroDeAnalisisBD("CentroCarga");
                //Cargo las personas que se encuentran en la base de datos
                List<Persona> personasBD = BD.ReadAllPersonas();
                //Cargo las personas que se encuentran en el centro de atencion
                Persona[] auxPersonasCentro = this.centro.ObtenerTodos();

                int personasExistentes = 0;
                int personasEliminadas = 0;

                foreach (Persona personaCentro in auxPersonasCentro)
                {
                    try
                    {
                        //Si la persona no existe en la base de datos la agrego
                        BD.CreatePersona(personaCentro);

                    }
                    catch (PersonaExistenteException)
                    {
                        personasExistentes++;
                    }
                }

                foreach (Persona personaBD in personasBD)
                {
                    //Si la persona existe en la base de datos pero no esta en el centro,lo elimino
                    if (this.centro.ChequearExistencia(personaBD) == false)
                    {
                        BD.DeletePersona(personaBD);
                        personasEliminadas++;
                    }

                }

                //Se actualizaron los datos y se informa con el evento InformarAccion
                this.InformarAccion("Se cargo correctamente los datos en la base de datos. Ya existian " + personasExistentes + " Personas y  " + personasEliminadas + " fueron eliminadas", "Informacion", MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                //En caso de alguna Excepcion la informmo con el mismo evento
                this.InformarAccion(ex.Message, "Advertencia", MessageBoxIcon.Error);
            }


        }

        private void btnCargarPersonasBD_Click(object sender, EventArgs e)
        {
            int contadorPersonasExistentes = 0;

            try
            {
                //Inicio el centro de carga de Base de datos
                CentroDeAnalisisBD BD = new CentroDeAnalisisBD("CentroCarga");
                //Cargo las personas que se encuentran en la base de datos
                List<Persona> personasBD = BD.ReadAllPersonas();

                foreach (Persona item in personasBD)
                {
                    try
                    {
                        //Intento agregar la persona en caso que no exista
                        this.centro.AgregarPersona(item);
                    }
                    catch (PersonaExistenteException)
                    {
                        contadorPersonasExistentes++;
                    }
                }

                this.InformarAccion("Se cargo correctamente los datos desde la Base de datos. Ya existian " + contadorPersonasExistentes + " Personas", "Informacion", MessageBoxIcon.Information);

            }

            catch (Exception ex)
            {
                this.InformarAccion(ex.Message, "Advertencia", MessageBoxIcon.Error);
            }

        }

        #endregion

        #region Metodos propios

        /// <summary>
        /// Guarda en un archivo.txt guardado en mis documentos,el tiempo transcurrido en el formulario
        /// </summary>
        private void GuardarInfoTiempo()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            this.tiempoTranscurrido++;

            using (StreamWriter sw = new StreamWriter(path + @"/TiempoTranscurrido.txt", false))
            {
                sw.WriteLine("El tiempo transcurrido fue de {0} segundos", this.tiempoTranscurrido);
            }
        }

        #endregion

        #region Eventos

        private void FormMenu_Load(object sender, EventArgs e)
        {
            //Al cargar el formulario inicio el timer tiempo transcurrido
            TimerTiempoTranscurrido.Start();
        }

        private void TimerTiempoTranscurrido_Tick(object sender, EventArgs e)
        {
            //Por cada tick llamo al metodo GuardarInfoTiempo en un hilo aparte
            Task guardarInfoTiempo = Task.Run(GuardarInfoTiempo);
        }

        //Capturo el evento y lo muestro en un messageBox
        private void InformarAccionMessage(string texto, string titulo, MessageBoxIcon icon)
        {
            MessageBox.Show(texto, titulo, MessageBoxButtons.OK, icon);
        }

        #endregion







    }
}
