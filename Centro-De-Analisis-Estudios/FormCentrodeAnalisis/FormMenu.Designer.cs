
namespace FormCentrodeAnalisis
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAgregarPersona = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardarTXT = new System.Windows.Forms.Button();
            this.btnGuardarEnArchivoJson = new System.Windows.Forms.Button();
            this.btnCargarArchivoTXT = new System.Windows.Forms.Button();
            this.btnCargarBD = new System.Windows.Forms.Button();
            this.TimerTiempoTranscurrido = new System.Windows.Forms.Timer(this.components);
            this.btnCargarPersonasBD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarPersona
            // 
            this.btnAgregarPersona.Location = new System.Drawing.Point(40, 12);
            this.btnAgregarPersona.Name = "btnAgregarPersona";
            this.btnAgregarPersona.Size = new System.Drawing.Size(230, 54);
            this.btnAgregarPersona.TabIndex = 0;
            this.btnAgregarPersona.Text = "Agregar Abandonador";
            this.btnAgregarPersona.UseVisualStyleBackColor = true;
            this.btnAgregarPersona.Click += new System.EventHandler(this.btnAgregarPersona_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(40, 132);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(230, 54);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar Abandonadores";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(40, 72);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(230, 54);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar Abandonador";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardarTXT
            // 
            this.btnGuardarTXT.Location = new System.Drawing.Point(40, 192);
            this.btnGuardarTXT.Name = "btnGuardarTXT";
            this.btnGuardarTXT.Size = new System.Drawing.Size(230, 54);
            this.btnGuardarTXT.TabIndex = 4;
            this.btnGuardarTXT.Text = "Guardar en un archivo .TXT";
            this.btnGuardarTXT.UseVisualStyleBackColor = true;
            this.btnGuardarTXT.Click += new System.EventHandler(this.btnGuardarTXT_Click);
            // 
            // btnGuardarEnArchivoJson
            // 
            this.btnGuardarEnArchivoJson.Location = new System.Drawing.Point(40, 312);
            this.btnGuardarEnArchivoJson.Name = "btnGuardarEnArchivoJson";
            this.btnGuardarEnArchivoJson.Size = new System.Drawing.Size(230, 54);
            this.btnGuardarEnArchivoJson.TabIndex = 5;
            this.btnGuardarEnArchivoJson.Text = "Guardar en un archivo .Json";
            this.btnGuardarEnArchivoJson.UseVisualStyleBackColor = true;
            this.btnGuardarEnArchivoJson.Click += new System.EventHandler(this.btnGuardarEnArchivoJson_Click);
            // 
            // btnCargarArchivoTXT
            // 
            this.btnCargarArchivoTXT.Location = new System.Drawing.Point(40, 252);
            this.btnCargarArchivoTXT.Name = "btnCargarArchivoTXT";
            this.btnCargarArchivoTXT.Size = new System.Drawing.Size(230, 54);
            this.btnCargarArchivoTXT.TabIndex = 6;
            this.btnCargarArchivoTXT.Text = "Cargar un archivo .TXT";
            this.btnCargarArchivoTXT.UseVisualStyleBackColor = true;
            this.btnCargarArchivoTXT.Click += new System.EventHandler(this.btnCargarArchivoTXT_Click);
            // 
            // btnCargarBD
            // 
            this.btnCargarBD.Location = new System.Drawing.Point(40, 372);
            this.btnCargarBD.Name = "btnCargarBD";
            this.btnCargarBD.Size = new System.Drawing.Size(230, 54);
            this.btnCargarBD.TabIndex = 7;
            this.btnCargarBD.Text = "Actualizar Personas en Base De Datos";
            this.btnCargarBD.UseVisualStyleBackColor = true;
            this.btnCargarBD.Click += new System.EventHandler(this.btnCargarBD_Click);
            // 
            // TimerTiempoTranscurrido
            // 
            this.TimerTiempoTranscurrido.Interval = 1000;
            this.TimerTiempoTranscurrido.Tick += new System.EventHandler(this.TimerTiempoTranscurrido_Tick);
            // 
            // btnCargarPersonasBD
            // 
            this.btnCargarPersonasBD.Location = new System.Drawing.Point(40, 432);
            this.btnCargarPersonasBD.Name = "btnCargarPersonasBD";
            this.btnCargarPersonasBD.Size = new System.Drawing.Size(230, 54);
            this.btnCargarPersonasBD.TabIndex = 8;
            this.btnCargarPersonasBD.Text = "Cargar personas desde la Base De Datos";
            this.btnCargarPersonasBD.UseVisualStyleBackColor = true;
            this.btnCargarPersonasBD.Click += new System.EventHandler(this.btnCargarPersonasBD_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 496);
            this.Controls.Add(this.btnCargarPersonasBD);
            this.Controls.Add(this.btnCargarBD);
            this.Controls.Add(this.btnCargarArchivoTXT);
            this.Controls.Add(this.btnGuardarEnArchivoJson);
            this.Controls.Add(this.btnGuardarTXT);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAgregarPersona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu del Centro de Analisis";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarPersona;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardarTXT;
        private System.Windows.Forms.Button btnGuardarEnArchivoJson;
        private System.Windows.Forms.Button btnCargarArchivoTXT;
        private System.Windows.Forms.Button btnCargarBD;
        private System.Windows.Forms.Timer TimerTiempoTranscurrido;
        private System.Windows.Forms.Button btnCargarPersonasBD;
    }
}

