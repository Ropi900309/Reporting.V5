using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Threading;
using Tenaris.Fava.Production.Reporting.View.Properties;

namespace Tenaris.Fava.Production.Reporting.View
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            InitializeCultures();
        }

        public void InitializeCultures()
        {
            if (!string.IsNullOrEmpty(Settings.Default.Culture))
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(Settings.Default.Culture);
            }

            if (!string.IsNullOrEmpty(Settings.Default.UICulture))
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(Settings.Default.UICulture);
            }

            FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(
            XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));
        }

        public void InitializeMainWindow()
        {

        }

        private void AppDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            //e.Exception.Trace();
            e.Handled = true;
        }
    }
}
