using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Fuel_Loger
{
    /// <summary>
    /// Interaction logic for AddLog.xaml
    /// </summary>
    public partial class AddLog : Window
    {
        public AddLog()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime dtDate = dtSelectDate.DisplayDate;
            float fAmount;
            float.TryParse(txbAmount.Text, out fAmount);
            float fCost;
            float.TryParse(txbCost.Text, out fCost);
            FuelLog log = new FuelLog(dtDate, fAmount, fCost);

            MessageBoxResult result = MessageBox.Show("Confirm", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                MainWindow.Fuellogs.Add(log);
                this.Close();
            }

        }

    }
}
