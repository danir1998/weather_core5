using FetchConsole.Data;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Timers;

namespace FetchConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Grad DATA!!!");
            init();
        }


        private static void init()
        {
            Timer timer = new Timer();
            timer.Interval = 10000 * 1;
            timer.Elapsed += Timer_Elapsed; ;
            timer.Start();

            Console.ReadKey(); //do not close console...
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            saveToDb();
        }

        private static Root fetchData()
        {
            var client = new RestClient("http://api.airvisual.com/v2/nearest_city?lat=36.62&lon=34.20&key=f683865c-a0fe-463f-9b32-99e7455cf38d");

            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AlwaysMultipartFormData = true;
            IRestResponse response = client.Execute(request);

            var settings = new JsonSerializerSettings
            {
                DateFormatString = "yyyy-MM-ddTH:mm:ss.fffZ",
                DateTimeZoneHandling = DateTimeZoneHandling.Utc
            };
            Root json = JsonConvert.DeserializeObject<Root>(response.Content, settings);

            return json;
        }


        private static void saveToDb()
        {
            Console.WriteLine("Grabbing new data... Hammm....");

            Root dt = fetchData();

            Console.WriteLine("{0} {1} °C {2}", dt.data.city, dt.data.current.weather.tp, dt.data.current.weather.ts);

            using (WeatherContext db = new WeatherContext())
            {
                Weather item = new Weather();
                item.hu = dt.data.current.weather.hu;
                item.tp = dt.data.current.weather.tp;
                item.pr = dt.data.current.weather.pr;
                item.wd = dt.data.current.weather.wd;
                item.ic = dt.data.current.weather.ic;
                item.city = dt.data.city;
                item.state = dt.data.state;
                item.country = dt.data.country;
                item.timestamp = dt.data.current.weather.ts;

                db.Weathers.Add(item);

                if (db.SaveChanges() > 0)
                {
                    Console.WriteLine("New weather saved in the DB =)");
                }
            }

        }
    }
}
