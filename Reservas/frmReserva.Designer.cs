
namespace Reservas
{
    partial class frmReserva
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
            this.lblnroRerserva = new System.Windows.Forms.Label();
            this.lblFechaSolicitud = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblHorarioRetirio = new System.Windows.Forms.Label();
            this.lblLugarUtilizacion = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblHorarioDevolucion = new System.Windows.Forms.Label();
            this.lblHorarioReal = new System.Windows.Forms.Label();
            this.txtReserva = new System.Windows.Forms.TextBox();
            this.txtHorarioRetiro = new System.Windows.Forms.TextBox();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.txtFechaSolicitud = new System.Windows.Forms.TextBox();
            this.cboLugarUtilizacion = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblnroRerserva
            // 
            this.lblnroRerserva.AutoSize = true;
            this.lblnroRerserva.Location = new System.Drawing.Point(12, 71);
            this.lblnroRerserva.Name = "lblnroRerserva";
            this.lblnroRerserva.Size = new System.Drawing.Size(73, 15);
            this.lblnroRerserva.TabIndex = 0;
            this.lblnroRerserva.Text = "Nro. Reserva";
            // 
            // lblFechaSolicitud
            // 
            this.lblFechaSolicitud.AutoSize = true;
            this.lblFechaSolicitud.Location = new System.Drawing.Point(12, 111);
            this.lblFechaSolicitud.Name = "lblFechaSolicitud";
            this.lblFechaSolicitud.Size = new System.Drawing.Size(87, 15);
            this.lblFechaSolicitud.TabIndex = 1;
            this.lblFechaSolicitud.Text = "Fecha Solicitud";
            this.lblFechaSolicitud.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(12, 151);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(86, 15);
            this.lblFechaInicio.TabIndex = 2;
            this.lblFechaInicio.Text = "Fecha de Inicio";
            // 
            // lblHorarioRetirio
            // 
            this.lblHorarioRetirio.AutoSize = true;
            this.lblHorarioRetirio.Location = new System.Drawing.Point(12, 185);
            this.lblHorarioRetirio.Name = "lblHorarioRetirio";
            this.lblHorarioRetirio.Size = new System.Drawing.Size(97, 15);
            this.lblHorarioRetirio.TabIndex = 3;
            this.lblHorarioRetirio.Text = "Horario de Retiro";
            // 
            // lblLugarUtilizacion
            // 
            this.lblLugarUtilizacion.AutoSize = true;
            this.lblLugarUtilizacion.Location = new System.Drawing.Point(12, 216);
            this.lblLugarUtilizacion.Name = "lblLugarUtilizacion";
            this.lblLugarUtilizacion.Size = new System.Drawing.Size(111, 15);
            this.lblLugarUtilizacion.TabIndex = 4;
            this.lblLugarUtilizacion.Text = "Lugar de Utilizacion";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(268, 151);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(73, 15);
            this.lblFechaFin.TabIndex = 5;
            this.lblFechaFin.Text = "Fecha de Fin";
            // 
            // lblHorarioDevolucion
            // 
            this.lblHorarioDevolucion.AutoSize = true;
            this.lblHorarioDevolucion.Location = new System.Drawing.Point(268, 185);
            this.lblHorarioDevolucion.Name = "lblHorarioDevolucion";
            this.lblHorarioDevolucion.Size = new System.Drawing.Size(126, 15);
            this.lblHorarioDevolucion.TabIndex = 6;
            this.lblHorarioDevolucion.Text = "Horario de Devolucion";
            // 
            // lblHorarioReal
            // 
            this.lblHorarioReal.AutoSize = true;
            this.lblHorarioReal.Location = new System.Drawing.Point(268, 216);
            this.lblHorarioReal.Name = "lblHorarioReal";
            this.lblHorarioReal.Size = new System.Drawing.Size(151, 15);
            this.lblHorarioReal.TabIndex = 7;
            this.lblHorarioReal.Text = "Horario de Devolucion Real";
            // 
            // txtReserva
            // 
            this.txtReserva.Location = new System.Drawing.Point(127, 71);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.Size = new System.Drawing.Size(116, 23);
            this.txtReserva.TabIndex = 8;
            // 
            // txtHorarioRetiro
            // 
            this.txtHorarioRetiro.Location = new System.Drawing.Point(127, 182);
            this.txtHorarioRetiro.Name = "txtHorarioRetiro";
            this.txtHorarioRetiro.Size = new System.Drawing.Size(116, 23);
            this.txtHorarioRetiro.TabIndex = 9;
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(127, 148);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(116, 23);
            this.txtFechaInicio.TabIndex = 10;
            // 
            // txtFechaSolicitud
            // 
            this.txtFechaSolicitud.Location = new System.Drawing.Point(127, 111);
            this.txtFechaSolicitud.Name = "txtFechaSolicitud";
            this.txtFechaSolicitud.Size = new System.Drawing.Size(116, 23);
            this.txtFechaSolicitud.TabIndex = 11;
            // 
            // cboLugarUtilizacion
            // 
            this.cboLugarUtilizacion.FormattingEnabled = true;
            this.cboLugarUtilizacion.Location = new System.Drawing.Point(127, 213);
            this.cboLugarUtilizacion.Name = "cboLugarUtilizacion";
            this.cboLugarUtilizacion.Size = new System.Drawing.Size(116, 23);
            this.cboLugarUtilizacion.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(425, 213);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 23);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(425, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 23);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(425, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 23);
            this.textBox3.TabIndex = 15;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(706, 71);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(82, 27);
            this.btnGrabar.TabIndex = 16;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(706, 151);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 27);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(706, 111);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(82, 27);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(601, 262);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(68, 15);
            this.lblPrecio.TabIndex = 19;
            this.lblPrecio.Text = "Precio Total";
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Location = new System.Drawing.Point(675, 259);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.Size = new System.Drawing.Size(116, 23);
            this.txtPrecioTotal.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrecioTotal);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cboLugarUtilizacion);
            this.Controls.Add(this.txtFechaSolicitud);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.txtHorarioRetiro);
            this.Controls.Add(this.txtReserva);
            this.Controls.Add(this.lblHorarioReal);
            this.Controls.Add(this.lblHorarioDevolucion);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblLugarUtilizacion);
            this.Controls.Add(this.lblHorarioRetirio);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblFechaSolicitud);
            this.Controls.Add(this.lblnroRerserva);
            this.Name = "Form1";
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnroRerserva;
        private System.Windows.Forms.Label lblFechaSolicitud;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblHorarioRetirio;
        private System.Windows.Forms.Label lblLugarUtilizacion;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblHorarioDevolucion;
        private System.Windows.Forms.Label lblHorarioReal;
        private System.Windows.Forms.TextBox txtReserva;
        private System.Windows.Forms.TextBox txtHorarioRetiro;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.TextBox txtFechaSolicitud;
        private System.Windows.Forms.ComboBox cboLugarUtilizacion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecioTotal;
    }
}

