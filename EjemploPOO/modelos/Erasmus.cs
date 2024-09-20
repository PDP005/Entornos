using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPOO.modelos
{
    public class Erasmus:Alumno
    {
        private string pais;
        public Erasmus(string dni,string nombre,string tel,string pais) : base(dni,nombre,tel)
        {

        }
    }
}
