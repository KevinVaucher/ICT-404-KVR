namespace Deductions
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
            this.annuelbrut = new System.Windows.Forms.Label();
            this.textboxannuelbrut = new System.Windows.Forms.TextBox();
            this.coefficient = new System.Windows.Forms.Label();
            this.coefficientfamilial = new System.Windows.Forms.TextBox();
            this.deductionjeune = new System.Windows.Forms.CheckBox();
            this.valeurdeducjeune = new System.Windows.Forms.TextBox();
            this.deductiontransport = new System.Windows.Forms.CheckBox();
            this.valeurdeductransport = new System.Windows.Forms.TextBox();
            this.rabais = new System.Windows.Forms.CheckBox();
            this.valeurrabais = new System.Windows.Forms.TextBox();
            this.calcul = new System.Windows.Forms.Button();
            this.revenuimposable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // annuelbrut
            // 
            this.annuelbrut.AutoSize = true;
            this.annuelbrut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuelbrut.Location = new System.Drawing.Point(62, 74);
            this.annuelbrut.Name = "annuelbrut";
            this.annuelbrut.Size = new System.Drawing.Size(141, 16);
            this.annuelbrut.TabIndex = 0;
            this.annuelbrut.Text = "Revenu annuel brut";
            this.annuelbrut.Click += new System.EventHandler(this.annuelbrut_Click);
            // 
            // textboxannuelbrut
            // 
            this.textboxannuelbrut.Location = new System.Drawing.Point(265, 73);
            this.textboxannuelbrut.Name = "textboxannuelbrut";
            this.textboxannuelbrut.Size = new System.Drawing.Size(116, 20);
            this.textboxannuelbrut.TabIndex = 1;
            this.textboxannuelbrut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textboxannuelbrut.TextChanged += new System.EventHandler(this.textboxannuelbrut_TextChanged);
            // 
            // coefficient
            // 
            this.coefficient.AutoSize = true;
            this.coefficient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coefficient.Location = new System.Drawing.Point(62, 133);
            this.coefficient.Name = "coefficient";
            this.coefficient.Size = new System.Drawing.Size(135, 16);
            this.coefficient.TabIndex = 2;
            this.coefficient.Text = "Coefficient familial";
            // 
            // coefficientfamilial
            // 
            this.coefficientfamilial.Location = new System.Drawing.Point(335, 132);
            this.coefficientfamilial.Name = "coefficientfamilial";
            this.coefficientfamilial.Size = new System.Drawing.Size(46, 20);
            this.coefficientfamilial.TabIndex = 3;
            this.coefficientfamilial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.coefficientfamilial.TextChanged += new System.EventHandler(this.coefficientfamilial_TextChanged);
            // 
            // deductionjeune
            // 
            this.deductionjeune.AutoSize = true;
            this.deductionjeune.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deductionjeune.Location = new System.Drawing.Point(104, 207);
            this.deductionjeune.Name = "deductionjeune";
            this.deductionjeune.Size = new System.Drawing.Size(124, 20);
            this.deductionjeune.TabIndex = 4;
            this.deductionjeune.Text = "Déduction jeune";
            this.deductionjeune.UseVisualStyleBackColor = true;
            this.deductionjeune.CheckedChanged += new System.EventHandler(this.deductionjeune_CheckedChanged);
            // 
            // valeurdeducjeune
            // 
            this.valeurdeducjeune.Enabled = false;
            this.valeurdeducjeune.Location = new System.Drawing.Point(333, 207);
            this.valeurdeducjeune.Name = "valeurdeducjeune";
            this.valeurdeducjeune.Size = new System.Drawing.Size(45, 20);
            this.valeurdeducjeune.TabIndex = 5;
            this.valeurdeducjeune.Text = "900";
            this.valeurdeducjeune.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // deductiontransport
            // 
            this.deductiontransport.AutoSize = true;
            this.deductiontransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deductiontransport.Location = new System.Drawing.Point(103, 248);
            this.deductiontransport.Name = "deductiontransport";
            this.deductiontransport.Size = new System.Drawing.Size(143, 20);
            this.deductiontransport.TabIndex = 6;
            this.deductiontransport.Text = "Déduction transport";
            this.deductiontransport.UseVisualStyleBackColor = true;
            this.deductiontransport.CheckedChanged += new System.EventHandler(this.deductiontransport_CheckedChanged);
            // 
            // valeurdeductransport
            // 
            this.valeurdeductransport.Enabled = false;
            this.valeurdeductransport.Location = new System.Drawing.Point(333, 248);
            this.valeurdeductransport.Name = "valeurdeductransport";
            this.valeurdeductransport.Size = new System.Drawing.Size(44, 20);
            this.valeurdeductransport.TabIndex = 7;
            this.valeurdeductransport.Text = "650";
            // 
            // rabais
            // 
            this.rabais.AutoSize = true;
            this.rabais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabais.Location = new System.Drawing.Point(104, 291);
            this.rabais.Name = "rabais";
            this.rabais.Size = new System.Drawing.Size(136, 20);
            this.rabais.TabIndex = 8;
            this.rabais.Text = "Rabais fidélité (%)";
            this.rabais.UseVisualStyleBackColor = true;
            this.rabais.CheckedChanged += new System.EventHandler(this.rabais_CheckedChanged);
            // 
            // valeurrabais
            // 
            this.valeurrabais.Enabled = false;
            this.valeurrabais.Location = new System.Drawing.Point(334, 291);
            this.valeurrabais.Name = "valeurrabais";
            this.valeurrabais.Size = new System.Drawing.Size(44, 20);
            this.valeurrabais.TabIndex = 9;
            this.valeurrabais.Text = "4";
            // 
            // calcul
            // 
            this.calcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcul.Location = new System.Drawing.Point(187, 339);
            this.calcul.Name = "calcul";
            this.calcul.Size = new System.Drawing.Size(125, 49);
            this.calcul.TabIndex = 10;
            this.calcul.Text = "Calcul";
            this.calcul.UseVisualStyleBackColor = true;
            this.calcul.Click += new System.EventHandler(this.button1_Click);
            // 
            // revenuimposable
            // 
            this.revenuimposable.AutoSize = true;
            this.revenuimposable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenuimposable.Location = new System.Drawing.Point(24, 407);
            this.revenuimposable.Name = "revenuimposable";
            this.revenuimposable.Size = new System.Drawing.Size(251, 29);
            this.revenuimposable.TabIndex = 11;
            this.revenuimposable.Text = "Revenu imposable : ";
            this.revenuimposable.Visible = false;
            this.revenuimposable.Click += new System.EventHandler(this.revenuimposable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 468);
            this.Controls.Add(this.revenuimposable);
            this.Controls.Add(this.calcul);
            this.Controls.Add(this.valeurrabais);
            this.Controls.Add(this.rabais);
            this.Controls.Add(this.valeurdeductransport);
            this.Controls.Add(this.deductiontransport);
            this.Controls.Add(this.valeurdeducjeune);
            this.Controls.Add(this.deductionjeune);
            this.Controls.Add(this.coefficientfamilial);
            this.Controls.Add(this.coefficient);
            this.Controls.Add(this.textboxannuelbrut);
            this.Controls.Add(this.annuelbrut);
            this.Name = "Form1";
            this.Text = "Déductions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label annuelbrut;
        private System.Windows.Forms.TextBox textboxannuelbrut;
        private System.Windows.Forms.Label coefficient;
        private System.Windows.Forms.TextBox coefficientfamilial;
        private System.Windows.Forms.CheckBox deductionjeune;
        private System.Windows.Forms.TextBox valeurdeducjeune;
        private System.Windows.Forms.CheckBox deductiontransport;
        private System.Windows.Forms.TextBox valeurdeductransport;
        private System.Windows.Forms.CheckBox rabais;
        private System.Windows.Forms.TextBox valeurrabais;
        private System.Windows.Forms.Button calcul;
        private System.Windows.Forms.Label revenuimposable;
    }
}

