using System;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        //Declaracion de variable global
        Jefe? jefe;
        public Form1()
        {
            InitializeComponent();
        }

        // Evento al inicializar el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            cboCargo.SelectedIndex = 0;
            cboArea.SelectedIndex = 0;

        }

        //Evento al hacer clic en Crear objeto
        private void btnCrearObjeto_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            string dni = txtDni.Text;
            string cargo = cboCargo.Text;
            string area = cboArea.Text;
            decimal añosAntiguedad =decimal.Parse(txtAñosAntiguedad.Text);

            jefe = new Jefe(nombres, dni, cargo, area, añosAntiguedad);
            MessageBox.Show("Objeto Creado");

        }

        //Evento Mostrar
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (jefe != null)
            {
                txtResultado.AppendText("Nombres: " + jefe.Nombres + Environment.NewLine);
                txtResultado.AppendText("D.N.I.: " + jefe.Dni + Environment.NewLine);
                txtResultado.AppendText("Cargo: " + jefe.Cargo + Environment.NewLine);
                txtResultado.AppendText("Area: " + jefe.Area + Environment.NewLine);
                txtResultado.AppendText("Años de Antiguedad: " + jefe.AñosAntiguedad + Environment.NewLine);

                // Calcular los valores requeridos
                decimal sueldoBase = jefe.CalcularSueldoBase();
                decimal bonificacion = jefe.CalcularBonificacion();
                decimal montoMovilidad = jefe.CalcularMontoMovilidad();
                decimal sueldoFinal = jefe.CalcularSueldoFinal();

                // Mostrar los resultados en el cuadro de texto
                txtResultado.AppendText($"Sueldo Base: {sueldoBase:C}\r\n");
                txtResultado.AppendText($"Bonificación: {bonificacion:C}\r\n");
                txtResultado.AppendText($"Monto Movilidad: {montoMovilidad:C}\r\n");
                txtResultado.AppendText($"Sueldo Final: {sueldoFinal:C}\r\n");
            }
            else
            {
                MessageBox.Show("El objeto jefe no ha sido creado.");
            }

        }

        // Evento Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Evento Limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombres.Clear();
            txtResultado.Clear();
            txtDni.Clear();
            txtAñosAntiguedad.Clear();
            cboCargo.SelectedIndex = 0;
            cboArea.SelectedIndex = 0;
            txtDni.Focus();
            
            
        }
    }
}
