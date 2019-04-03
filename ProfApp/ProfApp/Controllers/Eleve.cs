using System;
using System.Collections.Generic;

namespace ProfApp.Controllers {
    public class Eleve {
        private string code_fil;
        private string codeElev;
        private string niveau;
        private string nom;
        private string prenom;

        public Eleve(string nom, string prenom, string niveau, string codeElev, string Code_fil) {
            Nom = nom;
            Prenom = prenom;
            Niveau = niveau;
            CodeElev = codeElev;
            this.Code_fil = Code_fil;

        }

        public string Code_fil { get => code_fil; set => code_fil = value; }
        public string CodeElev { get => codeElev; set => codeElev = value; }
        public string Niveau { get => niveau; set => niveau = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public Dictionary<string, string> ConverObjectToDictionnary() {
            Dictionary<string, string> eleve = new Dictionary<string, string>();

            eleve.Add("nom", Nom);
            eleve.Add("prenom", Prenom);
            eleve.Add("codeElev", CodeElev);
            eleve.Add("Code_fil", Code_fil);
            eleve.Add("niveau", Niveau);

            return eleve;

        }


    }
}
