using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                    Helado vainilla = new Helado() { Nombre="Vainilla Pasion", Precio="7000", Sabor="Vainilla", Color="Rojo"};
                    Helado lulo = new Helado() { Nombre = "Lulo Pasion", Precio = "7000", Sabor = "Lulo", Color = "Verde pasion" };
                    Helado mandarina = new Helado() { Nombre = "Mandarina Pasion", Precio = "7000", Sabor = "Mandarina", Color = "Naranja rojiso" };

                    data.Add(vainilla);
                    data.Add(lulo);
                    data.Add(mandarina);


                }
                return data; }
            set { data = value; }
        }


    }
}
