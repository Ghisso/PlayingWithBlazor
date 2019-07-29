using System;
using System.Collections.Generic;

namespace PlayingWithBlazor.Models
{
    public partial class OpenWeatherForecast
    {
        public long Cod { get; set; }
        public double Message { get; set; }
        public long Cnt { get; set; }
        public List<Summary> List { get; set; }
        public City City { get; set; }
    }

    public partial class City
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Coord Coord { get; set; }
        public string Country { get; set; }
        public long Population { get; set; }
        public long Timezone { get; set; }
    }

    public partial class Coord
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
    }

    public partial class Summary
    {
        public long Dt { get; set; }
        public MainClass Main { get; set; }
        public List<Weather> Weather { get; set; }
        public Clouds Clouds { get; set; }
        public Wind Wind { get; set; }
        public Sys Sys { get; set; }
        public DateTimeOffset DtTxt { get; set; }
        public Rain Rain { get; set; }
    }

    public partial class Clouds
    {
        public long All { get; set; }
    }

    public partial class MainClass
    {
        public double Temp { get; set; }
        public double TempMin { get; set; }
        public double TempMax { get; set; }
        public double Pressure { get; set; }
        public double SeaLevel { get; set; }
        public double GrndLevel { get; set; }
        public long Humidity { get; set; }
        public double TempKf { get; set; }
    }

    public partial class Rain
    {
        public double The3H { get; set; }
    }

    public partial class Sys
    {
        public string Pod { get; set; }
    }

    public partial class Weather
    {
        public long Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    public partial class Wind
    {
        public double Speed { get; set; }
        public double Deg { get; set; }
    }

}