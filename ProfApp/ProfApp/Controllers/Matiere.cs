
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfApp.Controllers {
    public class Matiere {
        private string code_matiere;
        private string designation;
        private string poids;
        private string code_module;
        public string Code_matiere { get => code_matiere; set => code_matiere = value; }
        public string Designation { get => designation; set => designation = value; }
        public string Code_module { get => code_module; set => code_module = value; }
        public string Poids { get => poids; set => poids = value; }
        public Matiere() { }
        public Matiere(string code_matiere, string designation, string poids, string code_module) : this(designation, poids, code_module) {
            Code_matiere = code_matiere;
        }

        public Matiere(string designation, string poids, string code_module) {
            Code_module = code_module;
            Designation = designation;
            Poids = poids;
        }

        public Dictionary<string, string> ConverObjectToDictionnary() {
            Dictionary<string, string> matiere = new Dictionary<string, string>();

            if (Code_matiere != "") {
                matiere.Add("codeMat", Code_matiere);
            }

            matiere.Add("codeModule", Code_module);
            matiere.Add("designation", Designation);
            matiere.Add("Poids", Poids);

            return matiere;

        }
    }
}
