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
    public partial class Gestion_Matieres : Form
    {
        //module dao
        private ModuleDAO moduleDao = new ModuleDAO("modules");
        //matiere dao
        private MatiereDAO matiereDao = new MatiereDAO("matieres");
        public Gestion_Matieres()
        {
            InitializeComponent();
        }

        private void nombreMatieres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code_m = codeM.Text;
            string designation = Designation.Text;
            string designation1 = Designation1.Text;
            string designation2 = Designation2.Text;
            string designation3 = Designation3.Text;
            string code_f = codeF.Text;
            string niveau = Niveau.Text;
            string nombre_m = nombreMatieres.Text;
            string semestre = Semestre.Text;
            string code_m1 = codeM1.Text;
            string code_m2 = codeM2.Text;
            string code_m3 = codeM3.Text;
            string poid1 = Poids1.Text;
            string poid2 = Poids2.Text;
            string poid3 = Poids3.Text;
            if (code_m != "" && designation != "" && code_f!="" && semestre != "" && nombre_m != "" && niveau !="")
            {
                //etape 1 
                //inserer module dans la table modules

                moduleDao.Insert(new Module(code_m,designation,niveau, nombre_m, semestre,code_f));
                //etape2
                //inserer matieres
                //matiere 1
                if (code_m1!="" && designation1!="" && poid1!="")
                {
                    matiereDao.Insert(new Matiere(code_m1,designation1,poid1,code_m));
                }
                //matiere 2
                if (code_m2 != "" && designation2 != "" && poid2 != "")
                {
                    matiereDao.Insert(new Matiere(code_m2, designation2, poid2, code_m));
                }
                //matiere 3
                if (code_m3 != "" && designation3 != "" && poid3 != "")
                {
                    matiereDao.Insert(new Matiere(code_m3, designation3, poid3, code_m));
                }
                MessageBox.Show("Module ajouter");
            }
            else
            {
                MessageBox.Show("Remplire tous les champs nécissaire");
            }

        }
    }
}
