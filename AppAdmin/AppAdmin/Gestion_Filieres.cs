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
    public partial class Gestion_Filieres : Form
    {
        private FiliereDAO dao = new FiliereDAO("filieres");
        public Gestion_Filieres()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            string codef = codeF.Text;
            string designa = designation.Text;
            if(codef!="" && designa != "")
            {
                dao.Insert(new Filiere(codef,designa));
                MessageBox.Show("Filiere ajouter");
            }
            else
            {
                MessageBox.Show("Remplire tous les champs");
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            string codef = codeF.Text;
            string designa = designation.Text;
            if (codef != "" && designa != "")
            {
                dao.Update(new Filiere(codef,designa)," codeF='"+codef+"'");
                MessageBox.Show("Filiere Modifier");
            }
            else
            {
                MessageBox.Show("Remplire tous les champs");
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (codeF.Text != "")
            {
                dao.Delete("codeF='" + codeF.Text + "'");
                MessageBox.Show("Filiere supprimer");
            }
            else
            {
                MessageBox.Show("Saisire le code filiere");
            }
        }
    }
}
