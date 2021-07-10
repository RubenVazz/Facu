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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        
        //CLick

        private void alumnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAlumno formularioAlumno = new frmAlumno();
            formularioAlumno.Show();
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfesor formProfesor = new frmProfesor();
            formProfesor.Show();

        }

        private void equipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEquipos formEquipos = new frmEquipos();

            formEquipos.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
