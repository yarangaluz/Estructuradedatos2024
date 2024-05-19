using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        // Declaración de variable global
        Arquitecto? arquitecto;

        public Form1()
        {
            InitializeComponent();
        }

        // Evento al inicializar el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            cboCondicionContrato.SelectedIndex = 0;
            cboTipoEspecialidad.SelectedIndex = 0;
            cboTipoActividad.SelectedIndex = 0;
            cboTipoAfiliacion.SelectedIndex = 0;
        }

        // Evento al hacer clic en Crear objeto
        private void btnCrearObjeto_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombres = txtNombres.Text;
            string condicionContrato = cboCondicionContrato.Text;
            string tipoEspecialidad = cboTipoEspecialidad.Text;
            string tipoActividad = cboTipoActividad.Text;
            string tipoAfiliacion = cboTipoAfiliacion.Text;

            arquitecto = new Arquitecto(codigo, nombres, condicionContrato, tipoEspecialidad, tipoActividad, tipoAfiliacion);
            MessageBox.Show("Objeto Creado");
        }

        // Evento Mostrar
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (arquitecto != null)
            {
                txtResultado.AppendText("Objeto Nro: " + Arquitecto.GetContador().ToString() + Environment.NewLine);
                txtResultado.AppendText("Codigo: " + arquitecto.Codigo + Environment.NewLine);
                txtResultado.AppendText("Nombres: " + arquitecto.Nombres + Environment.NewLine);
                txtResultado.AppendText("Condición de Contrato: " + arquitecto.CondicionContrato + Environment.NewLine);
                txtResultado.AppendText("Especialidad: " + arquitecto.TipoEspecialidad + Environment.NewLine);
                txtResultado.AppendText("Tipo de Actividad: " + arquitecto.TipoActividad + Environment.NewLine);
                txtResultado.AppendText("Tipo de Afiliación: " + arquitecto.TipoAfiliacion + Environment.NewLine);

                // Calcular los valores requeridos
                decimal sueldoBase = arquitecto.CalcularSueldoBase();
                decimal bonificacion = arquitecto.CalcularBonificacion();
                decimal descuentos = arquitecto.CalcularDescuentos();
                decimal sueldoBruto = arquitecto.CalcularSueldoBruto();
                decimal sueldoNeto = arquitecto.CalcularSueldoNeto();

                // Mostrar los resultados en el cuadro de texto
                txtResultado.AppendText($"Sueldo Base: {sueldoBase:C}\r\n");
                txtResultado.AppendText($"Bonificación: {bonificacion:C}\r\n");
                txtResultado.AppendText($"Descuentos: {descuentos:C}\r\n");
                txtResultado.AppendText($"Sueldo Bruto: {sueldoBruto:C}\r\n");
                txtResultado.AppendText($"Sueldo Neto: {sueldoNeto:C}\r\n");
            }
            else
            {
                MessageBox.Show("El objeto arquitecto no ha sido creado.");
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
            txtCodigo.Text = string.Empty;
            txtNombres.Clear();
            txtResultado.Clear();
            cboCondicionContrato.SelectedIndex = 0;
            cboTipoEspecialidad.SelectedIndex = 0;
            cboTipoActividad.SelectedIndex = 0;
            cboTipoAfiliacion.SelectedIndex = 0;
            txtCodigo.Focus();
        }
    }
}