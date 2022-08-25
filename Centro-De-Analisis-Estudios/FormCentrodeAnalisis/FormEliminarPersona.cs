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
    public partial class FormEliminarPersona : Form
    {
        /// <summary>
        /// Constructor por defecto que inicia el formulario y agrega los atributos a los cmb
        /// </summary>
        public FormEliminarPersona()
        {
            InitializeComponent();
            this.AgregarAtributos();
        }

        /// <summary>
        /// Propiedad publica de retorno de persona para eliminar
        /// </summary>
        public Persona Retorno
        {
            get;

            set;
        }

        #region Metodos propios

        /// <summary>
        /// Asigno los atributos a los combobox
        /// </summary>
        private void AgregarAtributos()
        {
            //Completo Tipo de Persona
            this.cmbTipo.Items.Add("Universitario");
            this.cmbTipo.Items.Add("Primaria");
            this.cmbTipo.Items.Add("Secundaria");
            this.cmbTipo.Items.Add("Sin Estudio");
            this.cmbTipo.SelectedIndex = 0;

            //Completo Genero
            this.cmbSexo.Items.Add(ESexo.Hombre);
            this.cmbSexo.Items.Add(ESexo.Mujer);
            this.cmbSexo.Items.Add(ESexo.NoBinarie);
            this.cmbSexo.Items.Add(ESexo.Otros);
            this.cmbSexo.SelectedIndex = 0;

        }

        /// <summary>
        /// Chequeo que ninguno de los textbox esten vacios a la hora de crear una persona
        /// </summary>
        /// <returns> retorno true si hay alguno vacio,caso contrario retorno false </returns>
        private bool ChequearVacios()
        {
            bool retorno = false;

            string[] textos = new string[3];
            textos[0] = this.txtApellido.Text.ToString();
            textos[1] = this.txtNombre.Text.ToString();
            textos[2] = this.txtEdad.Text.ToString();

            foreach (string item in textos)
            {
                if (string.IsNullOrEmpty(item) == true)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;

        }

        /// <summary>
        /// Chequeo que no se escriban otros tipos de caracteres o digitos en los textbox,lanzo una advertencia si es asi
        /// </summary>
        /// <param name="e"> Parametro de tecla presionada </param>
        /// <param name="error"> Error que se desea mostrar </param>
        /// <param name="esDigito"> Si solo se desea que se puedan ingresar digitos </param>
        private void ChequearOtrosDigitos(KeyPressEventArgs e, string error, bool esDigito)
        {
            if (esDigito == false)
            {
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show(error, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    MessageBox.Show(error, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        #endregion

        #region Eventos

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Chequeo que no se puedan escribir numeros ni otros caracteres raros
            this.ChequearOtrosDigitos(e, "No se permiten numeros ni otro tipo de caracteres raros en el Nombre", false);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Chequeo que no se puedan escribir numeros ni otros caracteres raros
            this.ChequearOtrosDigitos(e, "No se permiten numeros ni otro tipo de caracteres raros en el Apellido", false);
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Chequeo que no se puedan escribir letras ni otros caracteres raros
            this.ChequearOtrosDigitos(e, "No se permiten numeros ni otro tipo de caracteres raros en el Nombre", true);

        }

        private void txtMaximoAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Chequeo que no se puedan escribir letras ni otros caracteres raros
            this.ChequearOtrosDigitos(e, "No se permiten numeros ni otro tipo de caracteres raros en el Nombre", true);
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si se cambia el tipo de persona elegido,y este es de tipo "sinEstudio",se quita la visibilidad del campo Año Maximo Alcanzado

            if (this.cmbTipo.SelectedIndex != 3)
            {
                this.txtMaximoAño.Visible = true;
                this.lblMaximoAñoAlcanzado.Visible = true;
            }
            else
            {
                this.txtMaximoAño.Visible = false;
                this.lblMaximoAñoAlcanzado.Visible = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.ChequearVacios() == false)
            {
                //Atributos para comprobar la existencia
                string nombre = txtNombre.Text.ToString();
                string apellido = txtApellido.Text.ToString();
                int edad = int.Parse(txtEdad.Text);
                ESexo sexo = (ESexo)Enum.Parse(typeof(ESexo), this.cmbSexo.Text);

                try
                {
                    if (this.cmbTipo.SelectedIndex != 3 && string.IsNullOrEmpty(this.txtMaximoAño.Text.ToString()) == false)
                    {
                        int maximoAño = int.Parse(this.txtMaximoAño.Text);

                        if (cmbTipo.SelectedIndex == 0)
                        {
                            Universitario u1 = new Universitario(nombre, apellido, edad, sexo, EClaseSocial.Clase_Baja, true, maximoAño, " ");

                            this.Retorno = u1;

                        }
                        else if (cmbTipo.SelectedIndex == 1)
                        {
                            Primaria p1 = new Primaria(nombre, apellido, edad, sexo, EClaseSocial.Clase_Baja, true, maximoAño, " ");

                            this.Retorno = p1;

                        }
                        else if (cmbTipo.SelectedIndex == 2)
                        {
                            Secundario s1 = new Secundario(nombre, apellido, edad, sexo, EClaseSocial.Clase_Baja, true, maximoAño, " ");

                            this.Retorno = s1;
                        }

                    }
                    else
                    {
                        SinEstudio s1 = new SinEstudio(nombre, apellido, edad, sexo, EClaseSocial.Clase_Baja, true, " ");

                        this.Retorno = s1;

                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (DatoInvalidoExcepcion ex)
                {
                    MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.Cancel;

                }

            }
            else
            {
                MessageBox.Show("Ningun elemento puede estar vacio para agregar la persona", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }


        #endregion



    }
}
