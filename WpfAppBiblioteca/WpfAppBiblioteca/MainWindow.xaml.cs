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

namespace WpfAppBiblioteca
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Libro libro = new Libro (string titolotxt.Text, string autoretxt.Text, int (int)paginetxt.Text);
            durata_lbl.Text = libro.readingTime();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}