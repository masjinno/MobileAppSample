using log4net;
using QiitaAPILib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MainWindow()
        {
            InitializeComponent();
            log.Debug("Initialize completed.");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            QiitaCaller caller = new QiitaCaller();
            List<string> titles = caller.GetTitles();
            MessageBox.Show("Qiitaの最新記事100件：" + titles);
        }
    }
}
