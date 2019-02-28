using GestionNotes;
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
    public partial class Gestion_Filieres : Form {
        private FiliereDAO dao = new FiliereDAO("Filieres");
        DataTable table = new DataTable();
        public Gestion_Filieres() {
            InitializeComponent();
            LoadTable();
            FillTable();
            Filieres.CellClick += Filieres_CellClick;
        }
        private void LoadTable() {
            try {

                DataColumn c0 = new DataColumn("codeF");
                DataColumn c1 = new DataColumn("designation");
                DataGridViewButtonColumn modifier = new DataGridViewButtonColumn();
                DataGridViewButtonColumn supprimer = new DataGridViewButtonColumn();

                table.Columns.Add(c0);
                table.Columns.Add(c1);


                c0.ReadOnly = true;
                Filieres.AllowUserToAddRows = false;
                Filieres.RowHeadersVisible = false;


                //set datagridview buttons
                Filieres.Columns.Add(modifier);
                Filieres.Columns.Add(supprimer);
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

        private void FillTable() {
            table.Clear();
            List<Dictionary<string, string>> filieres = dao.Select("select * from Filieres");
            foreach (Dictionary<string, string> element in filieres) {
                DataRow row = table.NewRow();
                row["codeF"] = element["codeF"];
                row["designation"] = element["designation"];
                table.Rows.Add(row);
            }
            //set table
            Filieres.DataSource = table;
        }


        private void Ajouter_Click(object sender, EventArgs e) {
            string codef = codeF.Text;
            string designa = designation.Text;
            if (codef != "" && designa != "") {
                dao.Insert(new Filiere(codef, designa));
                MessageBox.Show("Filiere ajouter");
                FillTable();
            } else {
                MessageBox.Show("Remplire tous les champs");
            }
        }
        private void Filieres_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        }

        private void Filieres_CellClick(object sender, DataGridViewCellEventArgs e) {
            //modifier handler
            if (e.ColumnIndex == 0) {
                // get codef
                string codef = Filieres[2, e.RowIndex].Value.ToString();
                // get designation
                string designation = Filieres[3, e.RowIndex].Value.ToString();
                //update 
                dao.Update(new Filiere(codef, designation), " codeF='" + codef + "'");
                MessageBox.Show("Filiere Modifier");
                FillTable();
            }
            //supprimer handler
            if (e.ColumnIndex == 1) {
                DialogResult dialogResult = MessageBox.Show("la supprission du filiere va etre affectuer aussi à les eleves et les modules de cette filiere , et vous sure?", "Supprimer Cette filiere", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    // get codef
                    string codef = Filieres[2, e.RowIndex].Value.ToString();
                    // delete filiere
                    dao.Delete("codeF='" + codef + "'");
                    MessageBox.Show("Filiere supprimer");
                    FillTable();
                }

            }
        }


    }
}
