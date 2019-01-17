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
        const string API_KEY_FORECAST = "542ffd081e67f4512b705f89d2a611b2";
        string city = "";
        
		public Form1()
		{
			InitializeComponent();
            getWeather("Krakow");
            getForecast("Krakow");
			timer1.Tick += new EventHandler(this.timer1_Tick);
			timer1.Start();
			
		}


        void getWeather(string city)
        {
            WebClient web = new WebClient();
            string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&&appid={1}&units=metric&cnt=6", city, API_KEY);
            var json = web.DownloadString(url);
            var result = JsonConvert.DeserializeObject<Weather>(json);
            Weather output = result;

			setCurrentWeatherIcon(output);
			label3.Text = string.Format(DateTime.Now.ToString("HH:mm"));
			label4.Text = string.Format(DateTime.Now.ToString("dd/MM/yyyy"));
			label1.Text = string.Format("{0}", output.name);
            label5.Text = string.Format("{0}\u00B0C", Math.Round(output.main.temp));
            label6.Text = string.Format("Wilgotność: {0}%", output.main.humidity);
            label2.Text = string.Format("{0}", output.sys.country);


        }

        void getForecast(string city)
        {
            WebClient web = new WebClient();
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&units=metric&cnt=5&APPID={1}", city,API_KEY_FORECAST);
            var json = web.DownloadString(url);
            var result = JsonConvert.DeserializeObject<Forecast>(json);
            Forecast output = result;

			label8.Text = string.Format(DateTime.Now.AddDays(1).ToString("dd/MM/yyyy"));
			label11.Text = string.Format(DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"));
			label14.Text = string.Format(DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"));
			label17.Text = string.Format(DateTime.Now.AddDays(4).ToString("dd/MM/yyyy"));

			label7.Text = string.Format("{0}", output.city.name);
            label9.Text = string.Format("{0}\u00B0C", Math.Round(output.list[1].temp.day));

            label12.Text = string.Format("{0}", output.city.name);
            label10.Text = string.Format("{0}\u00B0C", Math.Round(output.list[2].temp.day));

            label15.Text = string.Format("{0}", output.city.name);
            label13.Text = string.Format("{0}\u00B0C", Math.Round(output.list[3].temp.day));

            label18.Text = string.Format("{0}", output.city.name);
            label16.Text = string.Format("{0}\u00B0C", Math.Round(output.list[4].temp.day));


        }

        private void button1_Click(object sender, EventArgs e)
        {
			
			getForecast("Krakow");
            getWeather("Krakow");
        }

		private void timer1_Tick(object sender, EventArgs e)
		{
			label3.Text = DateTime.Now.ToString("HH:mm");
			label4.Text = string.Format(DateTime.Now.ToString("dd/MM/yyyy"));
		}

		private void setCurrentWeatherIcon(Weather json)
		{
			checkIfCloudly(json);
			checkIfSnowy(json);
			checkIfSunny(json);
			checkIfFewClouds(json);
			checkIfRainy(json);
			checkIfFog(json);
			checkIfThunder(json);
		}

		private void checkIfSunny(Weather json)
		{
			if (json.weather[0].id == 800)
			{
				pictureBox1.Image = WeatherApp.Properties.Resources.sun;
			}
		}

		private void checkIfCloudly(Weather json)
		{
			if (json.weather[0].id > 801)
			{
				pictureBox1.Image = WeatherApp.Properties.Resources.clouds;
			}
		}

		private void checkIfFewClouds(Weather json)
		{
			if (json.weather[0].id == 801)
			{
				pictureBox1.Image = WeatherApp.Properties.Resources.fewclouds;
			}
		}

		private void checkIfRainy(Weather json)
		{
			if (json.weather[0].id >= 300 && json.weather[0].id <= 531)
			{
				pictureBox1.Image = WeatherApp.Properties.Resources.rainBig;
			}
		}

		private void checkIfThunder(Weather json)
		{
			if (json.weather[0].id >= 200 && json.weather[0].id <= 232)
			{
				pictureBox1.Image = WeatherApp.Properties.Resources.flash;
			}
		}

		private void checkIfFog(Weather json)
		{
			if (json.weather[0].id >= 701 && json.weather[0].id <= 781)
			{
				pictureBox1.Image = WeatherApp.Properties.Resources.wave;
			}
		}

		private void checkIfSnowy(Weather json)
		{
			if (json.weather[0].id >= 600 && json.weather[0].id <= 622)
			{
				pictureBox1.Image = WeatherApp.Properties.Resources.snow;
			}
		}
	}

	





}
