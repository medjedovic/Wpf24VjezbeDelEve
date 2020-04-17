using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf24VjezbeDelEve
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<clsOsoba> lstOsoba = new ObservableCollection<clsOsoba>();
        clsAlarm a = new clsAlarm();
        clsAlarm a1 = new clsAlarm();

        private string g1;
        public string gI
        {

            get => g1;

            set
            {
                g1 = value;
                a.PromjenaInfoM(g1);
            }
        }

        private string g2;
        public string gII
        {

            get => g2;

            set
            {
                g2 = value;
                a1.PromjenaInfoM(g2);
            }
        }


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            dgOsoba.ItemsSource = lstOsoba;

            lstOsoba.Add(new clsOsoba("Dragan", "Pepić", "Čuje!"));
            lstOsoba.Add(new clsOsoba("Emir", "Dazdarević", "Čuje!"));
            lstOsoba.Add(new clsOsoba("Samer", "Ibrahimović", "Čuje!"));
            lstOsoba.Add(new clsOsoba("Imran", "Midović", "Čuje!"));
            lstOsoba.Add(new clsOsoba("Ahmed", "Hadžifejzović", "Čuje!"));
            lstOsoba.Add(new clsOsoba("Dženan", "Totić", "Čuje!"));
            lstOsoba.Add(new clsOsoba("Elmedin", "Mustafić", "Čuje!"));
            lstOsoba.Add(new clsOsoba("Amar", "Amar", "Čuje!"));
        }

        private void ToggleButtonG1_Click(object sender, RoutedEventArgs e)
        {
            ToggleButton tb = sender as ToggleButton;
            //toggle button ima tri stanja bool true, false i null 
            //tip podatka kome dodamo ? npr. bool? može da bude null
            //.value će sigurno vratiti bool 

            if (tb.IsChecked == true)
            {
                a.PromjenaInfo += (tb.DataContext as clsOsoba).PromjenaInformacije;
            }
            else
            {
                //MessageBox.Show("Van Delegat");
                a.PromjenaInfo -= (tb.DataContext as clsOsoba).PromjenaInformacije;
            }
        }

        private void ToggleButtonG2_Click(object sender, RoutedEventArgs e)
        {
            ToggleButton tb = sender as ToggleButton;
            if (tb.IsChecked == true)
            {
                a1.PromjenaInfo += (tb.DataContext as clsOsoba).PromjenaInformacije;
            }
            else
            {
                a1.PromjenaInfo -= (tb.DataContext as clsOsoba).PromjenaInformacije;
            }
        }
    

        private void btnDel(object sender, RoutedEventArgs e)
        {
            //remove sa liste vraća bool tako da se može dobiti povratna informacija da li je uspeo da obriše 
            //ali neće vratiti nikakvu vrijednost
            if (!lstOsoba.Remove((sender as Button).DataContext as clsOsoba))
                MessageBox.Show("Brisanje nije uspelo!");
        }
    }
}
