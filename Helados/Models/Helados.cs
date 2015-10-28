using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace Helados.Models
{
   public class Helados
    {
        private ObservableCollection<Helado> data;

        public ObservableCollection<Helado> Data
        {
            get {
                if (data == null) {
                    data = new ObservableCollection<Helado>();

                    Helado vainilla = new Helado() { Nombre="Vainilla Pasion", Precio=7000, Sabor="Vainilla", Color=Color.FromArgb(0xff,0xff,0x00,0x00)};
                    Helado lulo = new Helado() { Nombre = "Lulo Pasion", Precio = 7000, Sabor = "Lulo", Color = Color.FromArgb(0xff, 0x00, 0xff, 0x00) };
                    Helado mandarina = new Helado() { Nombre = "Mandarina Pasion", Precio = 7000, Sabor = "Mandarina", Color = Color.FromArgb(0xff, 0xff, 0x44, 0x00) };

                    data.Add(vainilla);
                    data.Add(lulo);
                    data.Add(mandarina);


                }
                return data; }
            set { data = value; }
        }


    }
}
