using Práctica_2_ej2.Modelos;

namespace Práctica_2_ej2
{
    public partial class Form1 : Form
    {

        private List<Pais> l_Paises = new List<Pais>(8);
        private int posActual;
        private Exception exEnBlanco;
        public Form1()
        {
            InitializeComponent();
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            valida_datos();
            l_Paises.Add(new Pais(txtPais.Text, txtSaludo.Text));
            lstPaises.Items.Add(txtPais.Text);
        }

        private void valida_datos()
        {
            try
            {
                if(txtPais.Text="")
                    trow exEnBlanco("mal);

            }
            catch (exEnBlanco ex)
            {

            }
        }
        private void lstPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPaises.SelectedIndex == -1)
                return;
            //ver larga
            posActual = buscaPaís(lstPaises.Text);

            //version corta
            //int pos=lstPaises.SelectedIndex;

            if (posActual == -1)
                MessageBox.Show("no esta");
            else
            {
                txtPais.Text = l_Paises[posActual].Nombre;
                txtSaludo.Text = l_Paises[posActual].Saludo;
            }
        }

        private void bttRm_Click(object sender, EventArgs e)
        {
            l_Paises.RemoveAt(posActual);
            lstPaises.Items.RemoveAt(posActual);
            txtSaludo.Clear();
            txtPais.Clear();

        }
        private int buscaPaís(string nom)
        {
            Pais p = new Pais(nom);
            int pos = l_Paises.IndexOf(p);
            return pos;

        }

        private void bttMod_Click(object sender, EventArgs e)
        {
            l_Paises[posActual].Saludo=txtSaludo.Text;
            l_Paises[posActual].Nombre = txtPais.Text;
            lstPaises.Items[posActual] = txtPais.Text;

        }
    }
}
