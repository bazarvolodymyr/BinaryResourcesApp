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

namespace BinaryResourcesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<BitmapImage> _images = new List<BitmapImage>();
        private int _currentImage = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                string path = Environment.CurrentDirectory;
                _images.Add(new BitmapImage(new Uri(@"\Images\6t-YKf4lQXk.jpg", UriKind.Relative)));
                _images.Add(new BitmapImage(new Uri(@"\Images\aOxNgzTOevc.jpg", UriKind.Relative)));
                _images.Add(new BitmapImage(new Uri(@"\Images\NT3FLA4u35o.jpg", UriKind.Relative)));
                imageHolder.Source = _images[_currentImage];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPreviousImage_Click(object sender, RoutedEventArgs e)
        {
            if (--_currentImage < 0)
            {
                _currentImage = _images.Count - 1;
            }
            imageHolder.Source = _images[_currentImage];
        }

        private void btnNextImage_Click(object sender, RoutedEventArgs e)
        {
            if(++_currentImage >= _images.Count)
            {
                _currentImage = 0;
            }
            imageHolder.Source= _images[_currentImage];
        }
    }
}