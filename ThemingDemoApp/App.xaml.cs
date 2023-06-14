using ControlzEx.Theming;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ThemingDemoApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            FrameworkElement.StyleProperty.OverrideMetadata(typeof(MainWindow), new FrameworkPropertyMetadata
            {
                DefaultValue = Current.FindResource(typeof(Window))
            });

            LibraryTheme light = new(new Uri("pack://application:,,,/ThemingDemoApp;component/Resources/LightTheme.xaml"),
                                     ThemeProvider.DefaultInstance);

            LibraryTheme dark = new(new Uri("pack://application:,,,/ThemingDemoApp;component/Resources/DarkTheme.xaml"),
                                    ThemeProvider.DefaultInstance);

            ThemeManager.Current.AddLibraryTheme(light);
            ThemeManager.Current.AddLibraryTheme(dark);

            ThemeManager.Current.ChangeTheme(this, "Light");
        }
    }
}
