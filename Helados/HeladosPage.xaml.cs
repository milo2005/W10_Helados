using Helados.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace Helados
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class HeladosPage : Page
    {
        public HeladosPage()
        {
            this.InitializeComponent();
        }

        public HeladoConverter HeladoC {
            get {
                HeladoConverter heladoC = App.Current.Resources["heladoConverter"] as HeladoConverter;
                return heladoC;
            }
        }


        private ObservableCollection<Helado> listaHelados;

        public ObservableCollection<Helado> ListaHelados
        {
            get {

                if (listaHelados == null)
                {
                    listaHelados = new ObservableCollection<Helado>();

                    Helado vainilla = new Helado() { Nombre = "Vainilla Pasion", Precio = 7000, Sabor = "Vainilla", Color = Color.FromArgb(0xff, 0xff, 0x00, 0x00) };
                    Helado lulo = new Helado() { Nombre = "Lulo Pasion", Precio = 7000, Sabor = "Lulo", Color = Color.FromArgb(0xff, 0x00, 0xff, 0x00) };
                    Helado mandarina = new Helado() { Nombre = "Mandarina Pasion", Precio = 7000, Sabor = "Mandarina", Color = Color.FromArgb(0xff, 0xff, 0x44, 0x00) };

                    listaHelados.Add(vainilla);
                    listaHelados.Add(lulo);
                    listaHelados.Add(mandarina);


                }
                return listaHelados; }
            set { listaHelados = value; }
        }




    }

   


}
