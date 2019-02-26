using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNotes
{
    public class Module
    {
        private string code_module;
        private string designation;
        private string niveau;
        private string nbr_matieres;
        private string semestre;
        private string code_fil;

        public Module(string code_module, string designation, string niveau, string nbr_matieres, string semestre, string code_fil)
            :this(designation, niveau,nbr_matieres,semestre,code_fil)
        {
            this.code_module = code_module;
        }


        public Module(string designation, string niveau, string nbr_matieres, string semestre, string code_fil)
        {
            this.designation = designation;
            this.niveau = niveau;
            this.nbr_matieres = nbr_matieres;
            this.semestre = semestre;
            this.code_fil = code_fil;

        }

        public Dictionary<string, string> ConverObjectToDictionnary()
        {
            Dictionary<string, string> module = new Dictionary<string, string>();
            if(code_module!="")
                module.Add("codeModule", code_module);
            module.Add("designation", designation);
            module.Add("niveau", niveau);
            module.Add("nbr_matieres", nbr_matieres);
            module.Add("semestre", semestre);
            module.Add("code_Fil", code_fil);

            return module;

        }
    }
}
