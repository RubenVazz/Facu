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
    public partial class frmProfesor : Form
    {

        protected enum Accion {Nuevo,Editar,Eliminar,Ninguno }

        Accion accionBoton;
        public frmProfesor()
        {
            InitializeComponent();
        }

        private void frmProfesor_Load(object sender, EventArgs e)
        {
            InhabilitarCampos();
        }

        private void InhabilitarCampos()
        {
            txtIdProfesor.Enabled = false;
            txtNombreProfesor.Enabled = false;
            txtApellidoProfesor.Enabled = false;
            txtCiProfesor.Enabled = false;
            txtCelularProfesor.Enabled = false;
            txtCorreoProfesor.Enabled = false;
            txtDireccionProfesor.Enabled = false;
            txtFechaIngresoProfesor.Enabled = false;
            txtFechaNacimientoProfesor.Enabled = false;
            txtPorcentajeDescuentoProfesor.Enabled = false;
            txtRenovacionProfesor.Enabled = false;
            txtRucProfesor.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtIdProfesor.Enabled = true;
            txtNombreProfesor.Enabled = true;
            txtApellidoProfesor.Enabled = true;
            txtCiProfesor.Enabled = true;
            txtCelularProfesor.Enabled = true;
            txtCorreoProfesor.Enabled = true;
            txtDireccionProfesor.Enabled = true;
            txtFechaIngresoProfesor.Enabled = true;
            txtFechaNacimientoProfesor.Enabled = true;
            txtPorcentajeDescuentoProfesor.Enabled = true;
            txtRenovacionProfesor.Enabled = true;
            txtRucProfesor.Enabled = true;

        }

        private void btnNuevoProfesor_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos();
            accionBoton = Accion.Nuevo;
        }

        private void btnGuardarProfesor_Click(object sender, EventArgs e)
        {
            bool ban = new bool();
            ban = false;

            Profesor profesores = new Profesor(txtCiProfesor.Text,txtNacionalidadProfesor.Text,txtFechaNacimientoProfesor.Text,txtNombreProfesor.Text,txtApellidoProfesor.Text,txtDireccionProfesor.Text,txtRucProfesor.Text,txtCorreoProfesor.Text,txtCelularProfesor.Text,txtFechaIngresoProfesor.Text,txtPorcentajeDescuentoProfesor.Text);
            {
                if (accionBoton == Accion.Nuevo)
                {
                    ban = Profesor.AgregarProfesor(profesores);
                    if (ban)
                    {
                        MessageBox.Show($"El profesor{profesores.Nombre}fue agregado");
                    }
                }

                ActualizarProfesores();
                LimpiarCampos();
                InhabilitarCampos();
            }
            
        }

        private void ActualizarProfesores()
        {
            lsbProfesor.DataSource = null;
            lsbProfesor.DataSource = Profesor.ObtenerProfesorLista();
        }

        private void LimpiarCampos()
        {
            txtNombreProfesor.Text = "";
            txtApellidoProfesor.Text = "";
            txtCelularProfesor.Text = "";
            txtCiProfesor.Text = "";
            txtCorreoProfesor.Text = "";
            txtDireccionProfesor.Text = "";
            txtFechaIngresoProfesor.Text = "";
            txtFechaNacimientoProfesor.Text = "";
            txtNacionalidadProfesor.Text = "";
            txtPorcentajeDescuentoProfesor.Text = "";
            txtRenovacionProfesor.Text = "";
            txtRucProfesor.Text = "";
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (accionBoton == Accion.Nuevo)
            {
                LimpiarCampos();
            }
            else
            {
                var auxId = txtIdProfesor.Text;
                LimpiarCampos();
                txtIdProfesor.Text = auxId;

            }
        }

        private void lsbProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbProfesor.SelectedItem != null)
            {
                var profesor = new Profesor();
                profesor = (Profesor)lsbProfesor.SelectedItem;
                txtIdProfesor.Text = profesor.Id.ToString();
                txtCiProfesor.Text = profesor.NroDocumento;
                txtNacionalidadProfesor.Text = profesor.CodNacionalidad;
                txtFechaNacimientoProfesor.Text = profesor.FechaNacimiento;
                txtNombreProfesor.Text = profesor.Nombre;
                txtApellidoProfesor.Text = profesor.Apellido;
                txtDireccionProfesor.Text = profesor.Direccion;
                txtRucProfesor.Text = profesor.RUC;
                txtCorreoProfesor.Text = profesor.Correo;
                txtCelularProfesor.Text = profesor.Celular;
                txtFechaIngresoProfesor.Text = profesor.FechaIngFacultad;
                txtPorcentajeDescuentoProfesor.Text = profesor.PorcentajeDesc;

            }

           
        }
        private void btnEditarProfesor_Click(object sender, EventArgs e)
        {
            if (lsbProfesor.SelectedItem != null && txtIdProfesor.Text != "")
            {
                HabilitarCampos();
                accionBoton = Accion.Editar;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lsbProfesor.SelectedItem != null && txtIdProfesor.Text != "")
            {
                short Id = Convert.ToInt16(txtIdProfesor.Text);
                Profesor.EliminarProfesor(Id);
            }
            else
            {
                MessageBox.Show("Seleccione profesor a eliminar");
            }

            ActualizarProfesores();
            LimpiarCampos();

        }

        private void btnCancelarProfesor_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            InhabilitarCampos();
        }
        private void lblCelularProfesor_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreProfesor_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
