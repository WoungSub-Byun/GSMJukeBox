using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;
using System.Threading;
using System.Web.Helpers;
using System.Windows.Forms;

namespace GSMJukeBox
{
    public partial class SongPlayForm : MetroFramework.Forms.MetroForm
    {

        string constr = "SERVER=127.0.0.1,1234; DATABASE=gsmjukebox;UID=shin;PASSWORD='1234'";
        string googleApiKey = "AIzaSyAnAKPb8ZJIkKWXzWFsyPQJz9OqzI8fNdI";
        
        public SongPlayForm()
        {
            InitializeComponent();
            
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

                while (((DateTime.Now.Hour * 100) + DateTime.Now.Minute >= starttime && (DateTime.Now.Hour * 100) + DateTime.Now.Minute <= endtime) && urls.Count != cnt)
                {
                    
                    string url = urls[cnt];
                    string id = url.Substring(url.Length - 11);

                    if (url.Contains("watch?v="))
                    {
                        url = url.Replace("watch?v=", "embed/");
                    }
                    url = url + "?amp;&autoplay=1";

                    string embed = "<html><head>" +
                    "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                    "</head><body>" +
                    "<iframe width=\"400\" height=\"300\" src=\"" + url +
                    "\"frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                    "</body></html>";
                    webBrowser1.DocumentText = embed;

                    
                    WebClient myDownloader = new WebClient();

                    myDownloader.Encoding = System.Text.Encoding.UTF8;

                    string json = myDownloader.DownloadString("https://www.googleapis.com/youtube/v3/videos?" +
                        "id=" + id +
                        "&key=" + googleApiKey +
                        "&part=contentDetails");
                    dynamic dynamicObject = Json.Decode(json);
                    string tmp = dynamicObject.items[0].contentDetails.duration;
                    int Duration = Convert.ToInt32(System.Xml.XmlConvert.ToTimeSpan(tmp).TotalSeconds)*1000;
                    
                

                    cnt++;
                    Delay(Duration+2000);

                    this.webBrowser1.Stop();
                }

                if (cnt == 0 && urls.Count != 0)
                {
                    MessageBox.Show("예약 시간을 확인해주세요");
                    AdminMainForm admin = new AdminMainForm();
                    admin.ShowDialog();
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LoginForm admin = new LoginForm();
                admin.ShowDialog();
                this.Close();
            }
            
        }

        private static DateTime Delay(int MS) { 
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);
            while (AfterWards >= ThisMoment) 
            { 
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            } 
            return DateTime.Now; 
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
                    arrayList.Add(rdr["songurl"] as string);
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
                    starttime.Add(rdr["starttime"] as string);

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

        private void SongPlayForm_Load(object sender, EventArgs e)
        {

        }
    }
}