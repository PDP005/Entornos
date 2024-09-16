namespace EjemploTiposDatos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void bttAceptar_Click(object sender, EventArgs e)
        {
            int edad;
            string nombre;
            string dni;
            char letra;

            edad = Convert.ToInt32(txtEdad.Text);
            nombre = txtNombre.Text;
            dni = txtDni.Text;
            Boolean bn = false;

            char[] letras = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            //usar el char is letter para ver q la ultima es letra y si es la sacamos y la mostramos en una cajita
            //el de hola mundo que sea un interruptor



            letra = Convert.ToChar(dni.Substring(8, 1));

            string mensaje;
            if (edad < 18)
                mensaje = "eres menor";
            else
                mensaje = "eres MAYOR";
            lblMostrarEdad.Text = mensaje;
            lblMostrarEdad.Show();
            foreach (char car in letras)
            {
                string letraStr = letra.ToString();

                if (dni.EndsWith(letraStr))
                {
                    bn = true;
                    lblLetra.Text= "La letra es: "+letraStr;
                    lblLetra.Show();
                    break;
                }
            }


        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //this es si hay como varias cajitas
            foreach (Control c in grpDatos.Controls)
            {
                //cambia el color A rrodos los cuadraditos q tienen esa clase
                if (c.GetType().Name == "TextBox")
                {
                    c.ForeColor = Color.Red;
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
