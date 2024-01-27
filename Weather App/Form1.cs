using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace Weather_App
{
    public partial class btn : Form
    {
        public btn()
        {
            InitializeComponent();
        }
        string APIKEY = "9828486cda8a1ebce9c0f6dc54d16a78";

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            getWeather();
        }
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", tbcity.Text, APIKEY);
                var json = web.DownloadString(url);
                weatherinfo.root Info = JsonConvert.DeserializeObject<weatherinfo.root>(json);

                picICON.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                lblMaxV.Text = Info.main.temp_max.ToString();
                lblConV.Text = Info.weather[0].main;
                lblDetailV.Text = Info.weather[0].description;
                lblSriseV.Text = Info.sys.sunrise.ToString();
                lblSsetV.Text = Info.sys.sunset.ToString();
                lblWV.Text = Info.wind.speed.ToString();
                lblHV.Text = Info.main.humidity.ToString();
                lblPV.Text = Info.main.pressure.ToString();

            }
        }
    }
}
