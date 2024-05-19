namespace WinFormsApp2
{
    partial class Form1
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
            label1 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            txtNombres = new TextBox();
            label3 = new Label();
            cboCondicionContrato = new ComboBox();
            label4 = new Label();
            cboTipoEspecialidad = new ComboBox();
            label5 = new Label();
            cboTipoActividad = new ComboBox();
            label6 = new Label();
            cboTipoAfiliacion = new ComboBox();
            btnCrearObjeto = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            txtResultado = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 31);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(36, 53);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(134, 23);
            txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 31);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombres";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(228, 53);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(279, 23);
            txtNombres.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(569, 35);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 4;
            label3.Text = "Condicion de contratado";
            // 
            // cboCondicionContrato
            // 
            cboCondicionContrato.BackColor = SystemColors.ScrollBar;
            cboCondicionContrato.FormattingEnabled = true;
            cboCondicionContrato.Items.AddRange(new object[] { "Estable", "Contratado" });
            cboCondicionContrato.Location = new Point(569, 53);
            cboCondicionContrato.Name = "cboCondicionContrato";
            cboCondicionContrato.Size = new Size(160, 23);
            cboCondicionContrato.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 97);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 6;
            label4.Text = "Especialidad";
            // 
            // cboTipoEspecialidad
            // 
            cboTipoEspecialidad.BackColor = SystemColors.ScrollBar;
            cboTipoEspecialidad.FormattingEnabled = true;
            cboTipoEspecialidad.Items.AddRange(new object[] { "Estructuras", "Recursos Hidricos" });
            cboTipoEspecialidad.Location = new Point(36, 115);
            cboTipoEspecialidad.Name = "cboTipoEspecialidad";
            cboTipoEspecialidad.Size = new Size(134, 23);
            cboTipoEspecialidad.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(228, 97);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 8;
            label5.Text = "Tipo de Actividad";
            // 
            // cboTipoActividad
            // 
            cboTipoActividad.BackColor = SystemColors.ScrollBar;
            cboTipoActividad.FormattingEnabled = true;
            cboTipoActividad.Items.AddRange(new object[] { "Supervision de Obras", "Supervision de Vias" });
            cboTipoActividad.Location = new Point(228, 115);
            cboTipoActividad.Name = "cboTipoActividad";
            cboTipoActividad.Size = new Size(162, 23);
            cboTipoActividad.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(569, 97);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 10;
            label6.Text = "Tipo de Afiliacion";
            // 
            // cboTipoAfiliacion
            // 
            cboTipoAfiliacion.BackColor = SystemColors.ScrollBar;
            cboTipoAfiliacion.FormattingEnabled = true;
            cboTipoAfiliacion.Items.AddRange(new object[] { "AFP", "SNP" });
            cboTipoAfiliacion.Location = new Point(569, 115);
            cboTipoAfiliacion.Name = "cboTipoAfiliacion";
            cboTipoAfiliacion.Size = new Size(139, 23);
            cboTipoAfiliacion.TabIndex = 11;
            // 
            // btnCrearObjeto
            // 
            btnCrearObjeto.BackColor = SystemColors.ScrollBar;
            btnCrearObjeto.Location = new Point(36, 401);
            btnCrearObjeto.Name = "btnCrearObjeto";
            btnCrearObjeto.Size = new Size(112, 26);
            btnCrearObjeto.TabIndex = 12;
            btnCrearObjeto.Text = "Crear Objeto";
            btnCrearObjeto.UseVisualStyleBackColor = false;
            btnCrearObjeto.Click += btnCrearObjeto_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = SystemColors.ScrollBar;
            btnMostrar.Location = new Point(177, 402);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(208, 26);
            btnMostrar.TabIndex = 13;
            btnMostrar.Text = "Mostrar Informacion del Objeto";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ScrollBar;
            btnLimpiar.Location = new Point(575, 403);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(85, 24);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ScrollBar;
            btnSalir.Location = new Point(677, 401);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(74, 26);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(36, 158);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(715, 221);
            txtResultado.TabIndex = 16;
            txtResultado.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(830, 441);
            Controls.Add(txtResultado);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(btnCrearObjeto);
            Controls.Add(cboTipoAfiliacion);
            Controls.Add(label6);
            Controls.Add(cboTipoActividad);
            Controls.Add(label5);
            Controls.Add(cboTipoEspecialidad);
            Controls.Add(label4);
            Controls.Add(cboCondicionContrato);
            Controls.Add(label3);
            Controls.Add(txtNombres);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private TextBox txtNombres;
        private Label label3;
        private ComboBox cboCondicionContrato;
        private Label label4;
        private ComboBox cboTipoEspecialidad;
        private Label label5;
        private ComboBox cboTipoActividad;
        private Label label6;
        private ComboBox cboTipoAfiliacion;
        private Button btnCrearObjeto;
        private Button btnMostrar;
        private Button btnLimpiar;
        private Button btnSalir;
        private RichTextBox txtResultado;
    }
}
