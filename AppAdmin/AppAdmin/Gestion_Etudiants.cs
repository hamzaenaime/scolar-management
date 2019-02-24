using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionNotes;

namespace AppAdmin
{
    public partial class Gestion_Etudiants : Form
    {
        private FiliereDAO filiereDao = new FiliereDAO("filieres");
        public Gestion_Etudiants()
        {
            InitializeComponent();
        }

        private void Gestion_Etudiants_Load(object sender, EventArgs e)
        {
            List<Dictionary<string,string>> filieres= filiereDao.Select("select * from filieres");
            //Console.WriteLine(filieres.Count);
            foreach (Dictionary<string, string> filiere in filieres)
            {
                Filieres.Items.Add(filiere["codeF"]);
            }
        }
    }
}
