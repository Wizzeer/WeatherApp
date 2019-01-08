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

        void getWeather(string city)
        {
            WebClient web = new WebClient();
            string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}",city,API_KEY);
            var json = web.DownloadString(url);
            var result = JsonConvert.DeserializeObject<Pogoda>(json);
            Pogoda output = result;

            


        }
	}
}
