﻿namespace archedenoe
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
            this.lblTerre = new System.Windows.Forms.Label();
            this.listboxTerre = new System.Windows.Forms.ListBox();
            this.cmdFlechehaut = new System.Windows.Forms.Button();
            this.cmdFlechebas = new System.Windows.Forms.Button();
            this.lblBord = new System.Windows.Forms.Label();
            this.listboxBord = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTerre
            // 
            this.lblTerre.AutoSize = true;
            this.lblTerre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerre.Location = new System.Drawing.Point(34, 36);
            this.lblTerre.Name = "lblTerre";
            this.lblTerre.Size = new System.Drawing.Size(162, 25);
            this.lblTerre.TabIndex = 0;
            this.lblTerre.Text = "Encore à terre";
            this.lblTerre.Click += new System.EventHandler(this.lblTerre_Click);
            // 
            // listboxTerre
            // 
            this.listboxTerre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxTerre.FormattingEnabled = true;
            this.listboxTerre.ItemHeight = 16;
            this.listboxTerre.Items.AddRange(new object[] {
            "Araignée",
            "Chat",
            "Cheval",
            "Chien",
            "Cobra",
            "Coccinelle",
            "Kangourou",
            "Perroquet",
            "Rat",
            "Ver de terre"});
            this.listboxTerre.Location = new System.Drawing.Point(39, 64);
            this.listboxTerre.Name = "listboxTerre";
            this.listboxTerre.Size = new System.Drawing.Size(237, 340);
            this.listboxTerre.Sorted = true;
            this.listboxTerre.TabIndex = 1;
            this.listboxTerre.SelectedIndexChanged += new System.EventHandler(this.listboxTerre_SelectedIndexChanged);
            // 
            // cmdFlechehaut
            // 
            this.cmdFlechehaut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFlechehaut.Location = new System.Drawing.Point(293, 104);
            this.cmdFlechehaut.Name = "cmdFlechehaut";
            this.cmdFlechehaut.Size = new System.Drawing.Size(104, 29);
            this.cmdFlechehaut.TabIndex = 2;
            this.cmdFlechehaut.Text = "===>";
            this.cmdFlechehaut.UseVisualStyleBackColor = true;
            this.cmdFlechehaut.Click += new System.EventHandler(this.cmdFlechehaut_Click);
            // 
            // cmdFlechebas
            // 
            this.cmdFlechebas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFlechebas.Location = new System.Drawing.Point(293, 215);
            this.cmdFlechebas.Name = "cmdFlechebas";
            this.cmdFlechebas.Size = new System.Drawing.Size(104, 29);
            this.cmdFlechebas.TabIndex = 3;
            this.cmdFlechebas.Text = "<===";
            this.cmdFlechebas.UseVisualStyleBackColor = true;
            this.cmdFlechebas.Click += new System.EventHandler(this.cmdFlechebas_Click);
            // 
            // lblBord
            // 
            this.lblBord.AutoSize = true;
            this.lblBord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBord.Location = new System.Drawing.Point(409, 36);
            this.lblBord.Name = "lblBord";
            this.lblBord.Size = new System.Drawing.Size(81, 25);
            this.lblBord.TabIndex = 4;
            this.lblBord.Text = "A bord";
            this.lblBord.Click += new System.EventHandler(this.lblBord_Click);
            // 
            // listboxBord
            // 
            this.listboxBord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxBord.FormattingEnabled = true;
            this.listboxBord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listboxBord.ItemHeight = 16;
            this.listboxBord.Location = new System.Drawing.Point(414, 64);
            this.listboxBord.Name = "listboxBord";
            this.listboxBord.Size = new System.Drawing.Size(237, 340);
            this.listboxBord.TabIndex = 5;
            this.listboxBord.SelectedIndexChanged += new System.EventHandler(this.listboxBord_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 491);
            this.Controls.Add(this.listboxBord);
            this.Controls.Add(this.lblBord);
            this.Controls.Add(this.cmdFlechebas);
            this.Controls.Add(this.cmdFlechehaut);
            this.Controls.Add(this.listboxTerre);
            this.Controls.Add(this.lblTerre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTerre;
        private System.Windows.Forms.ListBox listboxTerre;
        private System.Windows.Forms.Button cmdFlechehaut;
        private System.Windows.Forms.Button cmdFlechebas;
        private System.Windows.Forms.Label lblBord;
        private System.Windows.Forms.ListBox listboxBord;
    }
}

