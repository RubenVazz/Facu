using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using TP1;

namespace Interfaz
{
    public partial class frmAcceso : Form
    {
        public frmAcceso()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (Usuario.ValidarUsuario(txtUsuario.Text.Trim(),txtContraseña.Text))
            {
                this.Hide();
                frmMenu formularioMenu = new frmMenu();
                formularioMenu.ShowDialog();
                this.Close
            }
            else
            {
                MessageBox.Show("El usuario ingresado no es valido,por favor verifique");
                txtUsuario.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
