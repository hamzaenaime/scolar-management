using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNotes
{
    public class Filiere
    {
        private string codeF;
        private string designation;
        public Filiere(string code,string desi)
        {
            codeF = code;
            designation = desi;
        }

        public Dictionary<string, string> ConverObjectToDictionnary()
        {
            Dictionary<string, string> filiere = new Dictionary<string, string>();

            filiere.Add("codeF", codeF);
            filiere.Add("designation", designation);

            return filiere;
        }
    }
}
