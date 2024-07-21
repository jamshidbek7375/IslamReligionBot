using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace C__IslamBot
{

    public class Data
    {
        public Timings timings { get; set; }
        public Date date { get; set; }
    }

    public class Date
    {
        public string readable { get; set; }
        public Hijri hijri { get; set; }
        public Gregorian gregorian { get; set; }
    }

    public class Gregorian
    {
        public string day { get; set; }
        public Weekday weekday { get; set; }
    }

    public class Hijri
    {
        public string date { get; set; }
        public Weekday weekday { get; set; }
        public Month month { get; set; }
        public string year { get; set; }
    }

    public class Month
    {
        public int number { get; set; }
        public string en { get; set; }
        public string ar { get; set; }
    }

    public class Params
    {
        public int Fajr { get; set; }
        public int Isha { get; set; }
    }

    public class Root
    {
        public Data data { get; set; }
    }

    public class Timings
    {
        [JsonPropertyName("Fajr")]
        public string Fajr { get; set; }
        [JsonPropertyName("Sunrise")]
        public string Sunrise { get; set; }
        [JsonPropertyName("Dhuhr")]
        public string Dhuhr { get; set; }
        [JsonPropertyName("Asr")]
        public string Asr { get; set; }
        [JsonPropertyName("Sunset")]
        public string Sunset { get; set; }
        [JsonPropertyName("Maghrib")]
        public string Maghrib { get; set; }
        [JsonPropertyName("Isha")]
        public string Isha { get; set; }
        [JsonPropertyName("Imsak")]
        public string Imsak { get; set; }
        [JsonPropertyName("Midnight")]
        public string Midnight { get; set; }
        [JsonPropertyName("Firstthird")]
        public string Firstthird { get; set; }
        [JsonPropertyName("Lastthird")]
        public string Lastthird { get; set; }
    }

    public class Weekday
    {

        public string En { get; set; }
        public string Ar { get; set; }
    }

}
