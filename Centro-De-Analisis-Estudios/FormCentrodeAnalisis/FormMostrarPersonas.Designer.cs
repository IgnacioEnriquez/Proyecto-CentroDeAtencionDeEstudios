
namespace FormCentrodeAnalisis
{
    partial class FormMostrarPersonas
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
            this.cmbTipoPersona = new System.Windows.Forms.ComboBox();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.lblTipoDePersona = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblTipoDeSexo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClaseSocial = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblAnalisis = new System.Windows.Forms.Label();
            this.lblInfoTipo = new System.Windows.Forms.Label();
            this.btnAñoMaximo = new System.Windows.Forms.Button();
            this.btnAnalisisSexo = new System.Windows.Forms.Button();
            this.btnAnalisisClaseSocial = new System.Windows.Forms.Button();
            this.btnAnalisisHijos = new System.Windows.Forms.Button();
            this.btnEdadMaxima = new System.Windows.Forms.Button();
            this.btnAñoMinimo = new System.Windows.Forms.Button();
            this.btnEdadMinima = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPromedioEdad = new System.Windows.Forms.Button();
            this.btnPromedioDeAñoMaximo = new System.Windows.Forms.Button();
            this.btnPromedioMujeres = new System.Windows.Forms.Button();
            this.btnPromedioClaseSocial = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTipoPersona
            // 
            this.cmbTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPersona.FormattingEnabled = true;
            this.cmbTipoPersona.Location = new System.Drawing.Point(27, 56);
            this.cmbTipoPersona.Name = "cmbTipoPersona";
            this.cmbTipoPersona.Size = new System.Drawing.Size(170, 23);
            this.cmbTipoPersona.TabIndex = 0;
            this.cmbTipoPersona.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPersona_SelectedIndexChanged);
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Location = new System.Drawing.Point(3, 85);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.ReadOnly = true;
            this.rtbMostrar.Size = new System.Drawing.Size(655, 610);
            this.rtbMostrar.TabIndex = 1;
            this.rtbMostrar.Text = "";
            // 
            // lblTipoDePersona
            // 
            this.lblTipoDePersona.AutoSize = true;
            this.lblTipoDePersona.Location = new System.Drawing.Point(27, 38);
            this.lblTipoDePersona.Name = "lblTipoDePersona";
            this.lblTipoDePersona.Size = new System.Drawing.Size(91, 15);
            this.lblTipoDePersona.TabIndex = 2;
            this.lblTipoDePersona.Text = "Tipo de Persona";
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(216, 56);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(170, 23);
            this.cmbSexo.TabIndex = 3;
            this.cmbSexo.SelectedIndexChanged += new System.EventHandler(this.cmbSexo_SelectedIndexChanged);
            // 
            // lblTipoDeSexo
            // 
            this.lblTipoDeSexo.AutoSize = true;
            this.lblTipoDeSexo.Location = new System.Drawing.Point(216, 38);
            this.lblTipoDeSexo.Name = "lblTipoDeSexo";
            this.lblTipoDeSexo.Size = new System.Drawing.Size(32, 15);
            this.lblTipoDeSexo.TabIndex = 4;
            this.lblTipoDeSexo.Text = "Sexo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clase Social";
            // 
            // cmbClaseSocial
            // 
            this.cmbClaseSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClaseSocial.FormattingEnabled = true;
            this.cmbClaseSocial.Location = new System.Drawing.Point(405, 56);
            this.cmbClaseSocial.Name = "cmbClaseSocial";
            this.cmbClaseSocial.Size = new System.Drawing.Size(170, 23);
            this.cmbClaseSocial.TabIndex = 5;
            this.cmbClaseSocial.SelectedIndexChanged += new System.EventHandler(this.cmbClaseSocial_SelectedIndexChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFiltro.Location = new System.Drawing.Point(4, 2);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(177, 25);
            this.lblFiltro.TabIndex = 9;
            this.lblFiltro.Text = "Filtros de Mostrado";
            // 
            // lblAnalisis
            // 
            this.lblAnalisis.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnalisis.Location = new System.Drawing.Point(663, 2);
            this.lblAnalisis.Name = "lblAnalisis";
            this.lblAnalisis.Size = new System.Drawing.Size(157, 51);
            this.lblAnalisis.TabIndex = 10;
            this.lblAnalisis.Text = "Analisis de Datos Generales";
            this.lblAnalisis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfoTipo
            // 
            this.lblInfoTipo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfoTipo.Location = new System.Drawing.Point(672, 169);
            this.lblInfoTipo.Name = "lblInfoTipo";
            this.lblInfoTipo.Size = new System.Drawing.Size(156, 28);
            this.lblInfoTipo.TabIndex = 12;
            this.lblInfoTipo.Text = "Analizo que predomina en este Centro de Analisis";
            this.lblInfoTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAñoMaximo
            // 
            this.btnAñoMaximo.Location = new System.Drawing.Point(694, 199);
            this.btnAñoMaximo.Name = "btnAñoMaximo";
            this.btnAñoMaximo.Size = new System.Drawing.Size(105, 44);
            this.btnAñoMaximo.TabIndex = 13;
            this.btnAñoMaximo.Text = "Año Maximo Alcanzado";
            this.btnAñoMaximo.UseVisualStyleBackColor = true;
            this.btnAñoMaximo.Click += new System.EventHandler(this.btnAñoMaximo_Click);
            // 
            // btnAnalisisSexo
            // 
            this.btnAnalisisSexo.Location = new System.Drawing.Point(694, 64);
            this.btnAnalisisSexo.Name = "btnAnalisisSexo";
            this.btnAnalisisSexo.Size = new System.Drawing.Size(105, 26);
            this.btnAnalisisSexo.TabIndex = 14;
            this.btnAnalisisSexo.Text = "Tipo de Sexo";
            this.btnAnalisisSexo.UseVisualStyleBackColor = true;
            this.btnAnalisisSexo.Click += new System.EventHandler(this.btnAnalisisSexo_Click);
            // 
            // btnAnalisisClaseSocial
            // 
            this.btnAnalisisClaseSocial.Location = new System.Drawing.Point(694, 96);
            this.btnAnalisisClaseSocial.Name = "btnAnalisisClaseSocial";
            this.btnAnalisisClaseSocial.Size = new System.Drawing.Size(105, 38);
            this.btnAnalisisClaseSocial.TabIndex = 15;
            this.btnAnalisisClaseSocial.Text = "Tipo de Clase Social";
            this.btnAnalisisClaseSocial.UseVisualStyleBackColor = true;
            this.btnAnalisisClaseSocial.Click += new System.EventHandler(this.btnAnalisisClaseSocial_Click);
            // 
            // btnAnalisisHijos
            // 
            this.btnAnalisisHijos.Location = new System.Drawing.Point(694, 140);
            this.btnAnalisisHijos.Name = "btnAnalisisHijos";
            this.btnAnalisisHijos.Size = new System.Drawing.Size(105, 26);
            this.btnAnalisisHijos.TabIndex = 17;
            this.btnAnalisisHijos.Text = "Hijos";
            this.btnAnalisisHijos.UseVisualStyleBackColor = true;
            this.btnAnalisisHijos.Click += new System.EventHandler(this.btnAnalisisHijos_Click);
            // 
            // btnEdadMaxima
            // 
            this.btnEdadMaxima.Location = new System.Drawing.Point(694, 246);
            this.btnEdadMaxima.Name = "btnEdadMaxima";
            this.btnEdadMaxima.Size = new System.Drawing.Size(105, 43);
            this.btnEdadMaxima.TabIndex = 18;
            this.btnEdadMaxima.Text = "Edad Maxima";
            this.btnEdadMaxima.UseVisualStyleBackColor = true;
            this.btnEdadMaxima.Click += new System.EventHandler(this.btnEdadMaxima_Click);
            // 
            // btnAñoMinimo
            // 
            this.btnAñoMinimo.Location = new System.Drawing.Point(694, 294);
            this.btnAñoMinimo.Name = "btnAñoMinimo";
            this.btnAñoMinimo.Size = new System.Drawing.Size(105, 48);
            this.btnAñoMinimo.TabIndex = 19;
            this.btnAñoMinimo.Text = "Año Minimo Alcanzado";
            this.btnAñoMinimo.UseVisualStyleBackColor = true;
            this.btnAñoMinimo.Click += new System.EventHandler(this.btnAñoMinimo_Click);
            // 
            // btnEdadMinima
            // 
            this.btnEdadMinima.Location = new System.Drawing.Point(694, 345);
            this.btnEdadMinima.Name = "btnEdadMinima";
            this.btnEdadMinima.Size = new System.Drawing.Size(105, 26);
            this.btnEdadMinima.TabIndex = 20;
            this.btnEdadMinima.Text = "Edad Minima";
            this.btnEdadMinima.UseVisualStyleBackColor = true;
            this.btnEdadMinima.Click += new System.EventHandler(this.btnEdadMinima_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(671, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 48);
            this.label2.TabIndex = 21;
            this.label2.Text = "Analizo los rangos maximos y minimos de este Centro de Analisis";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPromedioEdad
            // 
            this.btnPromedioEdad.Location = new System.Drawing.Point(694, 416);
            this.btnPromedioEdad.Name = "btnPromedioEdad";
            this.btnPromedioEdad.Size = new System.Drawing.Size(105, 42);
            this.btnPromedioEdad.TabIndex = 22;
            this.btnPromedioEdad.Text = "Promedio de Edad";
            this.btnPromedioEdad.UseVisualStyleBackColor = true;
            this.btnPromedioEdad.Click += new System.EventHandler(this.btnPromedioEdad_Click);
            // 
            // btnPromedioDeAñoMaximo
            // 
            this.btnPromedioDeAñoMaximo.Location = new System.Drawing.Point(694, 460);
            this.btnPromedioDeAñoMaximo.Name = "btnPromedioDeAñoMaximo";
            this.btnPromedioDeAñoMaximo.Size = new System.Drawing.Size(105, 42);
            this.btnPromedioDeAñoMaximo.TabIndex = 23;
            this.btnPromedioDeAñoMaximo.Text = "Promedio de Año Maximo";
            this.btnPromedioDeAñoMaximo.UseVisualStyleBackColor = true;
            this.btnPromedioDeAñoMaximo.Click += new System.EventHandler(this.btnPromedioDeAñoMaximo_Click);
            // 
            // btnPromedioMujeres
            // 
            this.btnPromedioMujeres.Location = new System.Drawing.Point(694, 547);
            this.btnPromedioMujeres.Name = "btnPromedioMujeres";
            this.btnPromedioMujeres.Size = new System.Drawing.Size(105, 54);
            this.btnPromedioMujeres.TabIndex = 24;
            this.btnPromedioMujeres.Text = "Porcentaje Promedio  de Sexo Femenino";
            this.btnPromedioMujeres.UseVisualStyleBackColor = true;
            this.btnPromedioMujeres.Click += new System.EventHandler(this.btnPromedioMujeres_Click);
            // 
            // btnPromedioClaseSocial
            // 
            this.btnPromedioClaseSocial.Location = new System.Drawing.Point(694, 607);
            this.btnPromedioClaseSocial.Name = "btnPromedioClaseSocial";
            this.btnPromedioClaseSocial.Size = new System.Drawing.Size(105, 54);
            this.btnPromedioClaseSocial.TabIndex = 25;
            this.btnPromedioClaseSocial.Text = "Porcentaje Promedio de Clase Social Baja";
            this.btnPromedioClaseSocial.UseVisualStyleBackColor = true;
            this.btnPromedioClaseSocial.Click += new System.EventHandler(this.btnPromedioClaseSocial_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(672, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 39);
            this.label3.TabIndex = 26;
            this.label3.Text = "Analizo los promedios de este Centro de Analisis";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(657, 663);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 39);
            this.label8.TabIndex = 44;
            this.label8.Text = "Analizo los porcentajes promedios de este Centro de Analisis";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMostrarPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 707);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPromedioClaseSocial);
            this.Controls.Add(this.btnPromedioMujeres);
            this.Controls.Add(this.btnPromedioDeAñoMaximo);
            this.Controls.Add(this.btnPromedioEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEdadMinima);
            this.Controls.Add(this.btnAñoMinimo);
            this.Controls.Add(this.btnEdadMaxima);
            this.Controls.Add(this.btnAnalisisHijos);
            this.Controls.Add(this.btnAnalisisClaseSocial);
            this.Controls.Add(this.btnAnalisisSexo);
            this.Controls.Add(this.btnAñoMaximo);
            this.Controls.Add(this.lblInfoTipo);
            this.Controls.Add(this.lblAnalisis);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClaseSocial);
            this.Controls.Add(this.lblTipoDeSexo);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.lblTipoDePersona);
            this.Controls.Add(this.rtbMostrar);
            this.Controls.Add(this.cmbTipoPersona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMostrarPersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Personas y Analizarlas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoPersona;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.Label lblTipoDePersona;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblTipoDeSexo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClaseSocial;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblAnalisis;
        private System.Windows.Forms.Label lblInfoTipo;
        private System.Windows.Forms.Button btnAñoMaximo;
        private System.Windows.Forms.Button btnAnalisisSexo;
        private System.Windows.Forms.Button btnAnalisisClaseSocial;
        private System.Windows.Forms.Button btnAnalisisHijos;
        private System.Windows.Forms.Button btnEdadMaxima;
        private System.Windows.Forms.Button btnAñoMinimo;
        private System.Windows.Forms.Button btnEdadMinima;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPromedioEdad;
        private System.Windows.Forms.Button btnPromedioDeAñoMaximo;
        private System.Windows.Forms.Button btnPromedioMujeres;
        private System.Windows.Forms.Button btnPromedioClaseSocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
    }
}