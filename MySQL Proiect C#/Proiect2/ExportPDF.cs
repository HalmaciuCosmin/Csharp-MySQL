using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Proiect2
{
    public partial class ExportPDF : Form
    {
        
        public ExportPDF(string nume)
        {                  
            InitializeComponent();
            DataTable table = DataBase.DataBaseInstance.getFluturas(nume);
            dataGridView1.DataSource = table;
        }

        private void button_PDF_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            string cnp = dataGridView1.Rows[index].Cells["CNPAngajat"].Value.ToString();
            string salar = dataGridView1.Rows[index].Cells["SalarAngajatNet"].Value.ToString();
            string procent = dataGridView1.Rows[index].Cells["ProcentajulMuncii"].Value.ToString();


            int CNPAngajat = int.Parse(cnp);
            int SalarAngajatNet = int.Parse(salar);
            int ProcentajulMuncii = int.Parse(procent);
            string PrimesteBonus = dataGridView1.Rows[index].Cells["PrimesteBonus"].Value.ToString();
            string ImpozitSiTaxe = dataGridView1.Rows[index].Cells["ImpozitSiTaxe"].Value.ToString();
            string SalarAngajatBrut = dataGridView1.Rows[index].Cells["SalarAngajatBrut"].Value.ToString();
            string NumeAngajat = dataGridView1.Rows[index].Cells["NumeAngajat"].Value.ToString();
            string NumeFirma = dataGridView1.Rows[index].Cells["NumeFirma"].Value.ToString();
            string Data = dataGridView1.Rows[index].Cells["Data"].Value.ToString();


            string Fname = $"Fluturas.pdf";
            Document doc = new Document();
            FileStream file  = new FileStream(Fname, FileMode.Create);
            PdfWriter.GetInstance(doc, file);
            doc.Open();

            string aux1 = $"NUME: {NumeAngajat}";
            string aux2 = $"CNP : {CNPAngajat}";
            string aux3 = $"FIRMA: {NumeFirma}";
            string aux4 = $"DATA : {Data}";
            string aux5 = "----------------------";
            string aux6 = $"Salar baza : {SalarAngajatNet}";
            string aux7 = $"Impozite/Taxe : {ImpozitSiTaxe}";
            string aux8 = $"Salar net : {SalarAngajatNet}";

            Paragraph p1 = new Paragraph(aux1); Paragraph p2 = new Paragraph(aux2);
            Paragraph p3 = new Paragraph(aux3); Paragraph p4 = new Paragraph(aux4);         
            Paragraph p5 = new Paragraph(aux5); Paragraph p6 = new Paragraph(aux6);
            Paragraph p7 = new Paragraph(aux7); Paragraph p8 = new Paragraph(aux8);
   

            doc.Add(p1); doc.Add(p2); doc.Add(p3);
            doc.Add(p4); doc.Add(p5); doc.Add(p6);
            doc.Add(p7); doc.Add(p8);

            doc.Close();
            MessageBox.Show("PDF creat");
            this.Close();
        }

            
    }
}
