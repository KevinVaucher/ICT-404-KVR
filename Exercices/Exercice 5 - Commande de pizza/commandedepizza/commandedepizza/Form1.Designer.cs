namespace commandedepizza
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTable = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.grpPate = new System.Windows.Forms.GroupBox();
            this.radioEpaisse = new System.Windows.Forms.RadioButton();
            this.radioNormale = new System.Windows.Forms.RadioButton();
            this.radioFine = new System.Windows.Forms.RadioButton();
            this.radioExtrafine = new System.Windows.Forms.RadioButton();
            this.chkAnchois = new System.Windows.Forms.CheckBox();
            this.chkCapres = new System.Windows.Forms.CheckBox();
            this.chkJambon = new System.Windows.Forms.CheckBox();
            this.chkCrevettes = new System.Windows.Forms.CheckBox();
            this.lblCommande = new System.Windows.Forms.Label();
            this.richtxtCommande = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpPate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(18, 9);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(38, 15);
            this.lblTable.TabIndex = 0;
            this.lblTable.Text = "Table";
            this.lblTable.Click += new System.EventHandler(this.lblTable_Click);
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(62, 9);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(30, 20);
            this.txtTable.TabIndex = 1;
            this.txtTable.TextChanged += new System.EventHandler(this.txtTable_TextChanged);
            // 
            // grpPate
            // 
            this.grpPate.Controls.Add(this.radioEpaisse);
            this.grpPate.Controls.Add(this.radioNormale);
            this.grpPate.Controls.Add(this.radioFine);
            this.grpPate.Controls.Add(this.radioExtrafine);
            this.grpPate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPate.Location = new System.Drawing.Point(21, 35);
            this.grpPate.Name = "grpPate";
            this.grpPate.Size = new System.Drawing.Size(109, 127);
            this.grpPate.TabIndex = 2;
            this.grpPate.TabStop = false;
            this.grpPate.Text = "Pâte";
            this.grpPate.Enter += new System.EventHandler(this.grpPate_Enter);
            // 
            // radioEpaisse
            // 
            this.radioEpaisse.AutoSize = true;
            this.radioEpaisse.Location = new System.Drawing.Point(9, 95);
            this.radioEpaisse.Name = "radioEpaisse";
            this.radioEpaisse.Size = new System.Drawing.Size(69, 19);
            this.radioEpaisse.TabIndex = 3;
            this.radioEpaisse.TabStop = true;
            this.radioEpaisse.Text = "Epaisse";
            this.radioEpaisse.UseVisualStyleBackColor = true;
            this.radioEpaisse.CheckedChanged += new System.EventHandler(this.radioEpaisse_CheckedChanged);
            // 
            // radioNormale
            // 
            this.radioNormale.AutoSize = true;
            this.radioNormale.Location = new System.Drawing.Point(9, 70);
            this.radioNormale.Name = "radioNormale";
            this.radioNormale.Size = new System.Drawing.Size(73, 19);
            this.radioNormale.TabIndex = 2;
            this.radioNormale.TabStop = true;
            this.radioNormale.Text = "Normale";
            this.radioNormale.UseVisualStyleBackColor = true;
            this.radioNormale.CheckedChanged += new System.EventHandler(this.radioNormale_CheckedChanged);
            // 
            // radioFine
            // 
            this.radioFine.AutoSize = true;
            this.radioFine.Location = new System.Drawing.Point(9, 45);
            this.radioFine.Name = "radioFine";
            this.radioFine.Size = new System.Drawing.Size(49, 19);
            this.radioFine.TabIndex = 1;
            this.radioFine.TabStop = true;
            this.radioFine.Text = "Fine";
            this.radioFine.UseVisualStyleBackColor = true;
            this.radioFine.CheckedChanged += new System.EventHandler(this.radioFine_CheckedChanged);
            // 
            // radioExtrafine
            // 
            this.radioExtrafine.AutoSize = true;
            this.radioExtrafine.Location = new System.Drawing.Point(9, 20);
            this.radioExtrafine.Name = "radioExtrafine";
            this.radioExtrafine.Size = new System.Drawing.Size(77, 19);
            this.radioExtrafine.TabIndex = 0;
            this.radioExtrafine.TabStop = true;
            this.radioExtrafine.Text = "Extra-fine";
            this.radioExtrafine.UseVisualStyleBackColor = true;
            this.radioExtrafine.CheckedChanged += new System.EventHandler(this.radioExtrafine_CheckedChanged);
            // 
            // chkAnchois
            // 
            this.chkAnchois.AutoSize = true;
            this.chkAnchois.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAnchois.Location = new System.Drawing.Point(195, 58);
            this.chkAnchois.Name = "chkAnchois";
            this.chkAnchois.Size = new System.Drawing.Size(69, 19);
            this.chkAnchois.TabIndex = 3;
            this.chkAnchois.Text = "Anchois";
            this.chkAnchois.UseVisualStyleBackColor = true;
            this.chkAnchois.CheckedChanged += new System.EventHandler(this.chkAnchois_CheckedChanged);
            // 
            // chkCapres
            // 
            this.chkCapres.AutoSize = true;
            this.chkCapres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCapres.Location = new System.Drawing.Point(195, 83);
            this.chkCapres.Name = "chkCapres";
            this.chkCapres.Size = new System.Drawing.Size(65, 19);
            this.chkCapres.TabIndex = 4;
            this.chkCapres.Text = "Câpres";
            this.chkCapres.UseVisualStyleBackColor = true;
            this.chkCapres.CheckedChanged += new System.EventHandler(this.chkCapres_CheckedChanged);
            // 
            // chkJambon
            // 
            this.chkJambon.AutoSize = true;
            this.chkJambon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJambon.Location = new System.Drawing.Point(195, 108);
            this.chkJambon.Name = "chkJambon";
            this.chkJambon.Size = new System.Drawing.Size(71, 19);
            this.chkJambon.TabIndex = 5;
            this.chkJambon.Text = "Jambon";
            this.chkJambon.UseVisualStyleBackColor = true;
            this.chkJambon.CheckedChanged += new System.EventHandler(this.chkJambon_CheckedChanged);
            // 
            // chkCrevettes
            // 
            this.chkCrevettes.AutoSize = true;
            this.chkCrevettes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCrevettes.Location = new System.Drawing.Point(195, 133);
            this.chkCrevettes.Name = "chkCrevettes";
            this.chkCrevettes.Size = new System.Drawing.Size(76, 19);
            this.chkCrevettes.TabIndex = 6;
            this.chkCrevettes.Text = "Crevettes";
            this.chkCrevettes.UseVisualStyleBackColor = true;
            this.chkCrevettes.CheckedChanged += new System.EventHandler(this.chkCrevettes_CheckedChanged);
            // 
            // lblCommande
            // 
            this.lblCommande.AutoSize = true;
            this.lblCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommande.Location = new System.Drawing.Point(27, 198);
            this.lblCommande.Name = "lblCommande";
            this.lblCommande.Size = new System.Drawing.Size(72, 15);
            this.lblCommande.TabIndex = 7;
            this.lblCommande.Text = "Commande";
            this.lblCommande.Click += new System.EventHandler(this.lblCommande_Click);
            // 
            // richtxtCommande
            // 
            this.richtxtCommande.BackColor = System.Drawing.Color.Yellow;
            this.richtxtCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtCommande.Location = new System.Drawing.Point(21, 219);
            this.richtxtCommande.Name = "richtxtCommande";
            this.richtxtCommande.Size = new System.Drawing.Size(296, 70);
            this.richtxtCommande.TabIndex = 8;
            this.richtxtCommande.Text = "";
            this.richtxtCommande.TextChanged += new System.EventHandler(this.richtxtCommande_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(225, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Commander";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richtxtCommande);
            this.Controls.Add(this.lblCommande);
            this.Controls.Add(this.chkCrevettes);
            this.Controls.Add(this.chkJambon);
            this.Controls.Add(this.chkCapres);
            this.Controls.Add(this.chkAnchois);
            this.Controls.Add(this.grpPate);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.lblTable);
            this.Name = "Form1";
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPate.ResumeLayout(false);
            this.grpPate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.GroupBox grpPate;
        private System.Windows.Forms.RadioButton radioEpaisse;
        private System.Windows.Forms.RadioButton radioNormale;
        private System.Windows.Forms.RadioButton radioFine;
        private System.Windows.Forms.RadioButton radioExtrafine;
        private System.Windows.Forms.CheckBox chkAnchois;
        private System.Windows.Forms.CheckBox chkCapres;
        private System.Windows.Forms.CheckBox chkJambon;
        private System.Windows.Forms.CheckBox chkCrevettes;
        private System.Windows.Forms.Label lblCommande;
        private System.Windows.Forms.RichTextBox richtxtCommande;
        private System.Windows.Forms.Button button1;
    }
}

