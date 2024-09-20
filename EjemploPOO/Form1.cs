using EjemploPOO.modelos;

namespace EjemploPOO
{
    public partial class Form1 : Form
    {
        Alumno[] listaClase;
        int numAl;
        public Form1()
        {
            InitializeComponent();
            listaClase = new Alumno[5];

        }

        private void grpDatosAlumnos_Enter(object sender, EventArgs e)
        {

        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            if (txtNomb.Text == "" || txtDNI.Text == "" || txtTel.Text == "")
            {
                MessageBox.Show("rellena todos", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    listaClase[numAl] = new Alumno(txtDNI.Text, txtNomb.Text, txtTel.Text);
                    numAl++;
                }
                catch (System.IndexOutOfRangeException ex)
                {
                    MessageBox.Show("clase completa ", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    bttAdd.Enabled = false;
                }
                cleanCajas(grpDatosAlumnos);
                txtDNI.Focus();
            }
        }
        public void cleanCajas(GroupBox grp)
        {
            foreach (Control c in grp.Controls)
            {
                if (c.GetType().Name == "TextBox")
                {
                    c.Text = "";
                }

            }
        }

        private void bttBuscar_Click(object sender, EventArgs e)
        {
            if (bttBuscar.Text == "Buscar")
            {
                txtNomb.Enabled = false;
                txtTel.Enabled = false;
                txtDNI.Focus();
                bttBuscar.Text = "Aceptar";
            }
            else
            {
                Alumno a = buscarAlumno(txtDNI.Text);
                if (a == null)
                {
                    MessageBox.Show("alumno no existe", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    bttAdd.Enabled = false;
                    bttBuscar.Enabled=false;
                }
                else
                {
                    txtNomb.Text = a.Nombre;
                    txtTel.Text = a.Telefono;
                    bttBuscar.Text = "buscar";
                }
            }

        }
        private Alumno buscarAlumno(string dni)
        {
            foreach(Alumno a in listaClase)
            {
                try {
                    if (a.Dni == dni)
                    {
                        return a;
                    }
                } catch (System.NullReferenceException e)
                {
                    return null;
                }
            }
            return null;
        }
        // editar que solo deje editar el tel
        //VMEJORADA radio button que si es erasmuus se gabilite el boton de erasmus

    }
}
