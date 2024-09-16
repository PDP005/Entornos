namespace Fundamentos_1_ej2
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
            grpPosicion = new GroupBox();
            bttCambiarPos = new Button();
            txtPosY = new TextBox();
            txtPosX = new TextBox();
            lblPosY = new Label();
            lblPosX = new Label();
            grpColor = new GroupBox();
            bttCambiarColor = new Button();
            txtAzul = new TextBox();
            txtVerde = new TextBox();
            txtRojo = new TextBox();
            lblAzul = new Label();
            lblVerde = new Label();
            lblRojo = new Label();
            lblCambioColYPos = new Label();
            grpPosicion.SuspendLayout();
            grpColor.SuspendLayout();
            SuspendLayout();
            // 
            // grpPosicion
            // 
            grpPosicion.Controls.Add(bttCambiarPos);
            grpPosicion.Controls.Add(txtPosY);
            grpPosicion.Controls.Add(txtPosX);
            grpPosicion.Controls.Add(lblPosY);
            grpPosicion.Controls.Add(lblPosX);
            grpPosicion.Location = new Point(41, 56);
            grpPosicion.Name = "grpPosicion";
            grpPosicion.Size = new Size(232, 212);
            grpPosicion.TabIndex = 0;
            grpPosicion.TabStop = false;
            grpPosicion.Text = "tamaño";
            // 
            // bttCambiarPos
            // 
            bttCambiarPos.Location = new Point(35, 156);
            bttCambiarPos.Name = "bttCambiarPos";
            bttCambiarPos.Size = new Size(182, 43);
            bttCambiarPos.TabIndex = 4;
            bttCambiarPos.Text = "Cambiar Posición";
            bttCambiarPos.UseVisualStyleBackColor = true;
            bttCambiarPos.Click += bttCambiarPos_Click;
            // 
            // txtPosY
            // 
            txtPosY.Location = new Point(117, 108);
            txtPosY.Name = "txtPosY";
            txtPosY.Size = new Size(100, 23);
            txtPosY.TabIndex = 3;
            // 
            // txtPosX
            // 
            txtPosX.Location = new Point(117, 55);
            txtPosX.Name = "txtPosX";
            txtPosX.Size = new Size(100, 23);
            txtPosX.TabIndex = 2;
            // 
            // lblPosY
            // 
            lblPosY.AutoSize = true;
            lblPosY.Location = new Point(35, 116);
            lblPosY.Name = "lblPosY";
            lblPosY.Size = new Size(65, 15);
            lblPosY.TabIndex = 1;
            lblPosY.Text = "Posición Y ";
            // 
            // lblPosX
            // 
            lblPosX.AutoSize = true;
            lblPosX.Location = new Point(35, 58);
            lblPosX.Name = "lblPosX";
            lblPosX.Size = new Size(65, 15);
            lblPosX.TabIndex = 0;
            lblPosX.Text = "Posición X ";
            // 
            // grpColor
            // 
            grpColor.Controls.Add(bttCambiarColor);
            grpColor.Controls.Add(txtAzul);
            grpColor.Controls.Add(txtVerde);
            grpColor.Controls.Add(txtRojo);
            grpColor.Controls.Add(lblAzul);
            grpColor.Controls.Add(lblVerde);
            grpColor.Controls.Add(lblRojo);
            grpColor.Location = new Point(417, 56);
            grpColor.Name = "grpColor";
            grpColor.Size = new Size(267, 212);
            grpColor.TabIndex = 1;
            grpColor.TabStop = false;
            grpColor.Text = "Color";
            // 
            // bttCambiarColor
            // 
            bttCambiarColor.Location = new Point(33, 156);
            bttCambiarColor.Name = "bttCambiarColor";
            bttCambiarColor.Size = new Size(182, 43);
            bttCambiarColor.TabIndex = 6;
            bttCambiarColor.Text = "Cambiar Color";
            bttCambiarColor.UseVisualStyleBackColor = true;
            bttCambiarColor.Click += bttCambiarColor_Click;
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(115, 113);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(100, 23);
            txtAzul.TabIndex = 5;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(115, 80);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(100, 23);
            txtVerde.TabIndex = 4;
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(115, 46);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(100, 23);
            txtRojo.TabIndex = 3;
            // 
            // lblAzul
            // 
            lblAzul.AutoSize = true;
            lblAzul.Location = new Point(34, 116);
            lblAzul.Name = "lblAzul";
            lblAzul.Size = new Size(30, 15);
            lblAzul.TabIndex = 2;
            lblAzul.Text = "Azul";
            // 
            // lblVerde
            // 
            lblVerde.AutoSize = true;
            lblVerde.Location = new Point(34, 83);
            lblVerde.Name = "lblVerde";
            lblVerde.Size = new Size(36, 15);
            lblVerde.TabIndex = 1;
            lblVerde.Text = "Verde";
            // 
            // lblRojo
            // 
            lblRojo.AutoSize = true;
            lblRojo.Location = new Point(34, 49);
            lblRojo.Name = "lblRojo";
            lblRojo.Size = new Size(31, 15);
            lblRojo.TabIndex = 0;
            lblRojo.Text = "Rojo";
            // 
            // lblCambioColYPos
            // 
            lblCambioColYPos.BackColor = SystemColors.ControlLight;
            lblCambioColYPos.Location = new Point(278, 327);
            lblCambioColYPos.Name = "lblCambioColYPos";
            lblCambioColYPos.Size = new Size(190, 50);
            lblCambioColYPos.TabIndex = 2;
            lblCambioColYPos.Text = "CAMBIO DE COLOR Y POS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 488);
            Controls.Add(lblCambioColYPos);
            Controls.Add(grpColor);
            Controls.Add(grpPosicion);
            Name = "Form1";
            Text = "Form1";
            grpPosicion.ResumeLayout(false);
            grpPosicion.PerformLayout();
            grpColor.ResumeLayout(false);
            grpColor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPosicion;
        private Label lblPosX;
        private GroupBox grpColor;
        private Button bttCambiarPos;
        private TextBox txtPosY;
        private TextBox txtPosX;
        private Label lblPosY;
        private Button bttCambiarColor;
        private TextBox txtAzul;
        private TextBox txtVerde;
        private TextBox txtRojo;
        private Label lblAzul;
        private Label lblVerde;
        private Label lblRojo;
        private Label lblCambioColYPos;
    }
}
