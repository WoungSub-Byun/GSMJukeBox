using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
<<<<<<<< HEAD:GSMJukeBox/SongPlayForm.cs
        public SongPlayForm()
========
<<<<<<< Updated upstream:GSMJukeBox/Setting.cs
        public Setting()
=======
        int cnt = 0;
        DateTime dateTime = DateTime.Now;
        string constr = "SERVER=127.0.0.1,1234; DATABASE=gsmjukebox;UID=shin;PASSWORD='1234'";
        public SongPlayForm()
>>>>>>> Stashed changes:GSMJukeBox/SongPlayForm.cs
>>>>>>>> origin/wonjoon:GSMJukeBox/Setting.cs
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
            List<string> urls = getURL();

            var embed = "<html><head>"+
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>"+
            "</head><body>" +
            "<iframe width=\"300\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";
            var url = urls[0];
            this.webBrowser1.DocumentText = string.Format(embed, url);
        }

        public List<String> getURL()
        {
            List<String> arrayList = new List<String>();
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();

                string sql = "select songurl from reservedsong;";
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = sql;
                SqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    arrayList.Add(rdr["songurl"] as String);

                }
                rdr.Close();

            }
            return arrayList;
        }
    }
}
