namespace EjemploTiposDatos
{
    partial class frmPrincipal
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
            grpDatos = new GroupBox();
            lblLetra = new Label();
            bttAceptar = new Button();
            txtEdad = new TextBox();
            lblEdad = new Label();
            txtDni = new TextBox();
            lblDni = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblMostrarEdad = new Label();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(lblMostrarEdad);
            grpDatos.Controls.Add(lblLetra);
            grpDatos.Controls.Add(bttAceptar);
            grpDatos.Controls.Add(txtEdad);
            grpDatos.Controls.Add(lblEdad);
            grpDatos.Controls.Add(txtDni);
            grpDatos.Controls.Add(lblDni);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Location = new Point(176, 90);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(363, 173);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Tus Datos";
            // 
            // lblLetra
            // 
            lblLetra.AutoSize = true;
            lblLetra.Location = new Point(190, 66);
            lblLetra.Name = "lblLetra";
            lblLetra.Size = new Size(33, 15);
            lblLetra.TabIndex = 5;
            lblLetra.Text = "Letra";
            lblLetra.Visible = false;
            lblLetra.Click += label1_Click;
            // 
            // bttAceptar
            // 
            bttAceptar.Location = new Point(124, 136);
            bttAceptar.Name = "bttAceptar";
            bttAceptar.Size = new Size(75, 23);
            bttAceptar.TabIndex = 4;
            bttAceptar.Text = "Aceptar";
            bttAceptar.UseVisualStyleBackColor = true;
            bttAceptar.Click += bttAceptar_Click;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(74, 92);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 3;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(17, 95);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(74, 63);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 3;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(17, 66);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(74, 34);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(17, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblMostrarEdad
            // 
            lblMostrarEdad.AutoSize = true;
            lblMostrarEdad.Location = new Point(190, 95);
            lblMostrarEdad.Name = "lblMostrarEdad";
            lblMostrarEdad.Size = new Size(33, 15);
            lblMostrarEdad.TabIndex = 6;
            lblMostrarEdad.Text = "edad";
            lblMostrarEdad.Visible = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpDatos);
            Name = "frmPrincipal";
            Text = "Ejemplo tipos  de datos";
            Load += frmPrincipal_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private TextBox txtDni;
        private Label lblDni;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtEdad;
        private Label lblEdad;
        private Button bttAceptar;
        private Label lblLetra;
        private Label lblMostrarEdad;
    }
}
