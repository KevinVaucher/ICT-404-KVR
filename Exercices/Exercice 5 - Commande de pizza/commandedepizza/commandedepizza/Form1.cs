using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace commandedepizza
{
    public partial class Form1 : Form
    {
        int numTable;
        string txtAnchois;
        string txtCapres;
        string txtJambon;
        string txtCrevettes;
        string txtPate;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void grpPate_Enter(object sender, EventArgs e)
        {

        }


        private void lblTable_Click(object sender, EventArgs e)
        {

        }

        private void txtTable_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioExtrafine_CheckedChanged(object sender, EventArgs e)
        {
            if (radioExtrafine.Checked == true)
            {
                txtPate = ("extra-fine avec");
            }
        }

        private void radioFine_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFine.Checked == true)
            {
                txtPate = ("fine avec");
            }
        }

        private void radioNormale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNormale.Checked == true)
            {
                txtPate = ("normale avec");
            }
        }

        private void radioEpaisse_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEpaisse.Checked == true)
            {
                txtPate = ("epaisse avec");
            }
        }

        private void chkAnchois_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnchois.Checked == true)
            {
                txtAnchois = (" anchois,");
            }
            else
            {
                txtAnchois = ("");
            }
        }

        private void chkCapres_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCapres.Checked == true)
            {
                txtCapres = (" câpres,");
            }
            else
            {
                txtCapres = ("");
            }
        }
        private void chkJambon_CheckedChanged(object sender, EventArgs e)
            {
                if (chkJambon.Checked == true)
                {
                    txtJambon = (" jambon,");
                }
            else
            {
                txtJambon = ("");
            }
        }
        private void chkCrevettes_CheckedChanged(object sender, EventArgs e)
            {
               if (chkCrevettes.Checked == true)
               {
                   txtCrevettes = (" crevettes,");
               }
            else
            {
                txtCrevettes = ("");
            }
        }
        private void lblCommande_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            numTable = int.Parse(txtTable.Text);

            richtxtCommande.Text=("Pour la table " + numTable + " : pâte "+ txtPate + txtAnchois + txtCapres + txtJambon + txtCrevettes);
            if(richtxtCommande.Text != "")
            {
                richtxtCommande.Text = richtxtCommande.Text.Substring(0, richtxtCommande.Text.Length - 1);
            }
        }
        private void richtxtCommande_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
