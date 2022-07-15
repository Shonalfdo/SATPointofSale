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
using SATPOS.ViewModel;
using SATPOS.Model;
using System.Text.Json;
using System.IO;

namespace SATPOS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BillingLister _newline = new BillingLister();
        public MainWindow()
        {
            

            InitializeComponent();


            //BillingLister newList = new BillingLister();

            //newList.LoadEntryData(123, 123, 123, 456, 78, 87, 98);
            //newList.LoadEntryData(123, 123, 123, 426, 78, 87, 98);

            //BillingGrid.ItemsSource = newList.SetEntryData();
        }

        private void UpdateInvoice() //Will be updated to DataBinding with Notify,For now use legacy methords and event triggers 
        {
            var temp_ItemID = Convert.ToInt32(In_Code.Text);
            var temp_ItemDC = Convert.ToInt32(In_DCount.Text);
            var temp_ItemQZ = Convert.ToInt32(In_Quantz.Text);
            var temp_ItemSB = Convert.ToInt32(In_Sub.Text);
            var temp_ItemUP = Convert.ToInt32(In_UnitPrice.Text);
            var temp_ItemAD = Convert.ToInt32(In_Add.Text);

            _newline.LoadEntryData(0, temp_ItemID, temp_ItemQZ, temp_ItemUP, temp_ItemAD, temp_ItemSB, temp_ItemAD);

            _newline.WriteToJson();

            BillingGrid.ItemsSource = _newline.SetEntryData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {        
            UpdateInvoice();
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
