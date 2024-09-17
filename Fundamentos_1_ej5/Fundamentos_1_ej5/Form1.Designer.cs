namespace Fundamentos_1_ej5
{
    partial class frmFecha
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
            lblFechaNac = new Label();
            textBox1 = new TextBox();
            lblSol = new Label();
            bttBoton = new Button();
            SuspendLayout();
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(120, 91);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(112, 15);
            lblFechaNac.TabIndex = 0;
            lblFechaNac.Text = "Fecha Nacimiento : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(238, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // lblSol
            // 
            lblSol.AutoSize = true;
            lblSol.Location = new Point(136, 135);
            lblSol.Name = "lblSol";
            lblSol.Size = new Size(38, 15);
            lblSol.TabIndex = 2;
            lblSol.Text = "label1";
            lblSol.Visible = false;
            // 
            // bttBoton
            // 
            bttBoton.Location = new Point(253, 135);
            bttBoton.Name = "bttBoton";
            bttBoton.Size = new Size(75, 23);
            bttBoton.TabIndex = 3;
            bttBoton.Text = "Que dia ?";
            bttBoton.UseVisualStyleBackColor = true;
            // 
            // frmFecha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bttBoton);
            Controls.Add(lblSol);
            Controls.Add(textBox1);
            Controls.Add(lblFechaNac);
            Name = "frmFecha";
            Text = "Fechas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFechaNac;
        private TextBox textBox1;
        private Label lblSol;
        private Button bttBoton;
    }
}
