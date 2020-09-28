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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox_Nume.Text) || string.IsNullOrWhiteSpace(textBox_Parola.Text))
            {
                MessageBox.Show("Completeaza toate campurile cu date valide");
            }
            else
            {
                string parola = Criptare.Crypt(textBox_Parola.Text);
                var aux = DataBase.DataBaseInstance.Register(textBox_Nume.Text,parola);
                if (aux == false)
                {
                    string a = $"Firma cu numele {textBox_Nume.Text} se afla in baza de date";
                    MessageBox.Show(a);
                }
                else
                {
                    string a = $"Firma cu numele {textBox_Nume.Text} a fost inregistrata cu succes";
                    MessageBox.Show(a);
                    Close();
                }
            }
        }

          
    }
}
