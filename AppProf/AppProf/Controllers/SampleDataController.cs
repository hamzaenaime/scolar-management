using GestionNotes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppProf.Controllers {
    [Route("api/[controller]")]
    public class SampleDataController : Controller {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts() {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        public class WeatherForecast {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF {
                get {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }

    [Route("api/[controller]")]
    public class NotesController : Controller {
        private EleveDAO eleveDAO = new EleveDAO("eleves");
        [HttpGet("[action]")]
        public IEnumerable<NotesTable> LesNotes() {
            //return Enumerable.Range(1, 5).Select(index => new NotesTable(index));
            return Enumerable.Range(1, 5).Select(index => new NotesTable {
                Nom = "Hamza",
                Prenom = "ENAIME",
                CodeFil = "GINF"
            });
        }

        public class NotesTable {
            private EleveDAO eleveDAO = new EleveDAO("eleves");
            public List<Dictionary<string, string>> Data { get; set; }
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public string CodeFil { get; set; }
            //public NotesTable(int index) {
            //    Data = eleveDAO.Select("select * from eleves;");
            //    Nom = Data.ElementAt(index)["nom"];
            //    Prenom = Data.ElementAt(index)["nom"];
            //    CodeFil = Data.ElementAt(index)["nom"];
            //}
        }
    }
}
