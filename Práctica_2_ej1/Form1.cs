namespace Práctica_2_ej1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDNI.Text=txtDNI.Text.ToUpper();
            if (txtApellido.Text=="" && txtDNI.Text=="" && txtEdad.Text=="" && txtNombre.Text=="")
            {
                MessageBox.Show("esta vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (Convert.ToInt32(txtEdad.Text) > 70 || Convert.ToInt32(txtEdad.Text) < 0)
            {
                MessageBox.Show("no esta entre los valires", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else  if(Char.IsLetter(txtDNI.Text[txtDNI.Text.Length - 1]) && 
                txtDNI.Text.Length < 9 && Convert.ToInt32(txtDNI.Text.Substring(0, txtDNI.Text.Length - 1)) < 99999999)
            {
                MessageBox.Show("bn", "bn", MessageBoxButtons.OK);

                //añadir al array
            }
            else
            {
                MessageBox.Show("mal dni", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
    }
}
