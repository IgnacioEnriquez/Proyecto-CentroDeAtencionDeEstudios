using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormCentrodeAnalisis
{
    public partial class FormMostrarPersonas : Form
    {

        private CentroDeAnalisis centro;
        //Se encarga de no tener en cuenta las primeras 3 actualizaciones del cmb
        private int iniciadorIndex = 0;

        /// <summary>
        /// Constructor privado sin argumentos que inicia el form
        /// </summary>
        private FormMostrarPersonas()
        {
            InitializeComponent();                     
        }


        /// <summary>
        /// Constructor que inicia el atributo centro 
        /// </summary>
        /// <param name="centroAnalisis"> Centro de Analisis que se quiere guardar</param>
        public FormMostrarPersonas(CentroDeAnalisis centroAnalisis) : this()
        {
            this.centro = centroAnalisis;

            this.AgregarAtributos();            

            this.ActualizarMostrador(this.cmbTipoPersona.SelectedIndex, this.cmbSexo.SelectedIndex, this.cmbClaseSocial.SelectedIndex);
        }

        #region Metodos propios 

        /// <summary>
        /// Actualiza los datos mostrados dependiendo el tipo de persona,el sexo y la clase elegida
        /// </summary>
        /// <param name="index"> Tipo de persona que se quiere ver </param>
        /// <param name="indexSexo"> Tipo de Sexo que se quiere ver </param>
        /// <param name="indexClase"> Tipo de Clase que se quiere ver </param>
        private void ActualizarMostrador(int index, int indexSexo, int indexClase)
        {
            this.rtbMostrar.Text = CentroDeAnalisis.MostrarPersonas(centro, index, (ESexo)indexSexo, (EClaseSocial)indexClase);
        }


        /// <summary>
        /// Agrega los atributos predeterminados a los combobox
        /// </summary>
        private void AgregarAtributos()
        {
            this.cmbTipoPersona.Items.Add("Universitario");
            this.cmbTipoPersona.Items.Add("Secundaria");
            this.cmbTipoPersona.Items.Add("Primaria");
            this.cmbTipoPersona.Items.Add("Sin Estudio");
            this.cmbTipoPersona.Items.Add("Todos");
            this.cmbTipoPersona.SelectedIndex = 4;


            this.cmbSexo.Items.Add(ESexo.Hombre);
            this.cmbSexo.Items.Add(ESexo.Mujer);
            this.cmbSexo.Items.Add(ESexo.NoBinarie);
            this.cmbSexo.Items.Add(ESexo.Otros);
            this.cmbSexo.Items.Add("Todos");
            this.cmbSexo.SelectedIndex = 4;


            this.cmbClaseSocial.Items.Add(EClaseSocial.Clase_Alta);
            this.cmbClaseSocial.Items.Add(EClaseSocial.Clase_Baja);
            this.cmbClaseSocial.Items.Add(EClaseSocial.Clase_Media);
            this.cmbClaseSocial.Items.Add("Todos");
            this.cmbClaseSocial.SelectedIndex = 3;
        }


        #endregion

        #region Eventos

        private void cmbTipoPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si ya paso las 3 llamadas predeterminadas
            if (this.iniciadorIndex >= 3)
            {
                //Actualizo el mostrador dependiendo los cmb elegidos
                this.ActualizarMostrador(this.cmbTipoPersona.SelectedIndex, this.cmbSexo.SelectedIndex, this.cmbClaseSocial.SelectedIndex);
            }
            else
            {
                this.iniciadorIndex++;
            }

        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si ya paso las 3 llamadas predeterminadas
            if (this.iniciadorIndex >= 3)
            {
                //Actualizo el mostrador dependiendo los cmb elegidos
                this.ActualizarMostrador(this.cmbTipoPersona.SelectedIndex, this.cmbSexo.SelectedIndex, this.cmbClaseSocial.SelectedIndex);
            }
            else
            {
                this.iniciadorIndex++;
            }

        }

        private void cmbClaseSocial_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si ya paso las 3 llamadas predeterminadas
            if (this.iniciadorIndex >= 3)
            {
                //Actualizo el mostrador dependiendo los cmb elegidos
                this.ActualizarMostrador(this.cmbTipoPersona.SelectedIndex, this.cmbSexo.SelectedIndex, this.cmbClaseSocial.SelectedIndex);
            }
            else
            {
                this.iniciadorIndex++;
            }
        }

        /// <summary>
        /// Muestra que sexo predomina en este centro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnalisisSexo_Click(object sender, EventArgs e)
        {
            try
            {
                ESexo mayoria;
                int numMayor;

                StringBuilder sb = new StringBuilder();

                //Si no ocurre ninguna excepcion retorna el Sexo que predomina y su cantidad
                CentroDeAnalisis.ContarMayorias(this.centro, out mayoria, out numMayor);

                sb.Append("Predomina el Sexo ");
                sb.Append(mayoria.ToString());
                sb.Append(" con una cantidad de ");
                sb.Append(numMayor.ToString());
                sb.Append(" Personas en el centro");

                MessageBox.Show(sb.ToString(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (DatoInvalidoExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Muestra que Clase Social predomina en este centro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnalisisClaseSocial_Click(object sender, EventArgs e)
        {
            try
            {
                EClaseSocial mayoria;
                int numMayor;
                StringBuilder sb = new StringBuilder();

                //Si no ocurre ninguna excepcion retorna la Clase que predomina y su cantidad
                CentroDeAnalisis.ContarMayorias(this.centro, out mayoria, out numMayor);

                sb.Append("Predomina la Clase Social ");
                sb.Append(mayoria.ToString().Replace("_", " "));
                sb.Append(" con una cantidad de ");
                sb.Append(numMayor.ToString());
                sb.Append(" Personas en el centro");

                MessageBox.Show(sb.ToString(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DatoInvalidoExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Muestra que tenencia de hijos predomina en este centro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnalisisHijos_Click(object sender, EventArgs e)
        {

            try
            {
                bool hijos;
                int numMayor;
                StringBuilder sb = new StringBuilder();

                //Si no ocurre ninguna excepcion retorna la tenencia de hijos que predomina y su cantidad
                CentroDeAnalisis.ContarMayorias(this.centro, out hijos, out numMayor);

                sb.Append("Predomina las personas que ");

                if (hijos == true)
                {
                    sb.Append("tienen hijos");
                }
                else
                {
                    sb.Append("no tienen hijos");
                }

                sb.Append(" con una cantidad de ");
                sb.Append(numMayor.ToString());
                sb.Append(" Personas en el centro");

                MessageBox.Show(sb.ToString(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (DatoInvalidoExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Muestra cual es el año maximo alcanzado en este centro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAñoMaximo_Click(object sender, EventArgs e)
        {
            try
            {
                int anioMaximo;            

                //Obtengo los rangos,utilizo el caracter '_' para descartar los datos que no utilizo
                //Si no ocurrio ninguna excepcion obtengo la informacion
                CentroDeAnalisis.ObtenerRangos(this.centro, out _, out _, out _, out anioMaximo);

                StringBuilder sb = new StringBuilder();

                sb.Append("El año maximo alcanzado de una persona es el de ");
                sb.Append(anioMaximo.ToString());

                MessageBox.Show(sb.ToString(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DatoInvalidoExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Muestra cual es la edad maxima alcanzada en este centro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdadMaxima_Click(object sender, EventArgs e)
        {

            try
            {
                int edadMaximo;

                //Obtengo los rangos,utilizo el caracter '_' para descartar los datos que no utilizo
                //Si no ocurrio ninguna excepcion obtengo la informacion
                CentroDeAnalisis.ObtenerRangos(this.centro, out _, out edadMaximo, out _, out _);

                StringBuilder sb = new StringBuilder();

                sb.Append("La edad maxima de una persona es de ");
                sb.Append(edadMaximo.ToString());
                sb.Append(" Años de edad");

                MessageBox.Show(sb.ToString(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DatoInvalidoExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Muestra cual es el año maximo alcanzado en este centro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAñoMinimo_Click(object sender, EventArgs e)
        {
            try
            {
                int anioMinimo;

                //Obtengo los rangos,utilizo el caracter '_' para descartar los datos que no utilizo
                //Si no ocurrio ninguna excepcion obtengo la informacion
                CentroDeAnalisis.ObtenerRangos(this.centro, out _, out _, out anioMinimo, out _);

                StringBuilder sb = new StringBuilder();

                sb.Append("La año minimo alcanzado de una persona es el de ");
                sb.Append(anioMinimo.ToString());

                MessageBox.Show(sb.ToString(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DatoInvalidoExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Muestra cual es la edad minima alcanzada en este centro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdadMinima_Click(object sender, EventArgs e)
        {
            try
            {
                int edadMinimo;

                //Obtengo los rangos,utilizo el caracter '_' para descartar los datos que no utilizo
                //Si no ocurrio ninguna excepcion obtengo la informacion
                CentroDeAnalisis.ObtenerRangos(this.centro, out edadMinimo, out _, out _, out _);

                StringBuilder sb = new StringBuilder();

                sb.Append("La edad minima de una persona es de ");
                sb.Append(edadMinimo.ToString());
                sb.Append(" Años de edad");

                MessageBox.Show(sb.ToString(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DatoInvalidoExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Muestra cual es el promedio de edad en este centro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPromedioEdad_Click(object sender, EventArgs e)
        {
            try
            {
                float promedioEdad;

                //Obtengo los rangos,utilizo el caracter '_' para descartar los datos que no utilizo
                //Si no ocurrio ninguna excepcion obtengo la informacion
                CentroDeAnalisis.ObtenerPromedios(this.centro, out promedioEdad, out _);

                StringBuilder sb = new StringBuilder();

                sb.Append("La edad promedio de las personas es de ");
                sb.Append(promedioEdad.ToString("N2"));

                MessageBox.Show(sb.ToString(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DatoInvalidoExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Muestra cual es el promedio de año maximo en este centro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPromedioDeAñoMaximo_Click(object sender, EventArgs e)
        {
            try
            {
                float promediosAñoMaximo;

                //Obtengo los rangos,utilizo el caracter '_' para descartar los datos que no utilizo
                //Si no ocurrio ninguna excepcion obtengo la informacion
                CentroDeAnalisis.ObtenerPromedios(this.centro, out _, out promediosAñoMaximo);

                StringBuilder sb = new StringBuilder();

                sb.Append("El año maximo alcanzado promedio de las personas es de ");
                sb.Append(promediosAñoMaximo.ToString("N2"));

                MessageBox.Show(sb.ToString(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DatoInvalidoExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Muestra cual es el porcentaje promedio de mujeres en este centro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPromedioMujeres_Click(object sender, EventArgs e)
        {
            try
            {
                float promedioSexo;
                
                //Si no ocurrio ninguna excepcion obtengo la informacion
                CentroDeAnalisis.ObtenerPorcentajePromedio(this.centro, ESexo.Mujer, out promedioSexo);

                StringBuilder sb = new StringBuilder();

                sb.Append("El sexo femenino promedio entre todas las personas es de ");
                sb.Append(promedioSexo.ToString("N2"));
                sb.Append(" %");

                MessageBox.Show(sb.ToString(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DatoInvalidoExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Muestra cual es el porcentaje promedio de personas con Clase Social baja en este centro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPromedioClaseSocial_Click(object sender, EventArgs e)
        {
            try
            {
                float promedioClase;

                //Obtengo los rangos,utilizo el caracter '_' para descartar los datos que no utilizo
                //Si no ocurrio ninguna excepcion obtengo la informacion
                CentroDeAnalisis.ObtenerPorcentajePromedio(this.centro, EClaseSocial.Clase_Baja, out promedioClase);

                StringBuilder sb = new StringBuilder();

                sb.Append("Las personas de Clase Social Baja promedio entre todas las personas es de ");
                sb.Append(promedioClase.ToString("N2"));
                sb.Append(" %");

                MessageBox.Show(sb.ToString(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DatoInvalidoExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        #endregion


    }
}
