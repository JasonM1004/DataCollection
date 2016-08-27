using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;
using ViewModel;
//using System.Web.Scri

namespace DataCollection
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var detils = new List<PastDetailsItem>();
            for (var i = 1; i < 6; i++)
            {
               // Thread.Sleep(2000);
                var url = string.Format("http://888.163.com/product/detail/past/2015102315PT00329355.html?notAutoLogFlag=true&pageSize=10&pageNo={0}&productId=2015102315PT00329355", i);
                var webClient = new WebClient();
                webClient.Headers["User-Agent"] =
                "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0) " +
                "(compatible; MSIE 6.0; Windows NT 5.1; " +
                ".NET CLR 1.1.4322; .NET CLR 2.0.50727)";
                webClient.Headers["Accept-Language"] = "zh-CN,zh;q=0.8,en;q=0.6";
                var result = webClient.DownloadData(url);
                var duobao = JsonConvert.DeserializeObject<DuoBao>(Encoding.UTF8.GetString(result));
                detils.AddRange(duobao.pastDetails);
                //Friends facebookFriends = new JavaScriptSerializer().Deserialize<Friends>(result);
            }
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream) { AutoFlush = true };
            var csv = new CsvWriter(writer);
            csv.Configuration.RegisterClassMap<PastDetailsItemMap>();
            detils.ForEach(a =>
            {
                csv.WriteRecord(a);
            });
            stream.Position = 0;
            var reader = new StreamReader(stream,Encoding.UTF8);
            var csvFile = reader.ReadToEnd();
            File.WriteAllText(@"D:\1.csv", csvFile, Encoding.UTF8);
            TextBlock1.Text = "ok";
        }

        public sealed class PastDetailsItemMap : CsvClassMap<PastDetailsItem>
        {
            public PastDetailsItemMap()
            {
                Map(m => m.accountId).Name("accountId");
                Map(m => m.address).Name("address");
                Map(m => m.cancelDesc).Name("cancelDesc");
                Map(m => m.duobaoUid).Name("duobaoUid");
                Map(m => m.headImg).Name("headImg");
                Map(m => m.leftSeconds).Name("leftSeconds");
                Map(m => m.luckyNumber).Name("luckyNumber");
                Map(m => m.luckyTime).Name("luckyTime");
                Map(m => m.nickName).Name("nickName");
                Map(m => m.participantUrl).Name("participantUrl");
                Map(m => m.participateNumber).Name("participateNumber");
                Map(m => m.periodId).Name("periodId");
                Map(m => m.productInfoUrl).Name("productInfoUrl"); ;
                Map(m => m.totalTimes).Name("totalTimes"); ;
                Map(m => m.userId).Name("userId"); ;
                //Map(m => m.LastName);

            }
        }

    }
}
