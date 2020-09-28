using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proiect2
{
    class DataBase
    {

        private SqlConnection conn = new SqlConnection(" Server=DESKTOP-10427CP\\KBSQL; Database = BazaDeDate; Trusted_Connection = true");

        private DataBase()
        {
            Open();
        }

        public static DataBase _handl = new DataBase();
        public static DataBase DataBaseInstance
        {
            get
            {
                return _handl;
            }
        }
        




        private void Open()
        {
            conn.Open();
        }

        public bool LogIn(string NumeFirma , string Parola)
        {
            string aux =  $"SELECT * From Firma WHERE NumeFirma = '{NumeFirma}' AND Parola = '{Parola}' ";
            SqlDataAdapter sda = new SqlDataAdapter(aux, conn);
            DataTable table = new DataTable();
            sda.Fill(table);

            if (table.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckNumeFirma(string NumeFirma)
        {
            
            string aux = $"SELECT * FROM Firma WHERE NumeFirma = '{NumeFirma}' ";
            SqlDataAdapter sda = new SqlDataAdapter(aux, conn);
            DataTable table = new DataTable();
            sda.Fill(table);
            
            if(table.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool Register(string NumeFirma,string Parola)
        {
            if (CheckNumeFirma(NumeFirma) == true)
            {
                return false;
            }

            else
            {
                int a = 0;
                string aux = $"Insert into Firma(NumeFirma,Parola,NumarAngajati) VALUES ('{NumeFirma}' , '{Parola}' , '{a}')";
                SqlCommand cmd = new SqlCommand(aux, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            
        }

        public DataTable getData( string numeFirma) 
        {
            string aux = $"SELECT * From Angajati WHERE NumeFirma = '{numeFirma}' ";
            SqlCommand comanda = new SqlCommand(aux, conn);


            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = comanda;
            DataTable table = new DataTable();
            adaptor.Fill(table);
            return table;           
        }

        public bool inserareAngajat( string NumeAngajat, int CNPAngajat, int SalarAngajat, int ProcentajulMuncii, string NumeFirma)
        {
            string aux = $"Insert into Angajati(NumeAngajat,CNPAngajat,SalarAngajat,ProcentajulMuncii,NumeFirma) VALUES " +
                             $"('{NumeAngajat}' , '{CNPAngajat}', '{SalarAngajat}', '{ProcentajulMuncii}', '{NumeFirma}')";
            SqlCommand cmd = new SqlCommand(aux, conn);
            cmd.ExecuteNonQuery();
            return true;

        }

        public void updateNumarAngajati(string numeFirma) 
        {
            string aux = $"SELECT COUNT(*) FROM Angajati WHERE NumeFirma = '{numeFirma}'";
            SqlCommand comanda = new SqlCommand(aux, conn);
            Int32 count = (Int32)comanda.ExecuteScalar();

            string aux1 = $"UPDATE Firma SET NumarAngajati = {count} WHERE NumeFirma = '{numeFirma}'";
            SqlCommand comanda1 = new SqlCommand(aux1, conn);
            comanda1.ExecuteNonQuery();

        }

        public bool updateAngajat(int AngajatCNP, string numeAngajat, int salarAngajat , int procentAngajat)
        {

            if(cautaAngajat(AngajatCNP) == true )
            {
                string aux1 = $"UPDATE Angajati SET NumeAngajat  = '{numeAngajat}' , SalarAngajat = '{salarAngajat}' , ProcentajulMuncii = '{procentAngajat}' WHERE CNPAngajat  = '{AngajatCNP}'";
                SqlCommand comanda1 = new SqlCommand(aux1, conn);
                comanda1.ExecuteNonQuery();
                return true;
            }
            else
            {
                return false;
            }
        
        }

        public bool cautaAngajat(int CNPAngajat)
        {
            string aux = $"SELECT * FROM Angajati WHERE CNPAngajat = '{CNPAngajat}' ";
            SqlDataAdapter sda = new SqlDataAdapter(aux, conn);
            DataTable table = new DataTable();
            sda.Fill(table);

            if (table.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public bool StergeAngajat(int CNPAngajat)
        {
            if(cautaAngajat(CNPAngajat) == true)
            {
                string aux = $"DELETE FROM Angajati WHERE CNPAngajat = '{CNPAngajat}'";
                SqlCommand comanda1 = new SqlCommand(aux, conn);
                comanda1.ExecuteNonQuery();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void dropAngajati()
        {
            string aux = "DELETE FROM Angajati";
            SqlCommand comanda1 = new SqlCommand(aux, conn);
            comanda1.ExecuteNonQuery();

        }

        public void dropFluturas()
        {
            string aux = "DELETE FROM Fluturas";
            SqlCommand comanda1 = new SqlCommand(aux, conn);
            comanda1.ExecuteNonQuery();

        }

        public void dropFirma()
        {
            string aux = "DELETE FROM Firma";
            SqlCommand comanda1 = new SqlCommand(aux, conn);
            comanda1.ExecuteNonQuery();

        }


        public bool Fluturas(int CNPAngajat, int SalarAngajat, int ProcentulMuncii, string NumeAngajat , string NumeFirma)
        {
            string PrimesteBonus;
            double aux;


            if (95 <= ProcentulMuncii)
            {
                PrimesteBonus = "Da";
                aux = SalarAngajat - SalarAngajat * 0.21 + 200;
            }
            else
            {
                PrimesteBonus = "Nu";
                aux = SalarAngajat - SalarAngajat * 0.21;
            }

            string aux1 = aux.ToString();
            string SalarAngajatBrut = String.Format("{0:0.00}", aux1);
            string ImpozitSiTaxe = "21%";
            string Data = DateTime.Today.ToString("dd/MM/yyyy");

            string aux2 = $"Insert into Fluturas(CNPAngajat,SalarAngajatNet,ProcentajulMuncii,PrimesteBonus,ImpozitSiTaxe,SalarAngajatBrut,NumeAngajat,NumeFirma,Data) VALUES " +
                              $"('{CNPAngajat}','{SalarAngajat}' , '{ProcentulMuncii}', '{PrimesteBonus}', '{ImpozitSiTaxe}','{SalarAngajatBrut}','{NumeAngajat}', '{NumeFirma}' ,'{Data}')";

            SqlCommand comanda1 = new SqlCommand(aux2, conn);
            comanda1.ExecuteNonQuery();
            return true;
        }


        public DataTable getFluturas(string numeFirma)
        {
            string aux = $"SELECT * From FLuturas WHERE NumeFirma = '{numeFirma}' ";
            SqlCommand comanda = new SqlCommand(aux, conn);


            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = comanda;
            DataTable table = new DataTable();
            adaptor.Fill(table);
            return table;
        }

    }
}
