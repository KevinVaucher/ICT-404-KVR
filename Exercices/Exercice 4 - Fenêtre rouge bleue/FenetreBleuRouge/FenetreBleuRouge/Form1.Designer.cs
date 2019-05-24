namespace FenetreBleuRouge
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
            this.boutonhautgauche = new System.Windows.Forms.Button();
            this.boutonhautdroite = new System.Windows.Forms.Button();
            this.boutonbasdroite = new System.Windows.Forms.Button();
            this.boutonbasgauche = new System.Windows.Forms.Button();
            this.boutonbleu = new System.Windows.Forms.Button();
            this.boutonrouge = new System.Windows.Forms.Button();
            this.boutonstats = new System.Windows.Forms.Button();
            this.boutonquitter = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.SuspendLayout();
            // 
            // boutonhautgauche
            // 
            this.boutonhautgauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonhautgauche.Location = new System.Drawing.Point(12, 12);
            this.boutonhautgauche.Name = "boutonhautgauche";
            this.boutonhautgauche.Size = new System.Drawing.Size(107, 26);
            this.boutonhautgauche.TabIndex = 0;
            this.boutonhautgauche.Text = "Haut/Gauche";
            this.boutonhautgauche.UseVisualStyleBackColor = true;
            this.boutonhautgauche.Click += new System.EventHandler(this.boutonhautgauche_Click);
            // 
            // boutonhautdroite
            // 
            this.boutonhautdroite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonhautdroite.Location = new System.Drawing.Point(377, 12);
            this.boutonhautdroite.Name = "boutonhautdroite";
            this.boutonhautdroite.Size = new System.Drawing.Size(107, 26);
            this.boutonhautdroite.TabIndex = 1;
            this.boutonhautdroite.Text = "Haut/Droite";
            this.boutonhautdroite.UseVisualStyleBackColor = true;
            this.boutonhautdroite.Click += new System.EventHandler(this.boutonhautdroite_Click);
            // 
            // boutonbasdroite
            // 
            this.boutonbasdroite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonbasdroite.Location = new System.Drawing.Point(377, 390);
            this.boutonbasdroite.Name = "boutonbasdroite";
            this.boutonbasdroite.Size = new System.Drawing.Size(107, 26);
            this.boutonbasdroite.TabIndex = 2;
            this.boutonbasdroite.Text = "Bas/Droite";
            this.boutonbasdroite.UseVisualStyleBackColor = true;
            this.boutonbasdroite.Click += new System.EventHandler(this.boutonbasdroite_Click);
            // 
            // boutonbasgauche
            // 
            this.boutonbasgauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonbasgauche.Location = new System.Drawing.Point(12, 390);
            this.boutonbasgauche.Name = "boutonbasgauche";
            this.boutonbasgauche.Size = new System.Drawing.Size(107, 26);
            this.boutonbasgauche.TabIndex = 3;
            this.boutonbasgauche.Text = "Bas/Gauche";
            this.boutonbasgauche.UseVisualStyleBackColor = true;
            this.boutonbasgauche.Click += new System.EventHandler(this.boutonbasgauche_Click);
            // 
            // boutonbleu
            // 
            this.boutonbleu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonbleu.Location = new System.Drawing.Point(195, 85);
            this.boutonbleu.Name = "boutonbleu";
            this.boutonbleu.Size = new System.Drawing.Size(107, 26);
            this.boutonbleu.TabIndex = 4;
            this.boutonbleu.Text = "Bleu";
            this.boutonbleu.UseVisualStyleBackColor = true;
            this.boutonbleu.Click += new System.EventHandler(this.boutonbleu_Click);
            // 
            // boutonrouge
            // 
            this.boutonrouge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonrouge.Location = new System.Drawing.Point(195, 131);
            this.boutonrouge.Name = "boutonrouge";
            this.boutonrouge.Size = new System.Drawing.Size(107, 26);
            this.boutonrouge.TabIndex = 5;
            this.boutonrouge.Text = "Rouge";
            this.boutonrouge.UseVisualStyleBackColor = true;
            this.boutonrouge.Click += new System.EventHandler(this.boutonrouge_Click);
            // 
            // boutonstats
            // 
            this.boutonstats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonstats.Location = new System.Drawing.Point(195, 204);
            this.boutonstats.Name = "boutonstats";
            this.boutonstats.Size = new System.Drawing.Size(107, 26);
            this.boutonstats.TabIndex = 6;
            this.boutonstats.Text = "Stats";
            this.boutonstats.UseVisualStyleBackColor = true;
            this.boutonstats.Click += new System.EventHandler(this.boutonstats_Click);
            // 
            // boutonquitter
            // 
            this.boutonquitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonquitter.Location = new System.Drawing.Point(195, 284);
            this.boutonquitter.Name = "boutonquitter";
            this.boutonquitter.Size = new System.Drawing.Size(107, 26);
            this.boutonquitter.TabIndex = 7;
            this.boutonquitter.Text = "Quitter";
            this.boutonquitter.UseVisualStyleBackColor = true;
            this.boutonquitter.Click += new System.EventHandler(this.boutonquitter_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(496, 428);
            this.Controls.Add(this.boutonquitter);
            this.Controls.Add(this.boutonstats);
            this.Controls.Add(this.boutonrouge);
            this.Controls.Add(this.boutonbleu);
            this.Controls.Add(this.boutonbasgauche);
            this.Controls.Add(this.boutonbasdroite);
            this.Controls.Add(this.boutonhautdroite);
            this.Controls.Add(this.boutonhautgauche);
            this.Name = "Form1";
            this.Text = "Fenêtre";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boutonhautgauche;
        private System.Windows.Forms.Button boutonhautdroite;
        private System.Windows.Forms.Button boutonbasdroite;
        private System.Windows.Forms.Button boutonbasgauche;
        private System.Windows.Forms.Button boutonbleu;
        private System.Windows.Forms.Button boutonrouge;
        private System.Windows.Forms.Button boutonstats;
        private System.Windows.Forms.Button boutonquitter;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}

