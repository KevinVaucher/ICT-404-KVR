/*
  Projet : Déductions
  Auteur : Kevin Vaucher
  Date : 16.05.2019
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deductions
{
    public partial class Form1 : Form
    {
        float brut;
     
        float coefficient = float.Parse(coefficientfamilial.Text);
        float jeune = float.Parse(valeurdeducjeune.Text);
        float transport = float.Parse(valeurdeductransport.Text);
        float rabais = float.Parse(valeurrabais.Text);
        float revenu = brut / coefficient;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void revenuimposable_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textboxannuelbrut.Text, out brut))
            {
            }
            else
            {
            };
        }

        private void annuelbrut_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxannuelbrut_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (deductionjeune.Checked == true) revenu -- jeune;

            revenuimposable.Text = "Revenu imposable : fr. " + revenu.ToString();
            revenuimposable.Visible = true;
        }

        private void deductionjeune_CheckedChanged(object sender, EventArgs e)
        {
            if (deductionjeune.Checked == true) valeurdeducjeune.Enabled = true;
            else valeurdeducjeune.Enabled = false;
        }

        private void deductiontransport_CheckedChanged(object sender, EventArgs e)
        {
            if (deductiontransport.Checked == true) valeurdeductransport.Enabled = true;
            else valeurdeductransport.Enabled = false;
        }
        es
        private void rabais_CheckedChanged(object sender, EventArgs e)
        {
            if (rabais.Checked == true) valeurrabais.Enabled = true;
            else valeurrabais.Enabled = false;
        }

        private void coefficientfamilial_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
