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
        //filiere dao
        private FiliereDAO filiereDao = new FiliereDAO("filieres");
        //data table matieres
        DataTable matieres = new DataTable();
        //data table modules
        DataTable modules = new DataTable();
        public Gestion_Matieres()
        {
            InitializeComponent();
            LoadTableModules();
            FillTableModules();
            LoadTableMatieres();
            FillTableMatieres();
            Modules.CellClick += Modules_CellClick;
        }

        private void LoadTableModules()
        {
            try
            {

                DataColumn c0 = new DataColumn("code module");
                DataColumn c1 = new DataColumn("designation");
                DataColumn c2 = new DataColumn("niveau");
                DataColumn c3 = new DataColumn("nombre de matieres");
                DataColumn c4 = new DataColumn("semestre");
                DataColumn c5 = new DataColumn("code filiere");
                DataGridViewButtonColumn modifier = new DataGridViewButtonColumn();
                DataGridViewButtonColumn supprimer = new DataGridViewButtonColumn();
                c0.ReadOnly = true;
                c5.ReadOnly = true;
                modules.Columns.Add(c0);
                modules.Columns.Add(c1);
                modules.Columns.Add(c2);
                modules.Columns.Add(c3);
                modules.Columns.Add(c4);
                modules.Columns.Add(c5);
                Modules.AllowUserToAddRows = false;
                Modules.RowHeadersVisible = false;


                //set datagridview buttons
                Modules.Columns.Add(modifier);
                Modules.Columns.Add(supprimer);
                modifier.Text = "Modifier";
                modifier.Name = "";
                modifier.UseColumnTextForButtonValue = true;
                supprimer.Text = "Supprimer";
                supprimer.Name = "";
                supprimer.UseColumnTextForButtonValue = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillTableModules()
        {
            modules.Clear();
            List<Dictionary<string, string>> filieres = moduleDao.Select("select * from modules");
            foreach (Dictionary<string, string> element in filieres)
            {
                DataRow row = modules.NewRow();
                row["code module"] = element["codeModule"];
                row["designation"] = element["designation"];
                row["niveau"] = element["niveau"];
                row["nombre de matieres"] = element["nbr_matieres"];
                row["semestre"] = element["semestre"];
                row["code filiere"] = element["code_Fil"];
                modules.Rows.Add(row);
            }
            //set table
            Modules.DataSource = modules;
        }

        private void LoadTableMatieres()
        {
            try
            {

                DataColumn c0 = new DataColumn("code matiere");
                DataColumn c1 = new DataColumn("designation");
                DataColumn c2 = new DataColumn("poids");
                DataColumn c3 = new DataColumn("code module");
                DataGridViewButtonColumn modifier = new DataGridViewButtonColumn();
                c0.ReadOnly = true;
                c3.ReadOnly = true;
                matieres.Columns.Add(c0);
                matieres.Columns.Add(c1);
                matieres.Columns.Add(c2);
                matieres.Columns.Add(c3);
                Matieres.AllowUserToAddRows = false;
                Matieres.RowHeadersVisible = false;

                //set datagridview buttons
                Matieres.Columns.Add(modifier);
                modifier.Text = "Modifier";
                modifier.Name = "";
                modifier.UseColumnTextForButtonValue = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillTableMatieres()
        {
            matieres.Clear();
            List<Dictionary<string, string>> les_matieres = matiereDao.Select("select * from matieres");
            foreach (Dictionary<string, string> element in les_matieres)
            {
                DataRow row = matieres.NewRow();
                row["code matiere"] = element["codeMat"];
                row["designation"] = element["designation"];
                row["poids"] = element["poids"];
                row["code Module"] = element["codeModule"];
                matieres.Rows.Add(row);
            }
            //set table
            Matieres.DataSource = matieres;
        }
        private void Modules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //module delete
            if (e.ColumnIndex == 1)
            {
                string codeModule = Modules[2, e.RowIndex].Value.ToString();
                MessageBox.Show(codeModule);
                matiereDao.Delete(" codeModule='" + codeModule + "'");
                moduleDao.Delete(" codeModule='" + codeModule + "'");
                MessageBox.Show("Module supprimer");
                FillTableMatieres();
                FillTableModules();
            }
            //module edit
            if(e.ColumnIndex == 0)
            {
                string codeModule = Modules[2, e.RowIndex].Value.ToString();
                string designation = Modules[3, e.RowIndex].Value.ToString();
                string niveau = Modules[4, e.RowIndex].Value.ToString();
                string nbr_matieres = Modules[5, e.RowIndex].Value.ToString();
                string semestre = Modules[6, e.RowIndex].Value.ToString();
                string codeFiliere = Modules[7, e.RowIndex].Value.ToString();
                moduleDao.Update(new Module(codeModule,designation,niveau,nbr_matieres,semestre,codeFiliere), " codeModule='" + codeModule + "'");
                MessageBox.Show("Module modifier");
                FillTableMatieres();
                FillTableModules();
            }
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
                FillTableMatieres();
                FillTableModules();
            }
            else
            {
                MessageBox.Show("Remplire tous les champs nécissaire");
            }

        }



        private void Gestion_Matieres_Load(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> filieres = filiereDao.Select("select * from filieres");
            //Console.WriteLine(filieres.Count);
            foreach (Dictionary<string, string> filiere in filieres)
            {
                codeF.Items.Add(filiere["codeF"]);
            }
        }
    }
}
