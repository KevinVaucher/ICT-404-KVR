using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Auteur : Kevin Vaucher
Projet : Arche de Noé
Date : 13.06.2019
*/
namespace archedenoe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listboxTerre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTerre_Click(object sender, EventArgs e)
        {

        }

        private void lblBord_Click(object sender, EventArgs e)
        {

        }

        private void listboxBord_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdFlechehaut_Click(object sender, EventArgs e)
        {
            listboxBord.Items.Add(listboxTerre.SelectedItem); // Ajoute l'objet sélectionné dans la deuxième liste
            listboxTerre.Items.Remove(listboxTerre.SelectedItem); // Supprime cet objet de la première liste
            if (listboxTerre.Items.Count == 0)
            {
                cmdFlechehaut.Enabled = false;
            }
            cmdFlechebas.Enabled = true;

        }

        private void cmdFlechebas_Click(object sender, EventArgs e)
        {
            cmdFlechehaut.Enabled = true;
            listboxTerre.Items.Add(listboxBord.SelectedItem); // Ajoute l'objet sélectionné dans la première liste
            listboxBord.Items.Remove(listboxBord.SelectedItem); // Supprime cet objet de la deuxième liste
            if (listboxBord.Items.Count == 0)
            {
                cmdFlechebas.Enabled = false;
            }
        }
    }
}
