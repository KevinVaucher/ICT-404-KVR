using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FenetreBleuRouge
{
    public partial class Form1 : Form
    {
        int compteurcouleurs;
        int compteurdeplacements;
        public Form1()
        {
            InitializeComponent();
        }

        private void boutonbleu_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            compteurcouleurs = compteurcouleurs + 1;
        }

        private void boutonrouge_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            compteurcouleurs = compteurcouleurs + 1;
        }

        private void boutonstats_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous avez changé " + compteurcouleurs + " fois la couleur de fond et déplacé " + compteurdeplacements + " fois la fenêtre.");
        }

        private void boutonquitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void boutonbasgauche_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, Screen.GetBounds(this).Height - this.Height);
            compteurdeplacements = compteurdeplacements + 1;
        }

        private void boutonhautdroite_Click(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.GetBounds(this).Width - this.Width);
            compteurdeplacements = compteurdeplacements + 1;
        }

        private void boutonhautgauche_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0,0);
            compteurdeplacements = compteurdeplacements + 1;
        }

        private void boutonbasdroite_Click(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.GetBounds(this).Width - this.Width, Screen.GetBounds(this).Height - this.Height);
            compteurdeplacements = compteurdeplacements + 1;
        }
    }
}
