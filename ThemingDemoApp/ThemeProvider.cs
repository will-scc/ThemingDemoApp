using ControlzEx.Theming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemingDemoApp
{
    public class ThemeProvider : LibraryThemeProvider
    {
        public static readonly ThemeProvider DefaultInstance = new();

        public ThemeProvider() : base(true)
        {
        }

        public override void FillColorSchemeValues(Dictionary<string, string> values, RuntimeThemeColorValues colorValues)
        {
            throw new NotImplementedException();
        }
    }
}
