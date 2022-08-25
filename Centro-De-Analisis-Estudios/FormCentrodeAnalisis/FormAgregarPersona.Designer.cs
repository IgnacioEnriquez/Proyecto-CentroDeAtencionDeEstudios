
namespace FormCentrodeAnalisis
{
    partial class FormAgregarPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipoDePersona = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtRazonAbandono = new System.Windows.Forms.TextBox();
            this.lblRazonDeAbandono = new System.Windows.Forms.Label();
            this.cbHijos = new System.Windows.Forms.CheckBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.cmbClaseSocial = new System.Windows.Forms.ComboBox();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblClaseSocial = new System.Windows.Forms.Label();
            this.txtMaximoAño = new System.Windows.Forms.TextBox();
            this.lblMaximoAñoAlcanzado = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(12, 25);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(208, 23);
            this.cmbTipo.TabIndex = 0;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // lblTipoDePersona
            // 
            this.lblTipoDePersona.AutoSize = true;
            this.lblTipoDePersona.Location = new System.Drawing.Point(5, 7);
            this.lblTipoDePersona.Name = "lblTipoDePersona";
            this.lblTipoDePersona.Size = new System.Drawing.Size(91, 15);
            this.lblTipoDePersona.TabIndex = 1;
            this.lblTipoDePersona.Text = "Tipo de Persona";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(208, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(5, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(5, 122);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(12, 140);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(208, 23);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(12, 196);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(72, 23);
            this.txtEdad.TabIndex = 3;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(11, 178);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 7;
            this.lblEdad.Text = "Edad";
            // 
            // txtRazonAbandono
            // 
            this.txtRazonAbandono.Location = new System.Drawing.Point(11, 331);
            this.txtRazonAbandono.Multiline = true;
            this.txtRazonAbandono.Name = "txtRazonAbandono";
            this.txtRazonAbandono.Size = new System.Drawing.Size(234, 120);
            this.txtRazonAbandono.TabIndex = 8;
            // 
            // lblRazonDeAbandono
            // 
            this.lblRazonDeAbandono.AutoSize = true;
            this.lblRazonDeAbandono.Location = new System.Drawing.Point(5, 313);
            this.lblRazonDeAbandono.Name = "lblRazonDeAbandono";
            this.lblRazonDeAbandono.Size = new System.Drawing.Size(114, 15);
            this.lblRazonDeAbandono.TabIndex = 10;
            this.lblRazonDeAbandono.Text = "Razon de Abandono";
            // 
            // cbHijos
            // 
            this.cbHijos.AutoSize = true;
            this.cbHijos.Location = new System.Drawing.Point(12, 235);
            this.cbHijos.Name = "cbHijos";
            this.cbHijos.Size = new System.Drawing.Size(89, 19);
            this.cbHijos.TabIndex = 5;
            this.cbHijos.Text = "Tiene Hijos?";
            this.cbHijos.UseVisualStyleBackColor = true;
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(11, 282);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(105, 23);
            this.cmbSexo.TabIndex = 6;
            // 
            // cmbClaseSocial
            // 
            this.cmbClaseSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClaseSocial.FormattingEnabled = true;
            this.cmbClaseSocial.Location = new System.Drawing.Point(133, 282);
            this.cmbClaseSocial.Name = "cmbClaseSocial";
            this.cmbClaseSocial.Size = new System.Drawing.Size(105, 23);
            this.cmbClaseSocial.TabIndex = 7;
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Location = new System.Drawing.Point(12, 263);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(32, 15);
            this.LblSexo.TabIndex = 14;
            this.LblSexo.Text = "Sexo";
            // 
            // LblClaseSocial
            // 
            this.LblClaseSocial.AutoSize = true;
            this.LblClaseSocial.Location = new System.Drawing.Point(133, 263);
            this.LblClaseSocial.Name = "LblClaseSocial";
            this.LblClaseSocial.Size = new System.Drawing.Size(69, 15);
            this.LblClaseSocial.TabIndex = 15;
            this.LblClaseSocial.Text = "Clase Social";
            // 
            // txtMaximoAño
            // 
            this.txtMaximoAño.Location = new System.Drawing.Point(133, 196);
            this.txtMaximoAño.Name = "txtMaximoAño";
            this.txtMaximoAño.Size = new System.Drawing.Size(80, 23);
            this.txtMaximoAño.TabIndex = 4;
            this.txtMaximoAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaximoAño_KeyPress);
            // 
            // lblMaximoAñoAlcanzado
            // 
            this.lblMaximoAñoAlcanzado.AutoSize = true;
            this.lblMaximoAñoAlcanzado.Location = new System.Drawing.Point(114, 178);
            this.lblMaximoAñoAlcanzado.Name = "lblMaximoAñoAlcanzado";
            this.lblMaximoAñoAlcanzado.Size = new System.Drawing.Size(134, 15);
            this.lblMaximoAñoAlcanzado.TabIndex = 17;
            this.lblMaximoAñoAlcanzado.Text = "Maximo Año Alcanzado";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(53, 467);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(141, 30);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar Persona";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FormAgregarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 509);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblMaximoAñoAlcanzado);
            this.Controls.Add(this.txtMaximoAño);
            this.Controls.Add(this.LblClaseSocial);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.cmbClaseSocial);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.cbHijos);
            this.Controls.Add(this.lblRazonDeAbandono);
            this.Controls.Add(this.txtRazonAbandono);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTipoDePersona);
            this.Controls.Add(this.cmbTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAgregarPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Persona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipoDePersona;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtRazonAbandono;
        private System.Windows.Forms.Label lblRazonDeAbandono;
        private System.Windows.Forms.CheckBox cbHijos;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.ComboBox cmbClaseSocial;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblClaseSocial;
        private System.Windows.Forms.TextBox txtMaximoAño;
        private System.Windows.Forms.Label lblMaximoAñoAlcanzado;
        private System.Windows.Forms.Button btnAgregar;
    }
}