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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }



        private void button_LogIn_Click(object sender, EventArgs e)
        {
            string parola = Criptare.Crypt(textBox_Parola.Text);
            var aux = DataBase.DataBaseInstance.LogIn(textBox_Firma.Text,parola);
            if(aux == false)
            {
                MessageBox.Show("Nume firma sau parola  incorecta");
            }
            else
            {
                MainForm mainForm = new MainForm(textBox_Firma.Text);
                Hide();    
                mainForm.Show();
            }
        
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            Register RegForm = new Register();

            Hide();
            RegForm.ShowDialog();          
            Show();
        }
    }
}
