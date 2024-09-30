using System.Net;

namespace Práctica_1_ej3
{
    public partial class Form1 : Form
    {
        private String Cadena = "TRWAGMVFPDXBNJZSQUHLCKE";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            if (dni.Length > 9)
            {
                pctMal.Visible = true;
            }
            //Extraemos los números y la letra
            string dniNumbers = dni.Substring(0, dni.Length - 1);
            string dniLeter = dni.Substring(dni.Length - 1, 1);
            dniLeter=dniLeter.ToUpper();
            //Intentamos convertir los números del DNI a integer
            var numbersValid = int.TryParse(dniNumbers, out int dniInteger);
            if (!numbersValid)
            {
                //No se pudo convertir los números a formato númerico
                pctMal.Visible = true;
            }
            if (CalculateDNILeter(dniInteger) != dniLeter)
            {
                //La letra del DNI es incorrecta
                pctMal.Visible = true;
            }
            //DNI Valido :)
            pictureBox1.Visible = true;
        }


        private string CalculateDNILeter(int dniNumbers)
        {
            //Cargamos los digitos de control
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            var mod = dniNumbers % 23;
            return control[mod];
        }
    }
    }

