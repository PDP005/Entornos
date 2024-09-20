namespace EjemploPOO
{
    partial class Form1
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
            grpDatosAlumnos = new GroupBox();
            label1 = new Label();
            txtTel = new TextBox();
            lblTel = new Label();
            txtNomb = new TextBox();
            lblNombre = new Label();
            txtDNI = new TextBox();
            lblDNI = new Label();
            bttAdd = new Button();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            grpOperaciones = new GroupBox();
            bttBuscar = new Button();
            grpDatosAlumnos.SuspendLayout();
            groupBox1.SuspendLayout();
            grpOperaciones.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatosAlumnos
            // 
            grpDatosAlumnos.Controls.Add(label1);
            grpDatosAlumnos.Controls.Add(txtTel);
            grpDatosAlumnos.Controls.Add(lblTel);
            grpDatosAlumnos.Controls.Add(txtNomb);
            grpDatosAlumnos.Controls.Add(lblNombre);
            grpDatosAlumnos.Controls.Add(txtDNI);
            grpDatosAlumnos.Controls.Add(lblDNI);
            grpDatosAlumnos.Location = new Point(26, 33);
            grpDatosAlumnos.Name = "grpDatosAlumnos";
            grpDatosAlumnos.Size = new Size(348, 181);
            grpDatosAlumnos.TabIndex = 0;
            grpDatosAlumnos.TabStop = false;
            grpDatosAlumnos.Text = "DatosAlumnos";
            grpDatosAlumnos.Enter += grpDatosAlumnos_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 55);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(160, 115);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(100, 23);
            txtTel.TabIndex = 5;
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(32, 123);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(53, 15);
            lblTel.TabIndex = 4;
            lblTel.Text = "Telefono";
            // 
            // txtNomb
            // 
            txtNomb.Location = new Point(160, 83);
            txtNomb.Name = "txtNomb";
            txtNomb.Size = new Size(100, 23);
            txtNomb.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(30, 91);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(160, 54);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 1;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(30, 62);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 0;
            lblDNI.Text = "DNI";
            // 
            // bttAdd
            // 
            bttAdd.Location = new Point(6, 22);
            bttAdd.Name = "bttAdd";
            bttAdd.Size = new Size(101, 57);
            bttAdd.TabIndex = 2;
            bttAdd.Text = "Añadir";
            bttAdd.UseVisualStyleBackColor = true;
            bttAdd.Click += bttAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(392, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 184);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(176, 154);
            listBox1.TabIndex = 0;
            // 
            // grpOperaciones
            // 
            grpOperaciones.Controls.Add(bttBuscar);
            grpOperaciones.Controls.Add(bttAdd);
            grpOperaciones.Location = new Point(23, 235);
            grpOperaciones.Name = "grpOperaciones";
            grpOperaciones.Size = new Size(390, 85);
            grpOperaciones.TabIndex = 4;
            grpOperaciones.TabStop = false;
            grpOperaciones.Text = "Operaciones";
            // 
            // bttBuscar
            // 
            bttBuscar.Location = new Point(113, 22);
            bttBuscar.Name = "bttBuscar";
            bttBuscar.Size = new Size(101, 57);
            bttBuscar.TabIndex = 3;
            bttBuscar.Text = "Buscar";
            bttBuscar.UseVisualStyleBackColor = true;
            bttBuscar.Click += bttBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 336);
            Controls.Add(grpOperaciones);
            Controls.Add(groupBox1);
            Controls.Add(grpDatosAlumnos);
            Name = "Form1";
            Text = "Form1";
            grpDatosAlumnos.ResumeLayout(false);
            grpDatosAlumnos.PerformLayout();
            groupBox1.ResumeLayout(false);
            grpOperaciones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatosAlumnos;
        private TextBox txtDNI;
        private Label lblDNI;
        private TextBox txtNomb;
        private Label lblNombre;
        private TextBox txtTel;
        private Label lblTel;
        private Button bttAdd;
        private Label label1;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private GroupBox grpOperaciones;
        private Button bttBuscar;
    }
}
