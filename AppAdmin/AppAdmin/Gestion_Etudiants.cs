﻿using GestionNotes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAdmin {
    public partial class Gestion_Etudiants : Form {
        //filiere dao
        private FiliereDAO filiereDao = new FiliereDAO("Filieres");
        //eleve dao
        private EleveDAO eleveDao = new EleveDAO("Eleves");
        DataTable table = new DataTable();
        public Gestion_Etudiants() {
            InitializeComponent();
            LoadTable();
            FillTable();
            Etudiants.CellClick += Etudiants_CellClick;
        }

        private void LoadTable() {
            try {

                DataColumn c0 = new DataColumn("code eleve");
                DataColumn c1 = new DataColumn("nom");
                DataColumn c2 = new DataColumn("Prenom");
                DataColumn c3 = new DataColumn("niveau");
                DataColumn c4 = new DataColumn("code filiere");
                DataGridViewButtonColumn modifier = new DataGridViewButtonColumn();
                DataGridViewButtonColumn supprimer = new DataGridViewButtonColumn();

                table.Columns.Add(c0);
                table.Columns.Add(c1);
                table.Columns.Add(c2);
                table.Columns.Add(c3);
                table.Columns.Add(c4);


                c0.ReadOnly = true;
                c4.ReadOnly = true;
                Etudiants.AllowUserToAddRows = false;
                Etudiants.RowHeadersVisible = false;


                //set datagridview buttons
                Etudiants.Columns.Add(modifier);
                Etudiants.Columns.Add(supprimer);
                modifier.Text = "Modifier";
                modifier.Name = "";
                modifier.UseColumnTextForButtonValue = true;
                supprimer.Text = "Supprimer";
                supprimer.Name = "";
                supprimer.UseColumnTextForButtonValue = true;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillTable(string conditions = "true") {
            table.Clear();
            string req = "select * from Eleves ";
            if (conditions != "true") {
                req += " where " + conditions;
            }

            List<Dictionary<string, string>> eleves = eleveDao.Select(req);
            foreach (Dictionary<string, string> element in eleves) {
                DataRow row = table.NewRow();
                row["code eleve"] = element["codeElev"];
                row["nom"] = element["nom"];
                row["prenom"] = element["prenom"];
                row["niveau"] = element["niveau"];
                row["code filiere"] = element["code_Fil"];
                table.Rows.Add(row);
            }
            //set table
            Etudiants.DataSource = table;
        }

        private void Gestion_Etudiants_Load(object sender, EventArgs e) {
            List<Dictionary<string, string>> filieres = filiereDao.Select("select * from Filieres");
            //Console.WriteLine(filieres.Count);
            foreach (Dictionary<string, string> filiere in filieres) {
                Filieres.Items.Add(filiere["codeF"]);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            string codeEleve = CodeEleve.Text;
            string nom = Nom.Text;
            string prenom = Prenom.Text;
            string filiere = Filieres.Text;
            string niveau = Niveau.Text;
            if (codeEleve != "" && prenom != "" && prenom != "" && filiere != "" && niveau != "") {
                eleveDao.Insert(new Eleve(nom, prenom, niveau, codeEleve, filiere));
                MessageBox.Show("Eleve Ajouter");
                FillTable();
            } else {
                MessageBox.Show("Remplire tous les champs");
            }
        }
        private void Etudiants_CellClick(object sender, DataGridViewCellEventArgs e) {
            //modifier handler
            if (e.ColumnIndex == 0) {
                string codeElev = Etudiants[2, e.RowIndex].Value.ToString();
                string nom = Etudiants[3, e.RowIndex].Value.ToString();
                string prenom = Etudiants[4, e.RowIndex].Value.ToString();
                string niveau = Etudiants[5, e.RowIndex].Value.ToString();
                string codeF = Etudiants[6, e.RowIndex].Value.ToString();

                //update 
                eleveDao.Update(new Eleve(nom, prenom, niveau, codeElev, codeF), " codeElev='" + codeElev + "'");
                MessageBox.Show("Etudiant Modifier");
                FillTable();
            }
            //supprimer handler
            if (e.ColumnIndex == 1) {
                // get codef
                string codeElev = Etudiants[2, e.RowIndex].Value.ToString();
                // delete
                eleveDao.Delete("codeElev='" + codeElev + "'");
                MessageBox.Show(" Etudiant supprimer");
                FillTable();
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            string codeE = CodeEleve.Text;
            string nom = Nom.Text;
            string prenom = Prenom.Text;
            string filiere = Filieres.Text;
            string niveau = Niveau.Text;
            string conditions = "";
            if (codeE != "") {
                conditions += "codeElev='" + codeE + "' and ";
            }
            if (nom != "") {
                conditions += "nom='" + nom + "' and ";
            }
            if (prenom != "") {
                conditions += "prenom='" + prenom + "' and ";
            }
            if (filiere != "") {
                conditions += "code_Fil='" + filiere + "' and ";
            }
            if (niveau != "") {
                conditions += "niveau=" + niveau + " and ";
            }
            conditions += "true";
            FillTable(conditions);
        }

        private void button1_Click(object sender, EventArgs e) {
            CodeEleve.Text = "";
            Niveau.Text = "";
            Filieres.Text = "";
            Nom.Text = "";
            Prenom.Text = "";
        }
    }
}
