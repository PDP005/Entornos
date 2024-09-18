namespace Fundamentos_1_ej5
{
    public partial class frmFecha : Form
    {
        public frmFecha()
        {
            InitializeComponent();

        }

        private void bttBoton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Parse(textBox1.Text).DayOfWeek.ToString());
        }
    }
}
