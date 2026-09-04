using System.Globalization;
using System.IO;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fuel_Loger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string FILE_PATH = "C:\\Users\\Matt\\Desktop\\FuelLoger\\Fuel_Loger\\Fuel_Logs.txt";

        public MainWindow()
        {
            if (File.Exists(FILE_PATH) != true)
            {
                MessageBox.Show("File not found","Missing File",MessageBoxButton.OK, MessageBoxImage.Error);
            }

            using (StreamReader reader = new StreamReader(FILE_PATH))
            {
                string sLine;

                while ((sLine = reader.ReadLine()) != null)
                {
                    int ipos = sLine.IndexOf("#");
                    string strDate = sLine.Substring(0, ipos);
                    DateTime date = DateTime.ParseExact(strDate, "yyyyMMdd", CultureInfo.InvariantCulture);
                    sLine = sLine.Remove(0, ipos + 1);
                    ipos = sLine.IndexOf("#");
                    string sAmount = sLine.Substring(0, ipos);
                    sLine = sLine.Remove(0, ipos + 1);
                    string sCost = sLine;
                    FuelLog log = new FuelLog(date,float.Parse(sAmount),float.Parse(sCost));
                }
            }

            InitializeComponent();
        }
    }
}