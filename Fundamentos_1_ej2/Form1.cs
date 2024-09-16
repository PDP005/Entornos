namespace Fundamentos_1_ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttCambiarPos_Click(object sender, EventArgs e)
        {
            int posx, posy;
            posx = Convert.ToInt32(txtPosX.Text);
            posy = Convert.ToInt32(txtPosY.Text);

            //syze paar cambiar tamaño
            lblCambioColYPos.Location = new Point(posx, posy);

        }

        private void bttCambiarColor_Click(object sender, EventArgs e)
        {
            int rojo, verde, azul;
            rojo = Convert.ToInt32(txtRojo.Text);
            verde = Convert.ToInt32(txtVerde.Text);
            azul = Convert.ToInt32(txtAzul.Text);
            if (rojo > 255 || verde > 255 || azul > 255)
            {
                //añadir mensaje de error
            }
            else
            {
                //Color color= new(0, rojo, verde, azul);
                Color color = Color.FromArgb(125, rojo, verde, azul);
                lblCambioColYPos.BackColor = color;
            }



        }
    }
}
