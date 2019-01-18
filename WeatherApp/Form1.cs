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
        const string API_KEY = "542ffd081e67f4512b705f89d2a611b2";
        
		public Form1()
		{
			InitializeComponent();
            getWeather("Krakow");
			//refresh date and time
			refreshDateTime.Tick += new EventHandler(this.refreshDateTime_Tick);
			refreshDateTime.Start();
			
		}


        void getWeather(string city)
        {
            WebClient web = new WebClient();
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&units=metric&cnt=5&APPID={1}", city, API_KEY);
			var json = web.DownloadString(url);
            var result = JsonConvert.DeserializeObject<Weather>(json);
            Weather output = result;

			//date and time
			timeLabel.Text = string.Format(DateTime.Now.ToString("HH:mm"));
			dateLabel.Text = string.Format(DateTime.Now.ToString("dd/MM/yyyy"));

			//actual weather
			actualWeatherCity.Text = string.Format("{0}", output.city.name);
			country.Text = string.Format("{0}", output.city.country);
            actualWeatherTemp.Text = string.Format("{0}\u00B0C", Math.Round(output.list[0].temp.day));
            actualWeatherHum.Text = string.Format("Wilgotność: {0}%", output.list[0].humidity);
			setCurrentWeatherIcon(output, actualWeatherPictureBox, 0);

			//forecast tomorrow
			forecast1DateLabel.Text = string.Format(DateTime.Now.AddDays(1).ToString("dd/MM/yyyy"));
			forecast1CityLabel.Text = string.Format("{0}", output.city.name);
			forecast1TempLabel.Text = string.Format("{0}\u00B0C", Math.Round(output.list[1].temp.day));
			setCurrentWeatherIcon(output, forecast1PictureBox, 1);

			//forecast for 2 days
			forecast2DateLabel.Text = string.Format(DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"));
			forecast2CityLabel.Text = string.Format("{0}", output.city.name);
			forecast2TempLabel.Text = string.Format("{0}\u00B0C", Math.Round(output.list[2].temp.day));
			setCurrentWeatherIcon(output, forecast2PictureBox, 2);

			//forecast for 3 days
			forecast3DateLabel.Text = string.Format(DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"));
			forecast3CityLabel.Text = string.Format("{0}", output.city.name);
			forecast3TempLabel.Text = string.Format("{0}\u00B0C", Math.Round(output.list[3].temp.day));
			setCurrentWeatherIcon(output, forecast3PictureBox, 3);

			//forecast for 4 days
			forecast4DateLabel.Text = string.Format(DateTime.Now.AddDays(4).ToString("dd/MM/yyyy"));
			forecast4CityLabel.Text = string.Format("{0}", output.city.name);
			forecast4TempLabel.Text = string.Format("{0}\u00B0C", Math.Round(output.list[4].temp.day));
			setCurrentWeatherIcon(output, forecast4PictureBox, 4);
		}


        private void refreshButton_Click(object sender, EventArgs e)
        {
            getWeather("Krakow");
        }

		private void refreshDateTime_Tick(object sender, EventArgs e)
		{
			timeLabel.Text = DateTime.Now.ToString("HH:mm");
			dateLabel.Text = string.Format(DateTime.Now.ToString("dd/MM/yyyy"));
		}

		private void setCurrentWeatherIcon(Weather json, PictureBox pic, int day)
		{
			checkIfCloudly(json, pic, day);
			checkIfSnowy(json, pic, day);
			checkIfSunny(json, pic, day);
			checkIfFewClouds(json, pic, day);
			checkIfRainy(json, pic, day);
			checkIfFog(json, pic, day);
			checkIfThunder(json, pic, day);
		}

		private void checkIfSunny(Weather json, PictureBox pic, int day)
		{
			if (json.list[day].weather[0].id == 800)
			{
				pic.Image = WeatherApp.Properties.Resources.sunny;
			}
		}

		private void checkIfCloudly(Weather json, PictureBox pic, int day)
		{
			if (json.list[day].weather[0].id > 801)
			{
				pic.Image = WeatherApp.Properties.Resources.clouds;
			}
		}

		private void checkIfFewClouds(Weather json, PictureBox pic, int day)
		{
			if (json.list[day].weather[0].id == 801)
			{
				pic.Image = WeatherApp.Properties.Resources.fewclouds;
			}
		}

		private void checkIfRainy(Weather json, PictureBox pic, int day)
		{
			if (json.list[day].weather[0].id >= 300 && json.list[day].weather[0].id <= 531)
			{
				pic.Image = WeatherApp.Properties.Resources.rain;
			}
		}

		private void checkIfThunder(Weather json, PictureBox pic, int day)
		{
			if (json.list[day].weather[0].id >= 200 && json.list[day].weather[0].id <= 232)
			{
				pic.Image = WeatherApp.Properties.Resources.flash;
			}
		}

		private void checkIfFog(Weather json, PictureBox pic, int day)
		{
			if (json.list[day].weather[0].id >= 701 && json.list[day].weather[0].id <= 781)
			{
				pic.Image = WeatherApp.Properties.Resources.wave;
			}
		}

		private void checkIfSnowy(Weather json, PictureBox pic, int day)
		{
			if (json.list[day].weather[0].id >= 600 && json.list[day].weather[0].id <= 622)
			{
				pic.Image = WeatherApp.Properties.Resources.snow;
			}
		}
	}

	





}
