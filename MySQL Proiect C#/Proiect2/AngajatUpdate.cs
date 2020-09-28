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
    public partial class AngajatUpdate : Form
    {
        int CNPAngajat;

        public AngajatUpdate(int CNP)
        {
            CNPAngajat = CNP;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox_Nume.Text) || 
                string.IsNullOrWhiteSpace(textBox_Salar.Text) || string.IsNullOrWhiteSpace(textBox_Procent.Text)) 
               {
                MessageBox.Show("Completeaza toate campurile cu date valide");
               }
            else
            {               
                int auxSalar = int.Parse(textBox_Salar.Text);
                int auxProcent = int.Parse(textBox_Procent.Text);
               DataBase.DataBaseInstance.updateAngajat(CNPAngajat, textBox_Nume.Text, auxSalar, auxProcent);
               MessageBox.Show("Date actualizate");
               Close();
             }
          }
         
        }
    }

