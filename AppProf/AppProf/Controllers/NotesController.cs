using GestionNotes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppProf.Controllers {
    [Route("api/[controller]")]
    public class MesNotesController : Controller {
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
