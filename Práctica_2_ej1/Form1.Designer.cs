namespace Práctica_2_ej1
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
            groupBox1 = new GroupBox();
            txtNombre = new TextBox();
            label1 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            txtEdad = new TextBox();
            label3 = new Label();
            txtDNI = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEdad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(94, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 267);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(88, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(178, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 43);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(88, 72);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(178, 23);
            txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 75);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(88, 107);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(178, 23);
            txtEdad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 110);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "Edad";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(88, 145);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(178, 23);
            txtDNI.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 148);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 6;
            label4.Text = "Dni";
            // 
            // button1
            // 
            button1.Location = new Point(44, 194);
            button1.Name = "button1";
            button1.Size = new Size(82, 31);
            button1.TabIndex = 8;
            button1.Text = "Introducir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(184, 194);
            button2.Name = "button2";
            button2.Size = new Size(82, 31);
            button2.TabIndex = 9;
            button2.Text = "Visualizar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNombre;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox txtDNI;
        private Label label4;
        private TextBox txtEdad;
        private Label label3;
        private TextBox txtApellido;
        private Label label2;
    }
}
