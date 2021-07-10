
namespace Interfaz
{
    partial class Salas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumeroSala = new System.Windows.Forms.Label();
            this.lblNombreSala = new System.Windows.Forms.Label();
            this.lblBloque = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNumeroSala = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtBloque = new System.Windows.Forms.TextBox();
            this.txtNombreSala = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroSala
            // 
            this.lblNumeroSala.AutoSize = true;
            this.lblNumeroSala.Location = new System.Drawing.Point(12, 59);
            this.lblNumeroSala.Name = "lblNumeroSala";
            this.lblNumeroSala.Size = new System.Drawing.Size(70, 15);
            this.lblNumeroSala.TabIndex = 0;
            this.lblNumeroSala.Text = "Nro. de Sala";
            // 
            // lblNombreSala
            // 
            this.lblNombreSala.AutoSize = true;
            this.lblNombreSala.Location = new System.Drawing.Point(12, 112);
            this.lblNombreSala.Name = "lblNombreSala";
            this.lblNombreSala.Size = new System.Drawing.Size(103, 15);
            this.lblNombreSala.TabIndex = 1;
            this.lblNombreSala.Text = "Nombre de la Sala";
            // 
            // lblBloque
            // 
            this.lblBloque.AutoSize = true;
            this.lblBloque.Location = new System.Drawing.Point(12, 174);
            this.lblBloque.Name = "lblBloque";
            this.lblBloque.Size = new System.Drawing.Size(44, 15);
            this.lblBloque.TabIndex = 2;
            this.lblBloque.Text = "Bloque";
            this.lblBloque.Click += new System.EventHandler(this.lblBloque_Click);
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(12, 241);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(29, 15);
            this.lblPiso.TabIndex = 3;
            this.lblPiso.Text = "Piso";
            this.lblPiso.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 326);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(42, 15);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // txtNumeroSala
            // 
            this.txtNumeroSala.Location = new System.Drawing.Point(168, 56);
            this.txtNumeroSala.Name = "txtNumeroSala";
            this.txtNumeroSala.Size = new System.Drawing.Size(133, 23);
            this.txtNumeroSala.TabIndex = 5;
            this.txtNumeroSala.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(168, 323);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(133, 23);
            this.txtEstado.TabIndex = 6;
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(168, 238);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(133, 23);
            this.txtPiso.TabIndex = 7;
            // 
            // txtBloque
            // 
            this.txtBloque.Location = new System.Drawing.Point(168, 171);
            this.txtBloque.Name = "txtBloque";
            this.txtBloque.Size = new System.Drawing.Size(133, 23);
            this.txtBloque.TabIndex = 8;
            this.txtBloque.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtNombreSala
            // 
            this.txtNombreSala.Location = new System.Drawing.Point(168, 109);
            this.txtNombreSala.Name = "txtNombreSala";
            this.txtNombreSala.Size = new System.Drawing.Size(133, 23);
            this.txtNombreSala.TabIndex = 9;
            this.txtNombreSala.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(702, 79);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(86, 27);
            this.btnGrabar.TabIndex = 10;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(702, 167);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 28);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(702, 123);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 27);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // Salas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtNombreSala);
            this.Controls.Add(this.txtBloque);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtNumeroSala);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.lblBloque);
            this.Controls.Add(this.lblNombreSala);
            this.Controls.Add(this.lblNumeroSala);
            this.Name = "Salas";
            this.Text = "Salas";
            this.Load += new System.EventHandler(this.Salas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroSala;
        private System.Windows.Forms.Label lblNombreSala;
        private System.Windows.Forms.Label lblBloque;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtNumeroSala;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtBloque;
        private System.Windows.Forms.TextBox txtNombreSala;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
    }
}