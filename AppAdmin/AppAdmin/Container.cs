using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAdmin
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
        }

        private void Container_Load(object sender, EventArgs e)
        {
           /* Form gst_etd = new Gestion_Etudiants();
            gst_etd.MdiParent = this;
            gst_etd.Show();*/
        }

        private void etudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Etudiants gst_etd = new Gestion_Etudiants();
            gst_etd.MdiParent = this;
            gst_etd.Show();
        }

        private void filièresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Filieres gst_etd = new Gestion_Filieres();
            gst_etd.MdiParent = this;
            gst_etd.Show();
        }
    }
}
