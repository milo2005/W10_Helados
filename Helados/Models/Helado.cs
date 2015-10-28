using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace Helados.Models
{
    public class Helado:INotifyPropertyChanged
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set {
                nombre = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Nombre"));

            }
        }

        private string sabor;

        public string Sabor
        {
            get { return sabor; }
            set {
                sabor = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Sabor"));
            }
        }

        private int precio;

        public int Precio
        {
            get { return precio; }
            set {
                precio = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Precio"));
            }
        }

        private Color color;

        public Color Color
        {
            get { return color; }
            set {
                color = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Color"));

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;




    }
}
