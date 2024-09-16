namespace ArraysYFunciones
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
            gpNumeros = new GroupBox();
            btGuardar = new Button();
            label1 = new Label();
            txtNum = new TextBox();
            grpListaNum = new GroupBox();
            bttCuadrado = new Button();
            bttVer = new Button();
            btBorrar = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            gpNumeros.SuspendLayout();
            grpListaNum.SuspendLayout();
            SuspendLayout();
            // 
            // gpNumeros
            // 
            gpNumeros.Controls.Add(btGuardar);
            gpNumeros.Controls.Add(label1);
            gpNumeros.Controls.Add(txtNum);
            gpNumeros.Location = new Point(101, 52);
            gpNumeros.Name = "gpNumeros";
            gpNumeros.Size = new Size(269, 156);
            gpNumeros.TabIndex = 0;
            gpNumeros.TabStop = false;
            gpNumeros.Text = "Numeros";
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(116, 112);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(75, 23);
            btGuardar.TabIndex = 2;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 63);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 1;
            label1.Text = "Introduce num";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(130, 60);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 0;
            // 
            // grpListaNum
            // 
            grpListaNum.Controls.Add(bttCuadrado);
            grpListaNum.Controls.Add(bttVer);
            grpListaNum.Controls.Add(btBorrar);
            grpListaNum.Controls.Add(textBox4);
            grpListaNum.Controls.Add(textBox3);
            grpListaNum.Controls.Add(textBox2);
            grpListaNum.Controls.Add(textBox1);
            grpListaNum.Controls.Add(textBox5);
            grpListaNum.Location = new Point(124, 242);
            grpListaNum.Name = "grpListaNum";
            grpListaNum.Size = new Size(342, 117);
            grpListaNum.TabIndex = 1;
            grpListaNum.TabStop = false;
            grpListaNum.Text = "groupBox1";
            // 
            // bttCuadrado
            // 
            bttCuadrado.Location = new Point(267, 75);
            bttCuadrado.Name = "bttCuadrado";
            bttCuadrado.Size = new Size(75, 23);
            bttCuadrado.TabIndex = 13;
            bttCuadrado.Text = "Cuadrado";
            bttCuadrado.UseVisualStyleBackColor = true;
            bttCuadrado.Click += bttCuadrado_Click_1;
            // 
            // bttVer
            // 
            bttVer.Location = new Point(149, 88);
            bttVer.Name = "bttVer";
            bttVer.Size = new Size(75, 23);
            bttVer.TabIndex = 12;
            bttVer.Text = "Ver";
            bttVer.UseVisualStyleBackColor = true;
            bttVer.Click += bttVer_Click_1;
            // 
            // btBorrar
            // 
            btBorrar.Location = new Point(21, 68);
            btBorrar.Name = "btBorrar";
            btBorrar.Size = new Size(75, 23);
            btBorrar.TabIndex = 11;
            btBorrar.Text = "borrar";
            btBorrar.UseVisualStyleBackColor = true;
            btBorrar.Click += btBorrar_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(287, 39);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(49, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(149, 39);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(49, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(82, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(49, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(49, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(217, 39);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(49, 23);
            textBox5.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpListaNum);
            Controls.Add(gpNumeros);
            Name = "Form1";
            Text = "Form1";
            gpNumeros.ResumeLayout(false);
            gpNumeros.PerformLayout();
            grpListaNum.ResumeLayout(false);
            grpListaNum.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpNumeros;
        private Button btGuardar;
        private Label label1;
        private TextBox txtNum;
        private GroupBox grpListaNum;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button btBorrar;
        private Button bttVer;
        private Button bttCuadrado;
    }
}
