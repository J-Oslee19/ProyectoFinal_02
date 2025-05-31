using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal_02
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSintomas;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.ComboBox cmbMunicipios;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblSintomas;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbMunicipios = new System.Windows.Forms.ComboBox();
            this.Centros_De_Salud_Cercanos = new System.Windows.Forms.ListBox();
            this.txtSintomas = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.btnConsejos = new System.Windows.Forms.Button();
            this.________________________Listado_Consejos________________________ = new System.Windows.Forms.ListBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.btnConsejosPersonalizados = new System.Windows.Forms.Button();
            this.rtbConsejos = new System.Windows.Forms.RichTextBox();
            this.lblTituloEdu = new System.Windows.Forms.Label();
            this.txtPreguntaSalud = new System.Windows.Forms.TextBox();
            this.btnConsultarIA = new System.Windows.Forms.Button();
            this.richTextBoxRespuestaSalud = new System.Windows.Forms.RichTextBox();
            this.btnExportarPDF = new System.Windows.Forms.Button();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblSintomas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Red;
            this.btnLimpiar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.Location = new System.Drawing.Point(734, 712);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cmbMunicipios
            // 
            this.cmbMunicipios.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbMunicipios.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.cmbMunicipios.Items.AddRange(new object[] {
            "Selecciona un Municipio",
            "Jutiapa",
            "El Progreso",
            "Santa Catarina Mita",
            "Moyuta",
            "Zapotitlán",
            "Yupiltepeque",
            "Quesada"});
            this.cmbMunicipios.Location = new System.Drawing.Point(21, 545);
            this.cmbMunicipios.Name = "cmbMunicipios";
            this.cmbMunicipios.Size = new System.Drawing.Size(175, 27);
            this.cmbMunicipios.TabIndex = 1;
            this.cmbMunicipios.SelectedIndexChanged += new System.EventHandler(this.cmbMunicipios_SelectedIndexChanged);
            // 
            // Centros_De_Salud_Cercanos
            // 
            this.Centros_De_Salud_Cercanos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Centros_De_Salud_Cercanos.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.Centros_De_Salud_Cercanos.ForeColor = System.Drawing.Color.Black;
            this.Centros_De_Salud_Cercanos.ItemHeight = 19;
            this.Centros_De_Salud_Cercanos.Location = new System.Drawing.Point(202, 545);
            this.Centros_De_Salud_Cercanos.Name = "Centros_De_Salud_Cercanos";
            this.Centros_De_Salud_Cercanos.Size = new System.Drawing.Size(258, 42);
            this.Centros_De_Salud_Cercanos.TabIndex = 2;
            // 
            // txtSintomas
            // 
            this.txtSintomas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSintomas.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSintomas.Location = new System.Drawing.Point(21, 293);
            this.txtSintomas.Multiline = true;
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(412, 22);
            this.txtSintomas.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEnviar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(21, 333);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(412, 30);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = " ⬆️ Enviar síntomas a IA";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtRespuesta.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta.ForeColor = System.Drawing.Color.White;
            this.txtRespuesta.Location = new System.Drawing.Point(21, 378);
            this.txtRespuesta.Multiline = true;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.ReadOnly = true;
            this.txtRespuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRespuesta.Size = new System.Drawing.Size(412, 150);
            this.txtRespuesta.TabIndex = 3;
            this.txtRespuesta.Text = resources.GetString("txtRespuesta.Text");
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.Black;
            this.Titulo.Location = new System.Drawing.Point(454, 30);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(787, 68);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "​🩺​SaludBot Jutiapa con IA🤖​";
            // 
            // btnConsejos
            // 
            this.btnConsejos.BackColor = System.Drawing.Color.YellowGreen;
            this.btnConsejos.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsejos.Location = new System.Drawing.Point(585, 154);
            this.btnConsejos.Name = "btnConsejos";
            this.btnConsejos.Size = new System.Drawing.Size(402, 44);
            this.btnConsejos.TabIndex = 0;
            this.btnConsejos.Text = "🚑Ver Consejos de Primeros Auxilios";
            this.btnConsejos.UseVisualStyleBackColor = false;
            this.btnConsejos.Click += new System.EventHandler(this.btnConsejos_Click);
            // 
            // ________________________Listado_Consejos________________________
            // 
            this.________________________Listado_Consejos________________________.AccessibleDescription = "_____________";
            this.________________________Listado_Consejos________________________.BackColor = System.Drawing.SystemColors.InfoText;
            this.________________________Listado_Consejos________________________.Cursor = System.Windows.Forms.Cursors.Default;
            this.________________________Listado_Consejos________________________.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.________________________Listado_Consejos________________________.ForeColor = System.Drawing.Color.White;
            this.________________________Listado_Consejos________________________.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.________________________Listado_Consejos________________________.ItemHeight = 19;
            this.________________________Listado_Consejos________________________.Location = new System.Drawing.Point(495, 276);
            this.________________________Listado_Consejos________________________.Name = "________________________Listado_Consejos________________________";
            this.________________________Listado_Consejos________________________.Size = new System.Drawing.Size(563, 118);
            this.________________________Listado_Consejos________________________.TabIndex = 1;
            this.________________________Listado_Consejos________________________.SelectedIndexChanged += new System.EventHandler(this.lstConsejos_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1335, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(196, 177);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // lblEdad
            // 
            this.lblEdad.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEdad.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lblEdad.Location = new System.Drawing.Point(580, 419);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(53, 24);
            this.lblEdad.TabIndex = 0;
            this.lblEdad.Text = "Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtEdad.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(566, 460);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(77, 27);
            this.txtEdad.TabIndex = 1;
            // 
            // cmbGenero
            // 
            this.cmbGenero.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(881, 460);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(120, 27);
            this.cmbGenero.TabIndex = 2;
            // 
            // btnConsejosPersonalizados
            // 
            this.btnConsejosPersonalizados.BackColor = System.Drawing.Color.YellowGreen;
            this.btnConsejosPersonalizados.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnConsejosPersonalizados.Location = new System.Drawing.Point(695, 496);
            this.btnConsejosPersonalizados.Name = "btnConsejosPersonalizados";
            this.btnConsejosPersonalizados.Size = new System.Drawing.Size(186, 33);
            this.btnConsejosPersonalizados.TabIndex = 3;
            this.btnConsejosPersonalizados.Text = "Obtener Consejos";
            this.btnConsejosPersonalizados.UseVisualStyleBackColor = false;
            this.btnConsejosPersonalizados.Click += new System.EventHandler(this.btnConsejosPersonalizados_Click);
            // 
            // rtbConsejos
            // 
            this.rtbConsejos.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtbConsejos.ForeColor = System.Drawing.Color.White;
            this.rtbConsejos.Location = new System.Drawing.Point(495, 545);
            this.rtbConsejos.Name = "rtbConsejos";
            this.rtbConsejos.ReadOnly = true;
            this.rtbConsejos.Size = new System.Drawing.Size(563, 150);
            this.rtbConsejos.TabIndex = 4;
            this.rtbConsejos.Text = "";
            // 
            // lblTituloEdu
            // 
            this.lblTituloEdu.AutoSize = true;
            this.lblTituloEdu.BackColor = System.Drawing.Color.White;
            this.lblTituloEdu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEdu.ForeColor = System.Drawing.Color.Black;
            this.lblTituloEdu.Location = new System.Drawing.Point(1141, 258);
            this.lblTituloEdu.Name = "lblTituloEdu";
            this.lblTituloEdu.Size = new System.Drawing.Size(430, 35);
            this.lblTituloEdu.TabIndex = 0;
            this.lblTituloEdu.Text = "Educación Médica Personalizada";
            // 
            // txtPreguntaSalud
            // 
            this.txtPreguntaSalud.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtPreguntaSalud.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreguntaSalud.Location = new System.Drawing.Point(1136, 296);
            this.txtPreguntaSalud.Name = "txtPreguntaSalud";
            this.txtPreguntaSalud.Size = new System.Drawing.Size(368, 27);
            this.txtPreguntaSalud.TabIndex = 1;
            // 
            // btnConsultarIA
            // 
            this.btnConsultarIA.BackColor = System.Drawing.Color.YellowGreen;
            this.btnConsultarIA.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarIA.Location = new System.Drawing.Point(1209, 334);
            this.btnConsultarIA.Name = "btnConsultarIA";
            this.btnConsultarIA.Size = new System.Drawing.Size(233, 30);
            this.btnConsultarIA.TabIndex = 2;
            this.btnConsultarIA.Text = "Quiero aprender sobre salud";
            this.btnConsultarIA.UseVisualStyleBackColor = false;
            this.btnConsultarIA.Click += new System.EventHandler(this.btnConsultarIA_Click_1);
            // 
            // richTextBoxRespuestaSalud
            // 
            this.richTextBoxRespuestaSalud.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBoxRespuestaSalud.ForeColor = System.Drawing.Color.White;
            this.richTextBoxRespuestaSalud.Location = new System.Drawing.Point(1136, 378);
            this.richTextBoxRespuestaSalud.Name = "richTextBoxRespuestaSalud";
            this.richTextBoxRespuestaSalud.Size = new System.Drawing.Size(368, 178);
            this.richTextBoxRespuestaSalud.TabIndex = 3;
            this.richTextBoxRespuestaSalud.Text = "";
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExportarPDF.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportarPDF.Location = new System.Drawing.Point(1232, 582);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Size = new System.Drawing.Size(210, 30);
            this.btnExportarPDF.TabIndex = 4;
            this.btnExportarPDF.Text = "Exportar respuesta a PDF";
            this.btnExportarPDF.UseVisualStyleBackColor = false;
            this.btnExportarPDF.Click += new System.EventHandler(this.btnExportarPDF_Click_1);
            // 
            // lblGenero
            // 
            this.lblGenero.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblGenero.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lblGenero.Location = new System.Drawing.Point(902, 419);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(72, 24);
            this.lblGenero.TabIndex = 1;
            this.lblGenero.Text = "Género:";
            // 
            // lblSintomas
            // 
            this.lblSintomas.AutoSize = true;
            this.lblSintomas.BackColor = System.Drawing.Color.White;
            this.lblSintomas.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSintomas.ForeColor = System.Drawing.Color.Black;
            this.lblSintomas.Location = new System.Drawing.Point(196, 258);
            this.lblSintomas.Name = "lblSintomas";
            this.lblSintomas.Size = new System.Drawing.Size(124, 32);
            this.lblSintomas.TabIndex = 1;
            this.lblSintomas.Text = "Síntomas";
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1840, 754);
            this.Controls.Add(this.lblSintomas);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblTituloEdu);
            this.Controls.Add(this.txtPreguntaSalud);
            this.Controls.Add(this.btnConsultarIA);
            this.Controls.Add(this.richTextBoxRespuestaSalud);
            this.Controls.Add(this.btnExportarPDF);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.btnConsejosPersonalizados);
            this.Controls.Add(this.rtbConsejos);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbMunicipios);
            this.Controls.Add(this.Centros_De_Salud_Cercanos);
            this.Controls.Add(this.btnConsejos);
            this.Controls.Add(this.________________________Listado_Consejos________________________);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.txtSintomas);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtRespuesta);
            this.Name = "Form1";
            this.Text = "SaludBot Jutiapa - Asistente de IA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.ListBox Centros_De_Salud_Cercanos;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Label lblEdad;
        private Label lblTituloEdu;
        private TextBox txtPreguntaSalud;
        private Button btnConsultarIA;
        private RichTextBox richTextBoxRespuestaSalud;
        private Button btnExportarPDF;
    }
}
