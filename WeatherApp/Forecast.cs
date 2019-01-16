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
        public temp temp { get; set; }
    }


    public class temp
    {
        public double day { get; set; }

        
    }

    public class city
    {
        public string name { get; set; }
        public string country { get; set; }
    }

    




}
