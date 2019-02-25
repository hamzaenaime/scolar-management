﻿using System;
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

                modules.Columns.Add(c0);
                modules.Columns.Add(c1);
                modules.Columns.Add(c2);
                modules.Columns.Add(c3);
                modules.Columns.Add(c4);
                modules.Columns.Add(c5);


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
                DataGridViewButtonColumn supprimer = new DataGridViewButtonColumn();

                matieres.Columns.Add(c0);
                matieres.Columns.Add(c1);
                matieres.Columns.Add(c2);
                matieres.Columns.Add(c3);


                //set datagridview buttons
                Matieres.Columns.Add(modifier);
                Matieres.Columns.Add(supprimer);
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
            if (e.ColumnIndex == 2)
            {
                //show matieres
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
            }
            else
            {
                MessageBox.Show("Remplire tous les champs nécissaire");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (codeM.Text != "")
            {
                matiereDao.Delete(" codeModule='"+codeM.Text+"'");
                moduleDao.Delete(" codeModule='"+ codeM.Text + "'");
                MessageBox.Show("Module supprimer");
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
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
            if (code_m != "" && designation != "" && code_f != "" && semestre != "" && nombre_m != "" && niveau != "")
            {
                //etape 1 
                //inserer module dans la table modules
                moduleDao.Update(new Module(designation, niveau, nombre_m, semestre, code_f), " codeModule='"+code_m+"'");
                //etape2
                //inserer matieres
                //matiere 1
                if (code_m1 != "" && designation1 != "" && poid1 != "")
                {
                    matiereDao.Update(new Matiere(designation1, poid1, code_m)," codeModule='"+code_m+"'");
                }
                //matiere 2
                if (code_m2 != "" && designation2 != "" && poid2 != "")
                {
                    matiereDao.Update(new Matiere(designation2, poid2, code_m), " codeModule='" + code_m + "'");
                }
                //matiere 3
                if (code_m3 != "" && designation3 != "" && poid3 != "")
                {
                    matiereDao.Update(new Matiere(designation3, poid3, code_m), " codeModule='" + code_m + "'");
                }
                MessageBox.Show("Module Modifier");
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
