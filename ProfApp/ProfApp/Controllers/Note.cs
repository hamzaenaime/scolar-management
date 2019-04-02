
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProf.Controllers {
    public class Note {
        private string code_matiere;
        private string lanote;
        private string code_eleve;
        public string Code_matiere { get => code_matiere; set => code_matiere = value; }
        public string Lanote { get => lanote; set => lanote = value; }
        public string Code_eleve { get => code_eleve; set => code_eleve = value; }
        public Note() { }
        public Note(string code_eleve, string code_matiere, string note) {
            Code_matiere = code_matiere;
            Code_eleve = code_eleve;
            lanote = note;

        }

        public Dictionary<string, string> ConverObjectToDictionnary() {
            Dictionary<string, string> note = new Dictionary<string, string>();

            note.Add("codeElev", Code_eleve);
            note.Add("codeMat", Code_matiere);
            note.Add("note", Lanote);

            return note;

        }
    }
}
