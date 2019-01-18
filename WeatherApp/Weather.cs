using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class Weather
    {
		public city city { get; set; }

		public List<list> list { get; set; }

	}

	public class list
	{
		public temp temp { get; set; }
		public int humidity { get; set; }
		public List<weather> weather { get; set; }
	}

	public class temp
	{
		public double day { get; set; }
	}

	public class weather
	{
		public double id { get; set; }
	}

	public class city
	{
		public string name { get; set; }
		public string country { get; set; }
	}
}
