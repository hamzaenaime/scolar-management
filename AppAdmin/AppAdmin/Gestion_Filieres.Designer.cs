namespace AppAdmin
{
    partial class Gestion_Filieres
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
            this.codeF = new System.Windows.Forms.TextBox();
            this.designation = new System.Windows.Forms.TextBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Filieres = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Filieres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code FIlieres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Designation";
            // 
            // codeF
            // 
            this.codeF.Location = new System.Drawing.Point(190, 108);
            this.codeF.Name = "codeF";
            this.codeF.Size = new System.Drawing.Size(237, 20);
            this.codeF.TabIndex = 2;
            // 
            // designation
            // 
            this.designation.Location = new System.Drawing.Point(190, 164);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(237, 20);
            this.designation.TabIndex = 3;
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(580, 105);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(144, 23);
            this.Ajouter.TabIndex = 4;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Filieres
            // 
            this.Filieres.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Filieres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Filieres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Filieres.Location = new System.Drawing.Point(21, 240);
            this.Filieres.Name = "Filieres";
            this.Filieres.Size = new System.Drawing.Size(747, 180);
            this.Filieres.TabIndex = 7;
            this.Filieres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Filieres_CellContentClick);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(190, 30);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(128, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Ajouter une filiere";
            // 
            // Gestion_Filieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Filieres);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.designation);
            this.Controls.Add(this.codeF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_Filieres";
            this.Text = "Gestion_Filieres";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Filieres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codeF;
        private System.Windows.Forms.TextBox designation;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.DataGridView Filieres;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}