using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Pais : Form
    {
        private string text1;
        private string text2;
        protected enum Accion { Nuevo, Editar, Eliminar, Ninguno }

        Accion accionBoton;
        public Pais()
        {
            InitializeComponent();
        }

        public Pais(string text1, string text2)
        {
            this.text1 = text1;
            this.text2 = text2;
        }

        private void Pais_Load(object sender, EventArgs e)
        {
            try
            {
                InhabilitarCampos();
                ActualizarAlumnos();
            }
            catch (SqlException esql)
            {
                MessageBox.Show("Ha ocurrido un error con la Base de Datos. Favor verifique" + esql.Message + " " +
                    esql.Source);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error. " + ex.Message + " " +
                    ex.Source);
            }
        }

        private void InhabilitarCampos()
        {
            txtPais.Enabled = false;
            txtDescripcion.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtPais.Enabled = true;
            txtDescripcion.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool ban = new bool();
            ban = false;

            Pais paises = new Pais(txtPais.Text,txtDescripcion.Text);
            try
            {
                if (accionBoton == Accion.Nuevo)
                {
                    ban = Pais.AgregarPais(paises);
                    if (ban)
                    {
                        MessageBox.Show($"El pais{paises.txtPais}fue agregado");
                    }
                }

                ActualizarPaises();

            }
            catch (SqlException esql)
            {
                MessageBox.Show("Ha ocurrido un error con la Base de Datos. Favor verifique" + esql.Message + " " +
                    esql.Source);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error. " + ex.Message + " " +
                    ex.Source);
            }

            LimpiarCampos();
            InhabilitarCampos();
        }
        private void ActualizarAlumnos()
        {
            lsbPaises.DataSource = null;
            lsbPaises.DataSource = Pais.ObtenerPaisLista();
        }

        private void LimpiarCampos()
        {
            txtPais.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (accionBoton == Accion.Nuevo)
            {
                LimpiarCampos();
            }
        }

        private void lsbPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbPaises.SelectedItem != null)
            {
                var pais = new Pais();
                pais = (Pais)lsbPaises.SelectedItem;
                txtPais.Text = pais.Id.ToString();
            }
        }
    }
}
