using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppProf.Controllers {
    //[Route("api/[controller]")]
    public class MesNotesController : Controller {
        private EleveDAO eleveDAO = null;
        public List<Dictionary<string, string>> Data = new List<Dictionary<string, string>>();

        [Route("api/MesNotes/LesNotes")]
        [HttpGet]
        public IEnumerable<Etudiant> LesNotes() {
            return Enumerable.Range(1, 5).Select(index => new Etudiant(index));
        }
        [Route("api/MesNotes/filieres")]
        [HttpGet]
        public List<string> filieres() {
            eleveDAO = new EleveDAO("filieres");
            List<Dictionary<string, string>> filieres = new List<Dictionary<string, string>>();
            filieres = eleveDAO.Select("select * from filieres");
            List<string> les_filieres = new List<string>();
            foreach (Dictionary<string, string> elt in filieres) {
                les_filieres.Add(elt["codeF"]);
            }

            return les_filieres;
        }


        public class Etudiant {
            private EleveDAO eleveDAO = new EleveDAO("eleves");
            public List<Dictionary<string, string>> Data = new List<Dictionary<string, string>>();
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public string CodeFil { get; set; }
            public Etudiant(int index) {
                eleveDAO = new EleveDAO("eleves");
                Data = eleveDAO.Select("select * from eleves");
                int i = 0;
                foreach (Dictionary<string, string> eleve in Data) {
                    if (i == index - 1) {
                        Nom = eleve["nom"];
                        Prenom = eleve["prenom"];
                        CodeFil = eleve["code_Fil"];
                    }
                }

            }
        }
    }
}