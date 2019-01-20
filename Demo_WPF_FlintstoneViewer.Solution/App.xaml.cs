using Demo_WPF_FlintstoneViewer.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Demo_WPF_FlintstoneViewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_Startup(object sender, StartupEventArgs e)
        {
            FlintstoneViewerBL flintstoneTrackerBL = new FlintstoneViewerBL();
        }
    }
}
