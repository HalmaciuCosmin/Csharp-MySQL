using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Web;

namespace Proiect2
{
    public partial class MainForm : Form
    {
        string NumeFirma;
        List<Angajat> Lista = new List<Angajat>();

        public MainForm(string nume)
        {
            InitializeComponent();
            Initializare(nume);
            NumeFirma = nume;
        }


        public void Initializare(string nume)
        {
           label1.Text = nume;
           DataTable tabel =  DataBase.DataBaseInstance.getData(nume);
           dataGridView1.DataSource = tabel;
        }

        public void UpDate()
        {
            DataTable tabel = DataBase.DataBaseInstance.getData(NumeFirma);
            dataGridView1.DataSource = tabel;
            DataBase.DataBaseInstance.updateNumarAngajati(NumeFirma);
        }
       



        private void AdaugaAngajat_Click(object sender, EventArgs e)
        {
            AdaugareAngajati insert = new AdaugareAngajati(NumeFirma);
            Hide();
            insert.ShowDialog();
            Show();
            UpDate();
        }

        private void UpdateAngajat_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
           
            string cnp = dataGridView1.Rows[index].Cells["CNPAngajat"].Value.ToString();
            int auxCNP = int.Parse(cnp);

           var aux =  DataBase.DataBaseInstance.cautaAngajat(auxCNP);
           if(aux == false)
            {
                string aux1 = $"Angajatul cu cnp {auxCNP} nu exista in baza de date";
                MessageBox.Show(aux1);
            }
            else
            {
                AngajatUpdate form = new AngajatUpdate(auxCNP);
                Hide();
                form.ShowDialog();
                Show();
                UpDate();
            }  
        }

        private void Sterge_Click(object sender, EventArgs e)
        {
           int index = dataGridView1.CurrentCell.RowIndex;          
            string cnp = dataGridView1.Rows[index].Cells["CNPAngajat"].Value.ToString();
            int auxCNP = int.Parse(cnp);
            bool aux = DataBase.DataBaseInstance.StergeAngajat(auxCNP);
            if(aux == true)
            {
                dataGridView1.Rows.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Error");
            }
            
        }

      

        private void Import_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("Angajati.json");
            string json = reader.ReadToEnd();
            var Lista = JsonConvert.DeserializeObject<ListaAngajati>(json);

            DataBase.DataBaseInstance.dropAngajati();

            for(int i = 0; i<Lista.Angajat.Count(); i++)
            {
                string Angajat = Lista.Angajat[i].NumeAngajat;
                string Firma = Lista.Angajat[i].NumeFirma;
                string Cnp = Lista.Angajat[i].CnpAngajat;
                string Procent = Lista.Angajat[i].ProcentajulMuncii;
                string Salar = Lista.Angajat[i].SalarAngajat;

                int auxCNP = int.Parse(Cnp);
                int auxSalar = int.Parse(Procent);
                int auxProcent = int.Parse(Salar);

                DataBase.DataBaseInstance.inserareAngajat(Angajat, auxCNP, auxSalar, auxProcent, Firma);
            }

            reader.Close();           
            UpDate();
            MessageBox.Show("Import Reusit");
        }

        private void EmiteFluturas_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            string cnp = dataGridView1.Rows[index].Cells["CNPAngajat"].Value.ToString();
            string salar = dataGridView1.Rows[index].Cells["SalarAngajat"].Value.ToString();
            string procent = dataGridView1.Rows[index].Cells["ProcentajulMuncii"].Value.ToString();
           
            int ProcentajulMuncii = int.Parse(procent);
            int SalarAngajat = int.Parse(salar);
            int CNPAngajat = int.Parse(cnp);
            string NumeAngajat = dataGridView1.Rows[index].Cells["NumeAngajat"].Value.ToString();
            string NumeFirma = dataGridView1.Rows[index].Cells["NumeFirma"].Value.ToString();

            var aux = DataBase.DataBaseInstance.Fluturas(CNPAngajat,SalarAngajat,ProcentajulMuncii,NumeAngajat,NumeFirma);
            if(aux == true)
            {
                MessageBox.Show("Fluturas introdus in baza de date");
            }
            else
            {
                MessageBox.Show("EROARE");
            }
        }

        private void button_PDF_Click(object sender, EventArgs e)
        {
            ExportPDF Form = new ExportPDF(NumeFirma);
            Hide();
            Form.ShowDialog();
            Show();
        }
    }
}
