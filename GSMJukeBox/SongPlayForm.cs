using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSMJukeBox
{
    public partial class SongPlayForm : MetroFramework.Forms.MetroForm
    {

        string constr = "SERVER=127.0.0.1,1234; DATABASE=gsmjukebox;UID=shin;PASSWORD='1234'";
        public SongPlayForm()
        {
            /*IWebDriver driver = new ChromeDriver();
            
            List<String> urls = getURL();
            for(int i = 0; i < urls.Count; i++)
        {
                String url = urls[i].ToString();
                driver.Url = url;
                driver.FindElement(By.Id("player")).Click();

                Thread.Sleep(10000);
                cnt++;
            }*/

            InitializeComponent();

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            List<string> starttimes = getstarttime();
            List<string> endtimes = getendTime();
            int cnt = 0;
            int starthour = Int32.Parse(starttimes[0].Split(':')[0]) * 100;
            int startminute = Int32.Parse(starttimes[0].Split(':')[0]);
            int endhour = Int32.Parse(endtimes[0].Split(':')[0]) * 100;
            int endminute = Int32.Parse(endtimes[0].Split(':')[0]);
            try
            {
                int starttime = starthour + startminute;
                int endtime = endhour + endminute;
                List<string> urls = getURL();

                while (((DateTime.Now.Hour * 100) + DateTime.Now.Minute <= starttime && (DateTime.Now.Hour * 100) + DateTime.Now.Minute >= endtime))
                {
                    cnt++;
                    var embed = "<html><head>" +
                    "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                    "</head><body>" +
                    "<iframe width=\"300\" src=\"{0}\"" +
                    "<iframe width=\"400\" height=\"300\" src=\"{0}\"" +
                    "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                    "</body></html>";

                    var url = urls[0];

                    this.webBrowser1.DocumentText = string.Format(embed, url);
                    urls.Remove(urls[0]);


                }
                if (cnt == 0 && urls.Count != 0)
                {
                    MessageBox.Show("예약 시간을 확인해주세요!");
                    AdminMainForm admin = new AdminMainForm();
                    admin.ShowDialog();
                    this.Close();

                }
            }
            catch
            {
                MessageBox.Show("예약 시간을 확인해주세요!");
                AdminMainForm admin = new AdminMainForm();
                admin.ShowDialog();
                this.Close();
            }
        }

        public List<String> getURL() { 
     

            List<string> arrayList = new List<string>();
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                string sql = "select songurl from reservedsong";
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = sql;
                SqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    arrayList.Add(rdr["songurl"] as string + "?amp;&autoplay=1");
                }
                rdr.Close();

            }
            return arrayList;
        }
        public List<string> getstarttime()
        {
            List<string> starttime = new List<string>();
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();

                string sql = "select starttime from playtime;";
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = sql;
                SqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    starttime.Add(rdr["starttime"] as String);

                }
                rdr.Close();

            }
            return starttime;

        }
        public List<string> getendTime()
        {
            List<string> endtime = new List<string>();

            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();

                string sql = "select closetime from playtime;";
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = sql;
                SqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    endtime.Add(rdr["closetime"] as String);

                }
                rdr.Close();

            }
            return endtime;
        }
    }
}