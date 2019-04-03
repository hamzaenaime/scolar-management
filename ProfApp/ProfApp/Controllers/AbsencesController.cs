using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfApp.Controllers {
    public class AbsencesController : Controller {
        private EleveDAO eleveDAO = null;
        //get all absences
        [Route("api/absences/{codeMat}")]
        [HttpGet]
        public IEnumerable<Absence> absences(string codeMat) {
            eleveDAO = new EleveDAO("eleves");
            int length = codeMat.Length;
            char niveau = codeMat[length - 3];
            string filiere = codeMat.Substring(0, length - 3);
            string req = "select e.codeElev,e.nom,e.prenom " +
                "from eleves e " +
                " where e.niveau=" + niveau + " and e.code_fil='" + filiere + "';";
            List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();
            data = eleveDAO.Select(req);
            if (data != null) {
                List<Absence> absences_list = new List<Absence>();
                foreach (Dictionary<string, string> elt in data) {
                    Absence a = new Absence(elt["codeElev"], elt["nom"], elt["prenom"]);
                    absences_list.Add(a);
                }
                length = absences_list.Count;
                return Enumerable.Range(0, length).Select(index => new Absence {
                    Nom = absences_list[index].Nom,
                    Prenom = absences_list[index].Prenom,
                    CodeEleve = absences_list[index].CodeEleve
                });
            } else {
                return Enumerable.Range(0, 1).Select(index => new Absence {
                    Nom = "",
                    Prenom = "",
                    CodeEleve = ""
                });
            }
        }
        /*
        //get all absences
        [Route("api/absences/{codeMat}")]
        [HttpGet]
        public IEnumerable<Absence> addAbsence(string codeEleve, string codeMat) {
            absenceDAO = new AbsenceDAO("abseneces");
            /*
            string req = "select a.codeElev,e.nom,e.prenom,a.nbr_absences from eleves e,absences  a"
                + " where e.codeElev=a.codeElev where a.codeMat='" + codeMat + "';";
                
            string req = "";
            List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();
            data = absenceDAO.Select(req);
            List<Absence> absences_list = new List<Absence>();
            foreach (Dictionary<string, string> elt in data) {
                Absence a = new Absence(elt["codeElev"], elt["nom"], elt["prenom"],
                    elt["nbr_absences"]);
                absences_list.Add(a);
            }
            int length = absences_list.Count;
            return Enumerable.Range(0, length).Select(index => new Absence {
                Nom = absences_list[index].Nom,
                Prenom = absences_list[index].Prenom,
                CodeEleve = absences_list[index].CodeEleve,
                Nbr_absences = absences_list[index].Nbr_absences
            });

        }
        */
    }
}