namespace Práctica_2_ej2
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
            lstPaises = new ListBox();
            groupBox2 = new GroupBox();
            bttMod = new Button();
            bttRm = new Button();
            bttAdd = new Button();
            txtSaludo = new TextBox();
            label2 = new Label();
            txtPais = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstPaises);
            groupBox1.Location = new Point(355, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(268, 256);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista paises";
            // 
            // lstPaises
            // 
            lstPaises.FormattingEnabled = true;
            lstPaises.ItemHeight = 15;
            lstPaises.Location = new Point(39, 38);
            lstPaises.Name = "lstPaises";
            lstPaises.Size = new Size(186, 169);
            lstPaises.TabIndex = 0;
            lstPaises.SelectedIndexChanged += lstPaises_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bttMod);
            groupBox2.Controls.Add(bttRm);
            groupBox2.Controls.Add(bttAdd);
            groupBox2.Controls.Add(txtSaludo);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtPais);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(17, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(296, 256);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Introduce datos";
            // 
            // bttMod
            // 
            bttMod.Location = new Point(166, 135);
            bttMod.Name = "bttMod";
            bttMod.Size = new Size(55, 35);
            bttMod.TabIndex = 6;
            bttMod.Text = "x";
            bttMod.UseVisualStyleBackColor = true;
            bttMod.Click += bttMod_Click;
            // 
            // bttRm
            // 
            bttRm.Location = new Point(92, 135);
            bttRm.Name = "bttRm";
            bttRm.Size = new Size(55, 35);
            bttRm.TabIndex = 5;
            bttRm.Text = "-";
            bttRm.UseVisualStyleBackColor = true;
            bttRm.Click += bttRm_Click;
            // 
            // bttAdd
            // 
            bttAdd.Location = new Point(22, 135);
            bttAdd.Name = "bttAdd";
            bttAdd.Size = new Size(55, 35);
            bttAdd.TabIndex = 4;
            bttAdd.Text = "+";
            bttAdd.UseVisualStyleBackColor = true;
            bttAdd.Click += bttAdd_Click;
            // 
            // txtSaludo
            // 
            txtSaludo.Location = new Point(73, 61);
            txtSaludo.Name = "txtSaludo";
            txtSaludo.Size = new Size(131, 23);
            txtSaludo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 69);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Saludo";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(73, 28);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(131, 23);
            txtPais.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 36);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "País";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstPaises;
        private GroupBox groupBox2;
        private TextBox txtSaludo;
        private Label label2;
        private TextBox txtPais;
        private Label label1;
        private Button bttMod;
        private Button bttRm;
        private Button bttAdd;
    }
}
