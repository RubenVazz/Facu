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
    public partial class frmEquipos : Form
    {
        protected enum Accion { Nuevo, Editar, Eliminar, Ninguno }

        Accion accionBoton;

        public frmEquipos()
        {
            InitializeComponent();
        }
        private void frmEquipos_Load(object sender, EventArgs e)
        {
            InhabilitarCampos();
        }

        private void InhabilitarCampos()
        {
            txtIdEquipo.Enabled = false;
            txtCosto.Enabled = false;
            txtDescripcionEquipo.Enabled = false;
            txtEstadoEquipo.Enabled = false;
            txtFechaAdqEquipo.Enabled = false;
            txtMarcaEquipo.Enabled = false;
            txtPrecioEquipo.Enabled = false;
            txtSalaEquipo.Enabled = false;
        }
        private void HabilitarCampos()
        {
            txtIdEquipo.Enabled = true;
            txtCosto.Enabled = true;
            txtDescripcionEquipo.Enabled = true;
            txtEstadoEquipo.Enabled = true;
            txtFechaAdqEquipo.Enabled = true;
            txtMarcaEquipo.Enabled = true;
            txtPrecioEquipo.Enabled = true;
            txtSalaEquipo.Enabled = true;
        }

        private void btnNuevoEquipo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos();
            accionBoton = Accion.Nuevo;
        }

        private void btnGuardarEquipo_Click(object sender, EventArgs e)
        {
            bool ban = new bool();
            ban = false;

            Equipo equipo= new Equipo(txtDescripcionEquipo.Text,
                Convert.ToInt32(txtMarcaEquipo.Text),txtFechaAdqEquipo.Text,
                Convert.ToDouble(txtCosto.Text),Convert.ToInt32(txtSalaEquipo.Text),
                Convert.ToDouble(txtPrecioEquipo.Text)
                ,Convert.ToInt32(txtEstadoEquipo.Text));
            {
                if (accionBoton == Accion.Nuevo)
                {
                    ban = Equipo.AgregarEquipo(equipo);
                    if (ban)
                    {
                        MessageBox.Show($"El equipo{equipo.Descripcion}fue agregado");
                    }
                }

                ActualizarEquipos();
                LimpiarCampos();
                InhabilitarCampos();
            }
            
        }
        private void ActualizarEquipos()
        {
            lsbEquipos.DataSource = null;
            lsbEquipos.DataSource = Equipo.ObtenerEquipoLista();
        }

        private void LimpiarCampos()
        {
            txtIdEquipo.Text = "";
            txtCosto.Text = "";
            txtDescripcionEquipo.Text = "";
            txtEstadoEquipo.Text = "";
            txtFechaAdqEquipo.Text = "";
            txtMarcaEquipo.Text = "";
            txtPrecioEquipo.Text = "";
            txtSalaEquipo.Text = "";

        }
        private void btnLimpiarEquipo_Click(object sender, EventArgs e)
        {
            if (accionBoton == Accion.Nuevo)
            {
                LimpiarCampos();
            }
            else
            {
                var auxId = txtIdEquipo.Text;
                LimpiarCampos();
                txtIdEquipo.Text = auxId;

            }
        }
        private void lsbEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var equipo = new Equipo();
            equipo = (Equipo)lsbEquipos.SelectedItem;
            txtIdEquipo.Text = equipo.CodEquipo.ToString();
            txtCosto.Text= equipo.CostoGs.ToString();
            txtDescripcionEquipo.Text = equipo.Descripcion;
            txtEstadoEquipo.Text = equipo.CodEquipo.ToString();
            txtFechaAdqEquipo.Text = equipo.FechaAdq;
            txtMarcaEquipo.Text = equipo.CodMarca.ToString();
            txtPrecioEquipo.Text = equipo.Precio.ToString();
            txtSalaEquipo.Text = equipo.CodSala.ToString();
        }
        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {
            if (lsbEquipos.SelectedItem != null && txtIdEquipo.Text != "")
            {
                HabilitarCampos();
                accionBoton = Accion.Editar;
            }
        }
        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            if (lsbEquipos.SelectedItem != null && txtIdEquipo.Text != "")
            {
                short Id = Convert.ToInt16(txtIdEquipo.Text);
                Profesor.EliminarProfesor(Id);
            }
            else
            {
                MessageBox.Show("Seleccione equipo a eliminar");
            }

            ActualizarEquipos();
            LimpiarCampos();
        }
        private void btnCancelarEquipo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            InhabilitarCampos();
        }
        

        
    }
}
