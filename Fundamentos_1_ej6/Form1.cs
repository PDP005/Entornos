namespace Fundamentos_1_ej6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttIncremetar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = DateTime.Parse(txtFecha.Text);

                if (rdbDias.Checked)
                {
                    fecha.AddDays((int)Convert.ToDouble(txtA�adir.Text));
                }
                if (rdbMeses.Checked)
                {
                    fecha.AddMonths((int)Convert.ToDouble(txtA�adir.Text));
                }
                if (rdbA�os.Checked)
                {
                    fecha.AddYears((int)Convert.ToDouble(txtA�adir.Text));

                }

                txtFecha.Text = fecha.ToString();
                txtFecha.Text = fecha.ToString("dd/MM/yyyy");


            }
            catch ( Exception w)
            {
                MessageBox.Show("fecha mal puesta ", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }
    }
}
