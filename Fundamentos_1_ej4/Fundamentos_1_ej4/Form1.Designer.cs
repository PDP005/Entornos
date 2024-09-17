namespace Fundamentos_1_ej4
{
    partial class frmCifrado
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
            grpCifradoCesar = new GroupBox();
            label1 = new Label();
            txtNum = new TextBox();
            bttCifra = new Button();
            tbtTxt = new Label();
            txtLetras = new TextBox();
            lblResult = new Label();
            grpCifradoCesar.SuspendLayout();
            SuspendLayout();
            // 
            // grpCifradoCesar
            // 
            grpCifradoCesar.Controls.Add(txtLetras);
            grpCifradoCesar.Controls.Add(tbtTxt);
            grpCifradoCesar.Controls.Add(bttCifra);
            grpCifradoCesar.Controls.Add(txtNum);
            grpCifradoCesar.Controls.Add(label1);
            grpCifradoCesar.Location = new Point(77, 38);
            grpCifradoCesar.Name = "grpCifradoCesar";
            grpCifradoCesar.Size = new Size(414, 150);
            grpCifradoCesar.TabIndex = 0;
            grpCifradoCesar.TabStop = false;
            grpCifradoCesar.Text = "Cifrado César";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 31);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Desplazamiento";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(115, 31);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 1;
            // 
            // bttCifra
            // 
            bttCifra.Location = new Point(295, 37);
            bttCifra.Name = "bttCifra";
            bttCifra.Size = new Size(101, 64);
            bttCifra.TabIndex = 2;
            bttCifra.Text = "button1";
            bttCifra.UseVisualStyleBackColor = true;
            bttCifra.Click += bttCifra_Click;
            // 
            // tbtTxt
            // 
            tbtTxt.AutoSize = true;
            tbtTxt.Location = new Point(18, 94);
            tbtTxt.Name = "tbtTxt";
            tbtTxt.Size = new Size(35, 15);
            tbtTxt.TabIndex = 3;
            tbtTxt.Text = "Texto";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(88, 98);
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(168, 23);
            txtLetras.TabIndex = 4;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(123, 210);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(38, 15);
            lblResult.TabIndex = 1;
            lblResult.Text = "label2";
            lblResult.Visible = false;
            // 
            // frmCifrado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(grpCifradoCesar);
            Name = "frmCifrado";
            Text = "Cifrado";
            grpCifradoCesar.ResumeLayout(false);
            grpCifradoCesar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpCifradoCesar;
        private Label label1;
        private TextBox txtLetras;
        private Label tbtTxt;
        private Button bttCifra;
        private TextBox txtNum;
        private Label lblResult;
    }
}
