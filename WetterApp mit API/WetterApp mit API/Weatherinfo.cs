using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetterApp_mit_API
{
    internal class Weatherinfo
    {
        #region 
        // Class == Werte auslesen \\
        public class coord
        {
            public double lon { get; set;}
            public double lat { get; set;} 
        }
        #endregion

        #region 
        // Class == Werte auslesen\\
        public class main
        {
            public double temp { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }

        }
        #endregion

        #region 
        // Class == Wind auslesen\\
        public class wind
        {
            public double speed { get; set; }
        }
        #endregion

        #region 
        // Class == weather auslesen\\
        public class weather
        {
            public string icon {  get; set; }
            public string main { get; set; } //erste Posi List 0 wetter bild(cloud)
            public string description { get; set; }
        }
        #endregion

        #region 
        // Class == ausgeben bzw übergeben\\
        public class root
        {
            public coord coord { get; set; }
            public main main { get; set; }
            public wind wind { get; set; }
            public List <weather> weather { get; set; }
        }
        #endregion
    }
}
/*  Ausgelesener Wert aus der website ist in klassen unterteilt bzw. definiert
    weather ist eine List "[]"

 * {
    "coord": {
        "lon": 10.5,
        "lat": 51.5
    },
    "weather": [
        {
            "id": 804,
            "main": "Clouds",
            "description": "overcast clouds",
            "icon": "04n"
        }
    ],
    "base": "stations",
    "main": {
        "temp": 11.13,
        "feels_like": 10.73,
        "temp_min": 7.81,
        "temp_max": 11.93,
        "pressure": 1017,
        "humidity": 93,
        "sea_level": 1017,
        "grnd_level": 980
    },
    "visibility": 10000,
    "wind": {
        "speed": 1.58,
        "deg": 142,
        "gust": 1.52
    },
    "clouds": {
        "all": 100
    },
    "dt": 1708021240,
    "sys": {
        "type": 2,
        "id": 197911,
        "country": "DE",
        "sunrise": 1707978804,
        "sunset": 1708014670
    },
    "timezone": 3600,
    "id": 2921044,
    "name": "Germany",
    "cod": 200
}
*/