﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppProf.Controllers {
    //[Route("api/[controller]")]
    public class MesNotesController : Controller {
        //private EleveDAO eleveDAO = new EleveDAO("eleves");

        [Route("api/MesNotes/LesNotes")]
        [HttpGet]
        public IEnumerable<NotesTable> LesNotes() {
            //public Dictionary<string, string>
            IEnumerable<Dictionary<string, string>> data;
            return Enumerable.Range(1, 5).Select(index => new NotesTable(index));
        }


        public class NotesTable {
            private EleveDAO eleveDAO = new EleveDAO("eleves");
            public List<Dictionary<string, string>> Data { get; set; }
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public string CodeFil { get; set; }
            public NotesTable(int index) {
                eleveDAO = new EleveDAO("eleves");
                Data = eleveDAO.Select("select * from eleves;");
                Nom = Data.ElementAt(index)["nom"];
                Prenom = Data.ElementAt(index)["prenom"];
                CodeFil = Data.ElementAt(index)["code_Fil"];
            }
        }
    }
}