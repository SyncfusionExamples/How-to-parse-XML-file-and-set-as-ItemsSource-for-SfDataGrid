using Syncfusion.Maui.Data;
using Syncfusion.Maui.DataGrid;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Reflection;
using System.Xml.Serialization;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream? stream = assembly.GetManifestResourceStream("SfDataGridSample.Repository.xml");
            ObservableCollection<OrderInfo> OrdersInfo;
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<OrderInfo>));
            OrdersInfo = (ObservableCollection<OrderInfo>)serializer.Deserialize(stream!)!;
            dataGrid.ItemsSource = OrdersInfo;

        }
    }
}
