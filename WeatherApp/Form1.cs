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
            string url = string.Format("https://api.openweathermap.org/data/2.5/forecast?q={0}&units=metric&appid={1}", city,API_KEY);
            var json = web.DownloadString(url);
            var result = JsonConvert.DeserializeObject<Forecast>(json);
            Forecast output = result;

            label1.Text = string.Format("{0}",output.city.name);
            label5.Text = string.Format("{0}\u2103", output.list[0].main.temp);
            label6.Text = string.Format("Wilgotność: {0}%", output.list[0].main.humidity);
            label2.Text = string.Format("{0}", output.city.country);

            label7.Text = string.Format("{0}", output.city.name);
            label9.Text = string.Format("{0}\u2103", output.list[1].main.temp);

            label12.Text = string.Format("{0}", output.city.name);
            label10.Text = string.Format("{0}\u2103", output.list[2].main.temp);

            label15.Text = string.Format("{0}", output.city.name);
            label13.Text = string.Format("{0}\u2103", output.list[3].main.temp);

            label18.Text = string.Format("{0}", output.city.name);
            label16.Text = string.Format("{0}\u2103", output.list[0].main.temp);


        }

        

        
    }



    



}
