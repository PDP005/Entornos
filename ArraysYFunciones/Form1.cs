namespace ArraysYFunciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int cont = 0;
        private int[] numeros = new int[5];
        //private TextBox
        private void btGuardar_Click(object sender, EventArgs e)
        {

            if (txtNum.Text != "")
            {
                numeros[cont] = Convert.ToInt32(txtNum.Text);
                cont++;
                txtNum.Clear();
                txtNum.Focus();
                if (cont == 5)
                {
                    btGuardar.Enabled = false;
                    bttVer.Enabled = true;
                }
            }

        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            clean(grpListaNum);
            bttCuadrado.Enabled = false;
            /*
             foreach (int x in lista)
             {

             }
            */
        }

        private void clean(GroupBox grp)
        {
            foreach (Control c in grp.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                    c.Text = "";
                // el clear se puedo pero haciendo casting ((textbox)c).clear();
            }
        }

        private void bttVer_Click(object sender, EventArgs e)
        {

        }

        private void bttCuadrado_Click(object sender, EventArgs e)
        {
            
        }

        private void bttVer_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Control c in grpListaNum.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = Convert.ToString(numeros[i]);
                    i++;
                }
            }
            /*
            foreach (int x in numeros)
            {
                txt

            }
            */
        }

        private void bttCuadrado_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Control c in grpListaNum.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = Convert.ToString(numeros[i] * numeros[i]);
                    i++;
                }
            }
        }
    }
}
