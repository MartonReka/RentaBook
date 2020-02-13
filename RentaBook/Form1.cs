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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
