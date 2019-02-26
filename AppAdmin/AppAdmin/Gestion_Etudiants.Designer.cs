namespace AppAdmin
{
    partial class Gestion_Etudiants
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CodeEleve = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.Filieres = new System.Windows.Forms.ComboBox();
            this.Niveau = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Etudiants = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Etudiants)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Filière";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Niveau";
            // 
            // CodeEleve
            // 
            this.CodeEleve.Location = new System.Drawing.Point(171, 109);
            this.CodeEleve.Name = "CodeEleve";
            this.CodeEleve.Size = new System.Drawing.Size(161, 20);
            this.CodeEleve.TabIndex = 5;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(171, 154);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(161, 20);
            this.Nom.TabIndex = 6;
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(171, 202);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(161, 20);
            this.Prenom.TabIndex = 7;
            // 
            // Filieres
            // 
            this.Filieres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filieres.FormattingEnabled = true;
            this.Filieres.Location = new System.Drawing.Point(171, 258);
            this.Filieres.Name = "Filieres";
            this.Filieres.Size = new System.Drawing.Size(161, 21);
            this.Filieres.TabIndex = 8;
            // 
            // Niveau
            // 
            this.Niveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Niveau.FormattingEnabled = true;
            this.Niveau.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.Niveau.Location = new System.Drawing.Point(171, 305);
            this.Niveau.Name = "Niveau";
            this.Niveau.Size = new System.Drawing.Size(161, 21);
            this.Niveau.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Nouveau";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(590, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(590, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Rechercher";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(590, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Gestion des notes";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Etudiants
            // 
            this.Etudiants.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Etudiants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Etudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Etudiants.Location = new System.Drawing.Point(23, 374);
            this.Etudiants.Name = "Etudiants";
            this.Etudiants.Size = new System.Drawing.Size(1010, 258);
            this.Etudiants.TabIndex = 14;
            // 
            // Gestion_Etudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1186, 644);
            this.ControlBox = false;
            this.Controls.Add(this.Etudiants);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Niveau);
            this.Controls.Add(this.Filieres);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.CodeEleve);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Gestion_Etudiants";
            this.Text = "Gestion_Etudiants";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Gestion_Etudiants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Etudiants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CodeEleve;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.ComboBox Filieres;
        private System.Windows.Forms.ComboBox Niveau;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView Etudiants;
    }
}