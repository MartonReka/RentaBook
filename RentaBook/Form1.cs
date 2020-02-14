using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaBook
{
    public partial class Form1 : Form
    {
        string[] carte = { "Michelle Obama : Becoming", "Louisa Alcott : Little Woman", "Kallocain :Karin Boye", "Greg Keyes:Interstellar","National Geographic : Atlasul Lumii" };
        string[] librarii = { "Biblioteca Centrala", "Biblioteca Centrala", "Carturesti", "Carturesti", "Biblioteca de Geografie" };
        string[] inchiriate_clienti = { "", "", "", "", "", "", "", "" };

        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now.AddDays(1);
            comboBox_Librarie.SelectedIndex = 0;
        }

        private void incarca_Carte()
        {
            int i;
            try
            {
                string lib;
                if (comboBox_Librarie.SelectedIndex == 0)
                    lib = "";
                else
                    lib = comboBox_Librarie.SelectedItem.ToString();
                if (lib == "")
                    for(i = 0; i < carte.Length; i++)
                    {
                        if (inchiriate_clienti[i] == "")
                            comboBox_Carte.Items.Add(carte[i]);
                    }
                else
                    for(i = 0; i < carte.Length; i++)
                    {
                        if ((lib == librarii[i]) && (inchiriate_clienti[i] == ""))
                            comboBox_Carte.Items.Add(carte[i]);
                    }
                if (comboBox_Carte.Items.Count == 0)
                    MessageBox.Show("Nu mai sunt carte disponibile din\n domeniul selectat");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
         private void reseteaza_Carte()
         {
                comboBox_Carte.Items.Clear();
                comboBox_Carte.SelectedIndex = -1;
         }

        private void comboBox_Librarie_SelectedIndexChanged(object sender, EventArgs e)
        {
            reseteaza_Carte();
            incarca_Carte();
        }

        private void button_Inchiriezi_Click(object sender, EventArgs e)
        {
            int i, gasit;
            string nume_cli = textBox_Nume.Text.Trim();
            string carte_sel;
            try
            {
                if (comboBox_Carte.SelectedIndex == -1)
                    throw new Exception("Va rugam selectati un film");
                if (nume_cli == "")
                    throw new Exception("Va rugam tastati un nume");
                carte_sel = comboBox_Carte.SelectedItem.ToString();
                gasit = 0;
                for(i = 0; i < carte.Length && gasit == 0; i++)
                {
                    if(carte[i] == carte_sel)
                    {
                        inchiriate_clienti[i] = nume_cli;
                        gasit = 1;
                    }
                }
                int nrzile = dateTimePicker1.Value.Subtract(DateTime.Now).Days + 1;
                label5_Mesaj.Text = nume_cli + " - a inchiriat filmul -- " + carte_sel + " -- " + " pentru " + nrzile + "zile";
                reseteaza_Carte();
                incarca_Carte();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare");
            }

        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            comboBox_Librarie.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now.AddDays(1);
            textBox_Nume.Text = "";
            label5_Mesaj.Text = "";
            reseteaza_Carte();
            incarca_Carte();
        }

        

     
    }
}
