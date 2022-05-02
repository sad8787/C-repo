using Monedas.Data;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;



namespace Monedas
{
    public partial class Form1 : Form
    {
        string key = "";
        string search = "BTC/RUB,ETH/RUB,USD/RUB,EUR/RUB,GBP/RUB";
        int second = 60;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key == "")
            {
                if (textBoxKey.Text == "" || textBoxKey.Text == null)
                {
                    timer1.Stop();
                    
                }
                else
                {
                    key = textBoxKey.Text;
                    textBoxKey.Text= "";
                }

               
            }
            if (key != "")
            {
                if (second == 60)
                {
                    printData();
                }
                labelCount.Text = second.ToString();
                second--;
                timer1.Start();

                if (second <= 0)
                {
                    second = 60;
                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void printData() 
        {
            Root root = readJson();
            this.dataGridView1.Rows.Clear();       
             //Excel excel = new Excel("C:\\excel\\doc.xlsx", 1);
             Excel excel = new Excel("C:\\tmp\\doc.xlsx", 1);
            string[] cadena;
            //BTCRUB
            if (root.BTCRUB!= null)
            {                
                cadena = root.BTCRUB.CoinToString();
                this.dataGridView1.Rows.Add(cadena[0], cadena[1], cadena[2], cadena[3], cadena[4], cadena[5], cadena[6]);
                //this.dataGridView1.Rows.Add(root.BTCRUB.meta.symbol, root.BTCRUB.values[0].datetime, root.BTCRUB.values[0].open, root.BTCRUB.values[0].high, root.BTCRUB.values[0].low, root.BTCRUB.values[0].close, root.BTCRUB.Percentage());
                excel.WriteNewRow(cadena);
            }
            //ETHRUB
            if (root.ETHRUB != null)
            {                
                cadena = root.ETHRUB.CoinToString();
                this.dataGridView1.Rows.Add(cadena[0], cadena[1], cadena[2], cadena[3], cadena[4], cadena[5], cadena[6]);
                excel.WriteNewRow( cadena);                

            }
            //USDRUB
            if (root.USDRUB != null)
            {                
                cadena = root.USDRUB.CoinToString();
                this.dataGridView1.Rows.Add(cadena[0], cadena[1], cadena[2], cadena[3], cadena[4], cadena[5], cadena[6]);
                excel.WriteNewRow( cadena);
                
            }
            //EURRUB
            if (root.EURRUB != null)
            {                
                cadena = root.EURRUB.CoinToString();
                this.dataGridView1.Rows.Add(cadena[0], cadena[1], cadena[2], cadena[3], cadena[4], cadena[5], cadena[6]);
                excel.WriteNewRow( cadena);
                
            }
            //GBP/RUB
            if (root.GBPRUB != null)
            {                
                cadena = root.GBPRUB.CoinToString();
                this.dataGridView1.Rows.Add(cadena[0], cadena[1], cadena[2], cadena[3], cadena[4], cadena[5], cadena[6]);
                excel.WriteNewRow( cadena);               
            }
            excel.Close();
            excel.Quit();


        }
        private Root readJson() {
            using (WebClient web = new WebClient())
            {
                string url1 = string.Format("https://api.twelvedata.com/time_series?symbol={0}&interval=1min&apikey={1}", search, key);
                try
                {
                    var json = web.DownloadString(url1);
                    Root root = JsonConvert.DeserializeObject<Root>(json);
                    return root;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("{0} Error", ex.Message);
                }
            }
            return new Root();
        }
        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
       

    }
}
