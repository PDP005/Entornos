namespace Fundamentos_1_ej4
{
    public partial class frmCifrado : Form
    {
        public frmCifrado()
        {
            InitializeComponent();
        }
        /*
        private void bttCifra_Click(object sender, EventArgs e)
        {
            string texto = txtLetras.Text;
            string textobn = "";
            int num = Convert.ToInt32(txtNum.Text);
            char[] c = texto.ToCharArray();

            foreach (char c2 in c) {
                char letra = (char)(c2+num);
                //char letra = c2;
                textobn += letra;
            }
            lblResult.Visible = true;
            lblResult.Text = textobn;
            
        }
        */
        private void bttCifra_Click(object sender, EventArgs e)
        {
            string texto = txtLetras.Text;
            string textobn = "";
            int num = Convert.ToInt32(txtNum.Text);
            char[] chars = texto.ToCharArray();
            //string letrasminusculas = "abcdefghijklmnñopqrstuvwxyz";
            //string letrasmayusc=letrasminusculas.ToUpper();
            char letra;
            foreach (char c in chars)
            {
                letra = c;
                //char letra = (char)(c2 + num);
                //textobn += letra;

                if(Char.IsLower(c))
                {
                    for (int i = 0; i < num; i++)
                    {
                        letra = (char)(letra + 1);
                        if (letra >= 'a' && letra <= 'z')
                        {
                            continue;
                        }
                        else
                            letra = 'a';
                    }
                    textobn += letra;
                }
                else
                {
                    for (int i = 0; i < num; i++)
                    {
                        letra = (char)(letra + 1);
                        if (letra >= 'A' && letra <= 'Z')
                        {
                            continue;
                        }
                        else
                            letra = 'A';
                    }
                    textobn += letra;
                }


            }
            lblResult.Visible = true;
            lblResult.Text = textobn;

        }


    }
}
