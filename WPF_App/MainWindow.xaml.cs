using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
using Microsoft.Data.SqlClient;


namespace WPF_App
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
/*    public class Dogovor
    {
        public int dog_no { get; set; }
        public DateTime dog_date { get; set; }
        public DateTime update_time { get; set; }
        public Boolean actual { get; set; }
    }*/

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Создаю клиента и вызываю GetData() используя сервис WCF, на который предварительно сделал refference
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            // Заполняю DataGrid полученными данными
            DogovorTable.ItemsSource = client.GetData();
        }
    }
}
