using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helados.Models
{
    public class Helado
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string sabor;

        public string Sabor
        {
            get { return sabor; }
            set { sabor = value; }
        }

        private string precio;

        public string Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }



    }
}
