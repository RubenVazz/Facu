using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TP1;

namespace Interfaz
{
    public partial class frmAlumno : Form
    {
        protected enum Accion { Nuevo, Editar, Eliminar, Ninguno }

        Accion accionBoton;
        public frmAlumno()
        {
            InitializeComponent();
        }
        private void frmProfesor_Load(object sender, EventArgs e)
        {
            InhabilitarCampos();
        }

        private void InhabilitarCampos()
        {
            txtIdAlumno.Enabled = false;
            txtNobreAlumno.Enabled = false;
            txtApellidoAlumno.Enabled = false;
            txtCiAlumno.Enabled = false;
            txtCelularAlumno.Enabled = false;
            txtCelularAlumno.Enabled = false;
            txtDireccionAlumno.Enabled = false;
            txtFechaIngresoAlumno.Enabled = false;
            txtFechaNacimientoAlumno.Enabled = false;
            txtPorcentajeDescuentoAlumno.Enabled = false;
            txtRucAlumno.Enabled = false;
            txtFechaUltimoPagoAlumno.Enabled = false;
            txtFechaIngresoAlumno.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtIdAlumno.Enabled = true;
            txtNobreAlumno.Enabled = true;
            txtApellidoAlumno.Enabled = true;
            txtCiAlumno.Enabled = true;
            txtCelularAlumno.Enabled = true;
            txtCelularAlumno.Enabled = true;
            txtDireccionAlumno.Enabled = true;
            txtFechaIngresoAlumno.Enabled = true;
            txtFechaNacimientoAlumno.Enabled = true;
            txtPorcentajeDescuentoAlumno.Enabled = true;
            txtRucAlumno.Enabled = true;
            txtFechaUltimoPagoAlumno.Enabled = true;
            txtFechaIngresoAlumno.Enabled = true;
        }

        private void btnNuevoProfesor_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos();
            accionBoton = Accion.Nuevo;
        }

        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            bool ban = new bool();
            ban = false;

            Alumno alumnos = new Alumno(txtCiAlumno.Text, 
                txtNacionalidadAlumno.Text, 
                txtFechaNacimientoAlumno.Text, 
                txtNobreAlumno.Text, txtApellidoAlumno.Text, 
                txtDireccionAlumno.Text, txtRucAlumno.Text, 
                txtCorreoAlumno.Text, txtCelularAlumno.Text, 
                txtFechaIngresoAlumno.Text, txtPorcentajeDescuentoAlumno.Text,"");
            {
                if (accionBoton == Accion.Nuevo)
                {
                    ban = Alumno.AgregarAlumno(alumnos);
                    if (ban)
                    {
                        MessageBox.Show($"El alumno{alumnos.Nombre}fue agregado");
                    }
                }

                ActualizarAlumnos();
                LimpiarCampos();
                InhabilitarCampos();
            }

        }
        private void ActualizarAlumnos()
        {
            lsbAlumnos.DataSource = null;
            lsbAlumnos.DataSource = Alumno.ObtenerAlumnoLista();
        }
        private void LimpiarCampos()
        {
            txtNobreAlumno.Text = "";
            txtApellidoAlumno.Text = "";
            txtCelularAlumno.Text = "";
            txtCiAlumno.Text = "";
            txtCorreoAlumno.Text = "";
            txtDireccionAlumno.Text = "";
            txtFechaIngresoAlumno.Text = "";
            txtFechaNacimientoAlumno.Text = "";
            txtNacionalidadAlumno.Text = "";
            txtPorcentajeDescuentoAlumno.Text = "";
            txtFechaUltimoPagoAlumno.Text = "";
            
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (accionBoton == Accion.Nuevo)
            {
                LimpiarCampos();
            }
            else
            {
                var auxId = txtIdAlumno.Text;
                LimpiarCampos();
                txtIdAlumno.Text = auxId;

            }
        }

        private void lsbProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbAlumnos.SelectedItem != null)
            {
                var alumno = new Alumno();
                alumno = (Alumno)lsbAlumnos.SelectedItem;
                txtIdAlumno.Text = alumno.Id.ToString();
                txtCiAlumno.Text = alumno.NroDocumento;
                txtNacionalidadAlumno.Text = alumno.CodNacionalidad;
                txtFechaNacimientoAlumno.Text = alumno.FechaNacimiento;
                txtNobreAlumno.Text = alumno.Nombre;
                txtApellidoAlumno.Text = alumno.Apellido;
                txtDireccionAlumno.Text = alumno.Direccion;
                txtRucAlumno.Text = alumno.RUC;
                txtCorreoAlumno.Text = alumno.Correo;
                txtCelularAlumno.Text = alumno.Celular;
                txtFechaIngresoAlumno.Text = alumno.FechaIngreso;
                txtPorcentajeDescuentoAlumno.Text = alumno.PorcentajeDesc;
                txtFechaUltimoPagoAlumno.Text = alumno.FechaUltimoPago;
            }


        }
        private void btnEditarAlumno_Click(object sender, EventArgs e)
        {
            if (lsbAlumnos.SelectedItem != null && txtIdAlumno.Text != "")
            {
                HabilitarCampos();
                accionBoton = Accion.Editar;
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (lsbAlumnos.SelectedItem != null && txtIdAlumno.Text != "")
            {
                short Id = Convert.ToInt16(txtIdAlumno.Text);
                Profesor.EliminarProfesor(Id);
            }
            else
            {
                MessageBox.Show("Seleccione profesor a eliminar");
            }

            ActualizarAlumnos();
            LimpiarCampos();
        }
        private void btnCancelarAlumno_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            InhabilitarCampos();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoAlumno_Click(object sender, EventArgs e)
        {

        }
    }
}
