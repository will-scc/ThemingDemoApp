using ControlzEx.Theming;
using System.Diagnostics;
using System.Windows;

namespace ThemingDemoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLightTheme_Click(object sender, RoutedEventArgs e)
        {
            ThemeManager.Current.ChangeTheme(this, "Light");
            Debug.WriteLine("Changed to Light");
        }
        
        private void btnDarkTheme_Click(object sender, RoutedEventArgs e)
        {
            ThemeManager.Current.ChangeTheme(this, "Dark");
            Debug.WriteLine("Changed to Dark");
        }
    }
}
