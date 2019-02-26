namespace AppAdmin
{
    partial class Gestion_Matieres
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
            this.label6 = new System.Windows.Forms.Label();
            this.codeM = new System.Windows.Forms.TextBox();
            this.Designation = new System.Windows.Forms.TextBox();
            this.Niveau = new System.Windows.Forms.ComboBox();
            this.Semestre = new System.Windows.Forms.ComboBox();
            this.codeF = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nombreMatieres = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.codeM1 = new System.Windows.Forms.TextBox();
            this.Designation1 = new System.Windows.Forms.TextBox();
            this.Poids1 = new System.Windows.Forms.ComboBox();
            this.Poids2 = new System.Windows.Forms.ComboBox();
            this.Designation2 = new System.Windows.Forms.TextBox();
            this.codeM2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Poids3 = new System.Windows.Forms.ComboBox();
            this.Designation3 = new System.Windows.Forms.TextBox();
            this.codeM3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Modules = new System.Windows.Forms.DataGridView();
            this.Matieres = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Modules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matieres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Module";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Designation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Niveau";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre de matieres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Semeste";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Code Filiere";
            // 
            // codeM
            // 
            this.codeM.Location = new System.Drawing.Point(113, 51);
            this.codeM.Name = "codeM";
            this.codeM.Size = new System.Drawing.Size(97, 20);
            this.codeM.TabIndex = 6;
            // 
            // Designation
            // 
            this.Designation.Location = new System.Drawing.Point(330, 51);
            this.Designation.Name = "Designation";
            this.Designation.Size = new System.Drawing.Size(211, 20);
            this.Designation.TabIndex = 7;
            // 
            // Niveau
            // 
            this.Niveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Niveau.FormattingEnabled = true;
            this.Niveau.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.Niveau.Location = new System.Drawing.Point(330, 105);
            this.Niveau.Name = "Niveau";
            this.Niveau.Size = new System.Drawing.Size(211, 21);
            this.Niveau.TabIndex = 10;
            // 
            // Semestre
            // 
            this.Semestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Semestre.FormattingEnabled = true;
            this.Semestre.Items.AddRange(new object[] {
            "1",
            "2"});
            this.Semestre.Location = new System.Drawing.Point(330, 159);
            this.Semestre.Name = "Semestre";
            this.Semestre.Size = new System.Drawing.Size(211, 21);
            this.Semestre.TabIndex = 11;
            // 
            // codeF
            // 
            this.codeF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codeF.FormattingEnabled = true;
            this.codeF.Location = new System.Drawing.Point(113, 105);
            this.codeF.Name = "codeF";
            this.codeF.Size = new System.Drawing.Size(97, 21);
            this.codeF.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 21);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombreMatieres
            // 
            this.nombreMatieres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nombreMatieres.FormattingEnabled = true;
            this.nombreMatieres.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.nombreMatieres.Location = new System.Drawing.Point(113, 159);
            this.nombreMatieres.Name = "nombreMatieres";
            this.nombreMatieres.Size = new System.Drawing.Size(97, 21);
            this.nombreMatieres.TabIndex = 16;
            this.nombreMatieres.SelectedIndexChanged += new System.EventHandler(this.nombreMatieres_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Code Matiere 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(558, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Poids";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Designation";
            // 
            // codeM1
            // 
            this.codeM1.Location = new System.Drawing.Point(113, 220);
            this.codeM1.Name = "codeM1";
            this.codeM1.Size = new System.Drawing.Size(97, 20);
            this.codeM1.TabIndex = 20;
            // 
            // Designation1
            // 
            this.Designation1.Location = new System.Drawing.Point(330, 220);
            this.Designation1.Name = "Designation1";
            this.Designation1.Size = new System.Drawing.Size(211, 20);
            this.Designation1.TabIndex = 21;
            // 
            // Poids1
            // 
            this.Poids1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Poids1.FormattingEnabled = true;
            this.Poids1.Items.AddRange(new object[] {
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9",
            "1"});
            this.Poids1.Location = new System.Drawing.Point(653, 218);
            this.Poids1.Name = "Poids1";
            this.Poids1.Size = new System.Drawing.Size(121, 21);
            this.Poids1.TabIndex = 22;
            // 
            // Poids2
            // 
            this.Poids2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Poids2.FormattingEnabled = true;
            this.Poids2.Items.AddRange(new object[] {
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9",
            "1"});
            this.Poids2.Location = new System.Drawing.Point(653, 276);
            this.Poids2.Name = "Poids2";
            this.Poids2.Size = new System.Drawing.Size(121, 21);
            this.Poids2.TabIndex = 28;
            // 
            // Designation2
            // 
            this.Designation2.Location = new System.Drawing.Point(330, 278);
            this.Designation2.Name = "Designation2";
            this.Designation2.Size = new System.Drawing.Size(211, 20);
            this.Designation2.TabIndex = 27;
            // 
            // codeM2
            // 
            this.codeM2.Location = new System.Drawing.Point(113, 278);
            this.codeM2.Name = "codeM2";
            this.codeM2.Size = new System.Drawing.Size(97, 20);
            this.codeM2.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(223, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Designation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(558, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Poids";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Code Matiere 2";
            // 
            // Poids3
            // 
            this.Poids3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Poids3.FormattingEnabled = true;
            this.Poids3.Items.AddRange(new object[] {
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9",
            "1"});
            this.Poids3.Location = new System.Drawing.Point(653, 339);
            this.Poids3.Name = "Poids3";
            this.Poids3.Size = new System.Drawing.Size(121, 21);
            this.Poids3.TabIndex = 34;
            // 
            // Designation3
            // 
            this.Designation3.Location = new System.Drawing.Point(330, 341);
            this.Designation3.Name = "Designation3";
            this.Designation3.Size = new System.Drawing.Size(211, 20);
            this.Designation3.TabIndex = 33;
            // 
            // codeM3
            // 
            this.codeM3.Location = new System.Drawing.Point(113, 341);
            this.codeM3.Name = "codeM3";
            this.codeM3.Size = new System.Drawing.Size(97, 20);
            this.codeM3.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(223, 348);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Designation";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(558, 344);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Poids";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 348);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Code Matiere 3";
            // 
            // Modules
            // 
            this.Modules.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Modules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Modules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Modules.Location = new System.Drawing.Point(54, 393);
            this.Modules.Name = "Modules";
            this.Modules.Size = new System.Drawing.Size(1258, 371);
            this.Modules.TabIndex = 37;
            // 
            // Matieres
            // 
            this.Matieres.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Matieres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Matieres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matieres.GridColor = System.Drawing.SystemColors.Window;
            this.Matieres.Location = new System.Drawing.Point(798, 51);
            this.Matieres.Name = "Matieres";
            this.Matieres.Size = new System.Drawing.Size(553, 311);
            this.Matieres.TabIndex = 38;
            // 
            // Gestion_Matieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.Matieres);
            this.Controls.Add(this.Modules);
            this.Controls.Add(this.Poids3);
            this.Controls.Add(this.Designation3);
            this.Controls.Add(this.codeM3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Poids2);
            this.Controls.Add(this.Designation2);
            this.Controls.Add(this.codeM2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Poids1);
            this.Controls.Add(this.Designation1);
            this.Controls.Add(this.codeM1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nombreMatieres);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.codeF);
            this.Controls.Add(this.Semestre);
            this.Controls.Add(this.Niveau);
            this.Controls.Add(this.Designation);
            this.Controls.Add(this.codeM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_Matieres";
            this.Text = "Gestion_Matieres";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Gestion_Matieres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Modules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matieres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox codeM;
        private System.Windows.Forms.TextBox Designation;
        private System.Windows.Forms.ComboBox Niveau;
        private System.Windows.Forms.ComboBox Semestre;
        private System.Windows.Forms.ComboBox codeF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox nombreMatieres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox codeM1;
        private System.Windows.Forms.TextBox Designation1;
        private System.Windows.Forms.ComboBox Poids1;
        private System.Windows.Forms.ComboBox Poids2;
        private System.Windows.Forms.TextBox Designation2;
        private System.Windows.Forms.TextBox codeM2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Poids3;
        private System.Windows.Forms.TextBox Designation3;
        private System.Windows.Forms.TextBox codeM3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView Modules;
        private System.Windows.Forms.DataGridView Matieres;
    }
}