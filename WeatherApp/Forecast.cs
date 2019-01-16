using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class Forecast
    {
        public city city { get; set; }
        
        public List<list> list { get; set; }

    }

    public class list
    {
        public double dt { get; set; }
        public city city { get; set; }
        public main main { get; set; }
    }


    public class main
    {
        public double temp { get; set; }

        public int humidity { get; set; }
    }

    public class city
    {
        public string name { get; set; }
        public string country { get; set; }
    }

    




}
