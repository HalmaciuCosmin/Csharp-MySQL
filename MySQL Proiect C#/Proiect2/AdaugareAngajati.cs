using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect2
{
    public partial class AdaugareAngajati : Form
    {
        string NumeFirma;

        public AdaugareAngajati(string nume)
        {
            NumeFirma = nume;
            InitializeComponent();
        }

        private void Adaugare_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox_CNP.Text) || string.IsNullOrWhiteSpace(textBox_Angajat.Text) ||
               string.IsNullOrWhiteSpace(textBox_Salar.Text) || string.IsNullOrWhiteSpace(textBox_Procent.Text))
            {
                MessageBox.Show("Completeaza toate campurile cu date valide");
            }
            else
            {
                int auxCNP = int.Parse(textBox_CNP.Text);
                int auxSalar = int.Parse(textBox_Salar.Text);
                int auxProcent = int.Parse(textBox_Procent.Text);
                var aux = DataBase.DataBaseInstance.inserareAngajat(textBox_Angajat.Text, auxCNP, auxSalar, auxProcent, NumeFirma);
                if (aux == true)
                {
                    string aux1 = $"Angajatul cu numele {textBox_Angajat.Text} a fost adaugat in baza de date";
                    MessageBox.Show(aux1);
                    Close();
                }
                else
                {
                    string aux1 = $"Angajatul cu numele {textBox_Angajat.Text} se afla in baza de date";
                    MessageBox.Show(aux1);
                    Close();
                }
            }
   
        }
    }
}
