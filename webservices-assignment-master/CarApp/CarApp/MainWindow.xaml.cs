using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
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
using CarApp.ServiceReference1;

namespace CarApp
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Car> restCarList = new List<Car>();
        List<Car> soapCarList = new List<Car>();
        private ServiceReference1.IService1 carService;


        public MainWindow()
        {
            InitializeComponent();

            restCarList = RestCarHandler.GetCars();
            soapCarList = SoapCarHandler.GetCars();

            RestCarListView.ItemsSource = restCarList;
            SoapCarListView.ItemsSource = soapCarList;
            

        }



        private void btn_search_Click(object sender, RoutedEventArgs e)
        {
            Car car = RestCarHandler.GetCar(CarSearchInput.Text);
            LicensePlateLabelResult.Content = car.LicensePlate;
            TypeLabelResult.Content = car.Type;
        }

        private void Btn_search_soap_Click(object sender, RoutedEventArgs e)
        {
            Car car = SoapCarHandler.GetCar(CarSearchInput.Text);
            LicensePlateLabelResult.Content = car.LicensePlate;
            TypeLabelResult.Content = car.Type;
        }

        
    }


}
