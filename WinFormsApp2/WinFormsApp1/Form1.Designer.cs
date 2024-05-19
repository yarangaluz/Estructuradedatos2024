namespace WinFormsApp1
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
            txtCodigo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtSueldo = new TextBox();
            label4 = new Label();
            txtHorasExtras = new TextBox();
            label5 = new Label();
            cboTipoSeguro = new ComboBox();
            label6 = new Label();
            cboArea = new ComboBox();
            btnCrearObjeto = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            txtResultado = new RichTextBox();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(76, 67);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(118, 23);
            txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 49);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 50);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(264, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(273, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 109);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Sueldo";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(76, 131);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(118, 23);
            txtSueldo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 109);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 6;
            label4.Text = "Horas Extras";
            // 
            // txtHorasExtras
            // 
            txtHorasExtras.Location = new Point(264, 131);
            txtHorasExtras.Name = "txtHorasExtras";
            txtHorasExtras.Size = new Size(137, 23);
            txtHorasExtras.TabIndex = 7;
            txtHorasExtras.TextChanged += txtHorasExtras_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(587, 49);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 8;
            label5.Text = "Tipo Seguro";
            // 
            // cboTipoSeguro
            // 
            cboTipoSeguro.BackColor = SystemColors.ActiveBorder;
            cboTipoSeguro.Font = new Font("Segoe UI", 9F);
            cboTipoSeguro.FormattingEnabled = true;
            cboTipoSeguro.Items.AddRange(new object[] { "AFP", "SNP" });
            cboTipoSeguro.Location = new Point(587, 67);
            cboTipoSeguro.Name = "cboTipoSeguro";
            cboTipoSeguro.Size = new Size(125, 23);
            cboTipoSeguro.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(587, 113);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 11;
            label6.Text = "Area";
            // 
            // cboArea
            // 
            cboArea.BackColor = SystemColors.ActiveBorder;
            cboArea.FormattingEnabled = true;
            cboArea.Items.AddRange(new object[] { "Administracion" });
            cboArea.Location = new Point(587, 131);
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(117, 23);
            cboArea.TabIndex = 12;
            // 
            // btnCrearObjeto
            // 
            btnCrearObjeto.BackColor = SystemColors.ActiveBorder;
            btnCrearObjeto.Location = new Point(76, 389);
            btnCrearObjeto.Name = "btnCrearObjeto";
            btnCrearObjeto.Size = new Size(108, 28);
            btnCrearObjeto.TabIndex = 13;
            btnCrearObjeto.Text = "Crear Objeto";
            btnCrearObjeto.UseVisualStyleBackColor = false;
            btnCrearObjeto.Click += new EventHandler(this.btnCrearObjeto_Click);
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = SystemColors.ActiveBorder;
            btnMostrar.Location = new Point(199, 389);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(202, 28);
            btnMostrar.TabIndex = 14;
            btnMostrar.Text = "Mostrar Informacion del Objeto";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += new EventHandler(this.btnMostrar_Click);
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ActiveBorder;
            btnLimpiar.Location = new Point(545, 389);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(82, 26);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ActiveBorder;
            btnSalir.Location = new Point(633, 389);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(67, 26);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += new EventHandler(this.btnSalir_Click);
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(76, 172);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(628, 199);
            txtResultado.TabIndex = 17;
            txtResultado.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultado);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(btnCrearObjeto);
            Controls.Add(cboArea);
            Controls.Add(label6);
            Controls.Add(cboTipoSeguro);
            Controls.Add(label5);
            Controls.Add(txtHorasExtras);
            Controls.Add(label4);
            Controls.Add(txtSueldo);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCodigo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtSueldo;
        private Label label4;
        private TextBox txtHorasExtras;
        private Label label5;
        private ComboBox cboTipoSeguro;
        private Label label6;
        private ComboBox cboArea;
        private Button btnCrearObjeto;
        private Button btnMostrar;
        private Button btnLimpiar;
        private Button btnSalir;
        private RichTextBox txtResultado;
    }
}
