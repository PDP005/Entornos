namespace Práctica_1_ej3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            txtDNI = new TextBox();
            button1 = new Button();
            pctMal = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctMal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(88, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 152);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(66, 46);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(139, 23);
            txtDNI.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(78, 88);
            button1.Name = "button1";
            button1.Size = new Size(115, 52);
            button1.TabIndex = 0;
            button1.Text = "Validar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pctMal
            // 
            pctMal.Image = (Image)resources.GetObject("pctMal.Image");
            pctMal.Location = new Point(361, 58);
            pctMal.Name = "pctMal";
            pctMal.Size = new Size(209, 156);
            pctMal.SizeMode = PictureBoxSizeMode.StretchImage;
            pctMal.TabIndex = 1;
            pctMal.TabStop = false;
            pctMal.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(361, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(pctMal);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctMal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDNI;
        private Button button1;
        private PictureBox pctMal;
        private PictureBox pictureBox1;
    }
}
