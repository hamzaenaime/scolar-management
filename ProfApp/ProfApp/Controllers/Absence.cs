using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfApp.Controllers {
    public class Absence {
        private string codeEleve;
        private string nom;
        private string prenom;
        private string nbr_absences;
        private string semaine;

        public Absence() { }

        public Absence(string codeEleve, string nom, string prenom) {
            this.codeEleve = codeEleve;
            this.nom = nom;
            this.prenom = prenom;
            //this.nbr_absences = nbr_absences;
            //this.semaine = semaine;
        }

        public string CodeEleve { get => codeEleve; set => codeEleve = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Nbr_absences { get => nbr_absences; set => nbr_absences = value; }
        public string Semaine { get => semaine; set => semaine = value; }

        public Dictionary<string, string> ConverObjectToDictionnary() {
            Dictionary<string, string> absence = new Dictionary<string, string>();
            absence.Add("codeElev", CodeEleve);
            absence.Add("nom", Nom);
            absence.Add("prenom", Prenom);
            absence.Add("nbr_absences", Nbr_absences);
            //absence.Add("semaine", Nbr_absences);

            return absence;

        }
    }
}
