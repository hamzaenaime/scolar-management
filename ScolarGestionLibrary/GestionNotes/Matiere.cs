
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNotes
{
    public class Matiere
    {
        private string code_matiere;
        private string designation;
        private string poids;
        private string code_module;

        public Matiere(string code_matiere, string designation, string poids, string code_module):this(designation,poids,code_module)
        {
            this.code_matiere = code_matiere;
        }

        public Matiere(string designation, string poids, string code_module)
        {
            this.code_module = code_module;
            this.designation = designation;
            this.poids = poids;
        }

        public Dictionary<string, string> ConverObjectToDictionnary()
        {
            Dictionary<string, string> matiere = new Dictionary<string, string>();

            if(code_matiere != "")
                matiere.Add("codeMat", code_matiere);
            matiere.Add("codeModule", code_module);
            matiere.Add("designation", designation);
            matiere.Add("Poids", poids);

            return matiere;

        }
    }
}
