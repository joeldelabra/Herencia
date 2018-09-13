using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Herencia
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Animal> animales = new List<Animal>();

            Ave tucan = new Ave();
            tucan.Nombre = "Sam";

            Mamifero tigre = new Mamifero();
            tigre.Nombre = "Toño";

            animales.Add(tucan);
            animales.Add(tigre);
            Animal cocodrilo = new Reptil();
            cocodrilo.Nombre = "Godzilla";
            animales.Add(cocodrilo);

            Pez pezPayaso = new Pez();
            pezPayaso.Nombre = "Pato";
            animales.Add(pezPayaso);

            foreach(Animal animal in animales)
            {
                stckRegistro.Children.Add(
                    new TextBlock
                    {
                       Text = animal.desplazar()
                    });
            }
            Imprimir(tucan.ponerHuevos());
            // Imprimir ((Reptil)cocodrilo.cambiarPiel());
            
        }
        public void Imprimir(string texto)
        {
            stckRegistro.Children.Add(
                new TextBlock
                {
                    Text = texto
                });
        }
    }
}
