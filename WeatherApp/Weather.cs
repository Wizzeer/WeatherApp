using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class Weather
    {
        public string name { get; set; }

        public main main { get; set; }

        public sys sys { get; set; }


        
    }

    public class main
    {
        public double temp { get; set; }
        public double humidity { get; set; }

    }

    public class sys
    {
        public string country { get; set; }
    }
}
