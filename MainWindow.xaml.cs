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

namespace MaterialDesignDashboardWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Consommation consommation = new Consommation();
            DataContext = new ConsommationViewModel(consommation); 
        }

        private void GridBarraTitre_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }

    internal class ConsommationViewModel
    {
        public List<Consommation> Consoms { get; private set; }

        public ConsommationViewModel(Consommation consommation)
        {
            Consoms = new List<Consommation>
            {
                consommation
            };
        }
    }

    internal class Consommation
    {
        public string Titre { get; private set; }

        public int Pourcentage { get; private set; }

        public Consommation()
        {
            Titre = "Consommation actuelle";
            Pourcentage = CalcularPourcentage();
        }

        private int CalcularPourcentage()
        {
            return 47;// Calculer le pourcentage de consommation
        }
    }
}
