using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_2_ej1.Clases
{
    internal class Persona
    {

        private string nombre;
        private string apellido;
        private string edad;



        public Pais(string nombre, string saludo)
        {
            this.nombre = nombre;
            this.saludo = saludo;
        }
        public Pais(string nombre)
        {
            this.nombre = nombre;
        }


        public string Nombre { get => nombre; set => nombre = value; }
        public string Saludo { get => saludo; set => saludo = value; }

        public override bool Equals(object? obj)
        {
            return obj is Pais pais &&
                   nombre == pais.nombre;

        }
    }
