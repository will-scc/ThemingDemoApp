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

            SolidColorBrush blueBrush = new(Colors.Blue);

            Theme light = new("Light.Blue",
                              "Light Blue",
                              ThemeManager.BaseColorLight,
                              "Blue",
                              Colors.Blue,
                              blueBrush,
                              true,
                              false);

            ThemeManager.Current.AddTheme(light);

            Theme dark = new("Dark.Blue",
                             "Dark Blue",
                             ThemeManager.BaseColorDark,
                             "Blue",
                             Colors.Blue,
                             blueBrush,
                             true,
                             false);

            ThemeManager.Current.AddTheme(dark);

            ThemeManager.Current.ChangeTheme(this, "Light.Blue");
        }
    }
}
