using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfApp.Controllers {
    public class Filiere {
        private string codeF;
        private string designation;
        public Filiere(string code, string desi) {
            CodeF = code;
            Designation = desi;
        }

        public string Designation { get => designation; set => designation = value; }
        public string CodeF { get => codeF; set => codeF = value; }

        public Dictionary<string, string> ConverObjectToDictionnary() {
            Dictionary<string, string> filiere = new Dictionary<string, string>();

            filiere.Add("codeF", CodeF);
            filiere.Add("designation", Designation);

            return filiere;
        }
    }
}
