namespace Fundamentos_1_ej6
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
            label1 = new Label();
            txtFecha = new TextBox();
            groupBox1 = new GroupBox();
            bttIncremetar = new Button();
            txtAñadir = new TextBox();
            label2 = new Label();
            rdbAños = new RadioButton();
            rdbMeses = new RadioButton();
            rdbDias = new RadioButton();
            checkFormato = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 62);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(150, 95);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(100, 23);
            txtFecha.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bttIncremetar);
            groupBox1.Controls.Add(txtAñadir);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rdbAños);
            groupBox1.Controls.Add(rdbMeses);
            groupBox1.Controls.Add(rdbDias);
            groupBox1.Location = new Point(149, 170);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 121);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Incrementar fecha";
            // 
            // bttIncremetar
            // 
            bttIncremetar.Location = new Point(175, 83);
            bttIncremetar.Name = "bttIncremetar";
            bttIncremetar.Size = new Size(75, 23);
            bttIncremetar.TabIndex = 5;
            bttIncremetar.Text = "Incrementar";
            bttIncremetar.UseVisualStyleBackColor = true;
            bttIncremetar.Click += bttIncremetar_Click;
            // 
            // txtAñadir
            // 
            txtAñadir.Location = new Point(179, 36);
            txtAñadir.Name = "txtAñadir";
            txtAñadir.Size = new Size(100, 23);
            txtAñadir.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 37);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "Incremento";
            // 
            // rdbAños
            // 
            rdbAños.AutoSize = true;
            rdbAños.Location = new Point(20, 76);
            rdbAños.Name = "rdbAños";
            rdbAños.Size = new Size(52, 19);
            rdbAños.TabIndex = 2;
            rdbAños.TabStop = true;
            rdbAños.Text = "Años";
            rdbAños.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(20, 51);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(58, 19);
            rdbMeses.TabIndex = 1;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(20, 26);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(47, 19);
            rdbDias.TabIndex = 0;
            rdbDias.TabStop = true;
            rdbDias.Text = "Días";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // checkFormato
            // 
            checkFormato.AutoSize = true;
            checkFormato.Location = new Point(151, 132);
            checkFormato.Name = "checkFormato";
            checkFormato.Size = new Size(119, 19);
            checkFormato.TabIndex = 3;
            checkFormato.Text = "Cambiar Formato";
            checkFormato.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkFormato);
            Controls.Add(groupBox1);
            Controls.Add(txtFecha);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFecha;
        private GroupBox groupBox1;
        private CheckBox checkFormato;
        private RadioButton rdbMeses;
        private RadioButton rdbDias;
        private RadioButton rdbAños;
        private Button bttIncremetar;
        private TextBox txtAñadir;
        private Label label2;
    }
}
