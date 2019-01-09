using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;


namespace WeatherApp
{
	public partial class Form1 : Form
	{
        const string API_KEY = "294b51a2e5a87020ef4c90fd11502129";
        string city = "";
        
		public Form1()
		{
			InitializeComponent();
            getWeather("Krakow");
	 	}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void getWeather(string city)
        {
            WebClient web = new WebClient();
            string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}",city,API_KEY);
            var json = web.DownloadString(url);
            var result = JsonConvert.DeserializeObject<root>(json);
            root output = result;

            label1.Text = string.Format("{0}",output.name);
            label5.Text = string.Format("{0}\u2103", output.main.temperature);
            label6.Text = string.Format("Wilgotność: {0}%", output.main.humidity);
            label2.Text = string.Format("{0}", output.sys.country);
            


        }

        
    }



    public class main {

        public int temperature{get;set;}
        public int humidity{get;set;}
    }

    public class root
    {
        public string name { get; set; }
        public main main { get; set; }
        public sys sys { get; set; }
    }

    public class sys
    {
        public string country { get; set; }
    }



}
