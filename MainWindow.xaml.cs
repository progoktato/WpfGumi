using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfGumi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Tetel> tetelek = new ObservableCollection<Tetel>();

        List<String> atmerok = new List<String>() { "R10", "R12", "R13", "R14", "R15", "R16", "R17", "R18", "R19", "R20", "R21", "R22", "R23" };
        public MainWindow()
        {
            InitializeComponent();
            dgTetelek.ItemsSource = tetelek;
            FelveszDemoAdatokat();


            cbAtmero.ItemsSource = atmerok;

            /*
            foreach (var item in atmerok)
            {
                cbAtmero.Items.Add(item);
            }
            */

            cbAtmero.SelectedIndex = 5;//1p

            txtMagassag.Text = "55";
        }

        private void FelveszDemoAdatokat()
        {
            tetelek.Add(new Tetel("nyári", 205, 55, "R16", 4));
            tetelek.Add(new Tetel("téli", 235, 55, "R18", 8));
            tetelek.Add(new Tetel("téli", 205, 55, "R16", 2));
            tbMennyi.Text = tetelek.Sum(x => x.Darab) + " db";
        }

        private void btnIgeny_Click(object sender, RoutedEventArgs e)
        {
            bool hibasMennyiseg = false;
            int mennyiseg = 0;
            try
            {
                mennyiseg = Convert.ToInt32(txtDarab.Text);
            }
            catch (Exception)
            {
                hibasMennyiseg = true;
            }
            if (hibasMennyiseg || mennyiseg == 0)
            {
                MessageBox.Show("Nem adott meg mennyiséget!");
                txtDarab.Focus();  //1p
                return;
            }
            string tipus;
            if (rbNyari.IsChecked == true)  //1p
            {
                tipus = "Nyári";
            }
            else if (rbNyari.IsChecked == true)  //1p
            {
                tipus = "Téli";
            }
            else
            {
                tipus = "Négyévszakos";
            }
            tetelek.Add(new Tetel(tipus, (int)sliSzelesseg.Value, int.Parse(txtMagassag.Text), cbAtmero.SelectedItem.ToString(), int.Parse(txtDarab.Text))); //2p
            tbMennyi.Text = tetelek.Sum(x => x.Darab) + " db";
        }

        private void btnTorles_Click(object sender, RoutedEventArgs e)
        {
            //tetelek.Remove(dgTetelek.SelectedItem as Tetel); //1p

            if (dgTetelek.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztva törlendő sor!");
                return;
            }
            tetelek.RemoveAt(dgTetelek.SelectedIndex); //1p
            tbMennyi.Text = tetelek.Sum(x => x.Darab) + " db";
        }

        private void btnUrites_Click(object sender, RoutedEventArgs e)
        {
            tetelek.Clear();  //1p
            tbMennyi.Text = tetelek.Sum(x => x.Darab) + " db";
        }
    }
}