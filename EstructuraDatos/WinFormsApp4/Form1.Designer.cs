namespace WinFormsApp4
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
            txtNombres = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDni = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cboCargo = new ComboBox();
            cboArea = new ComboBox();
            label5 = new Label();
            txtAñosAntiguedad = new TextBox();
            txtResultado = new RichTextBox();
            btnCrearObjeto = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(67, 49);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(450, 23);
            txtNombres.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 31);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 87);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "D.N.I.";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(67, 105);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(176, 23);
            txtDni.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(586, 31);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Cargo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(586, 87);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 6;
            label4.Text = "Area";
            // 
            // cboCargo
            // 
            cboCargo.BackColor = SystemColors.ScrollBar;
            cboCargo.FormattingEnabled = true;
            cboCargo.Items.AddRange(new object[] { "Gerente", "Subgerente" });
            cboCargo.Location = new Point(586, 49);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(142, 23);
            cboCargo.TabIndex = 8;
            // 
            // cboArea
            // 
            cboArea.BackColor = SystemColors.ScrollBar;
            cboArea.FormattingEnabled = true;
            cboArea.Items.AddRange(new object[] { "Contabilidad", "Planificacion" });
            cboArea.Location = new Point(586, 105);
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(142, 23);
            cboArea.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(348, 87);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 10;
            label5.Text = "Años de Antiguedad";
            // 
            // txtAñosAntiguedad
            // 
            txtAñosAntiguedad.Location = new Point(348, 105);
            txtAñosAntiguedad.Name = "txtAñosAntiguedad";
            txtAñosAntiguedad.Size = new Size(169, 23);
            txtAñosAntiguedad.TabIndex = 11;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(68, 147);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(660, 235);
            txtResultado.TabIndex = 12;
            txtResultado.Text = "";
            // 
            // btnCrearObjeto
            // 
            btnCrearObjeto.BackColor = SystemColors.ScrollBar;
            btnCrearObjeto.Location = new Point(66, 404);
            btnCrearObjeto.Name = "btnCrearObjeto";
            btnCrearObjeto.Size = new Size(91, 27);
            btnCrearObjeto.TabIndex = 13;
            btnCrearObjeto.Text = "Crear Objeto";
            btnCrearObjeto.UseVisualStyleBackColor = false;
            btnCrearObjeto.Click += btnCrearObjeto_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = SystemColors.ScrollBar;
            btnMostrar.Location = new Point(178, 404);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(183, 27);
            btnMostrar.TabIndex = 14;
            btnMostrar.Text = "Mostrar Informacion del Objeto";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ScrollBar;
            btnLimpiar.Location = new Point(561, 404);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(81, 27);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ScrollBar;
            btnSalir.Location = new Point(648, 404);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(80, 27);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(btnCrearObjeto);
            Controls.Add(txtResultado);
            Controls.Add(txtAñosAntiguedad);
            Controls.Add(label5);
            Controls.Add(cboArea);
            Controls.Add(cboCargo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDni);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombres);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombres;
        private Label label1;
        private Label label2;
        private TextBox txtDni;
        private Label label3;
        private Label label4;
        private ComboBox cboCargo;
        private ComboBox cboArea;
        private Label label5;
        private TextBox txtAñosAntiguedad;
        private RichTextBox txtResultado;
        private Button btnCrearObjeto;
        private Button btnMostrar;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
