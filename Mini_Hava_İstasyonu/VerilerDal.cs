using System;
using System.Collections.Generic;
using System.Data;//...
using System.Data.OleDb;//...
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Hava_İstasyonu
{
    class VerilerDal
    {

        ConnectionString Connection = ConnectionString.Getİnstance();

        private static VerilerDal _instace;
        private VerilerDal()
        { }
        public static VerilerDal Getİnstace()
        {
            if (_instace == null)
            {
                _instace = new VerilerDal();
            }
            return _instace;
        }

        // public OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\WIN7\\Desktop\\Mini_Hava_İstasyonu.accdb"); //   ACCESS Bağlantı yolu

        public void add(Veriler veriler)
        {
            Connection.Connection();
            string Sorgu = "insert into Veriler (Tarih,Sıcaklık,Nem,Basınc,Yagmur) values (@Tarih,@Sıcaklık, @Nem, @Basınc, @Yagmur)";
            OleDbCommand komut = new OleDbCommand(Sorgu, Connection.ConString);
            komut.Parameters.AddWithValue("@Tarih", veriler.Tarih);
            komut.Parameters.AddWithValue("@Sıcaklık", veriler.Sicaklik);
            komut.Parameters.AddWithValue("@Nem", veriler.Nem);
            komut.Parameters.AddWithValue("@Basınc", veriler.Basinc);
            komut.Parameters.AddWithValue("@Yagmur", veriler.Yagis);
            //VeriTabanından Değişkenlerin Türünü Değiştirdim
            komut.ExecuteNonQuery();
            Connection.Disconnect();
        }

        //Diğer Alanlarada Aynı Şekilde Yapabilirsiniz Design Patterns Kurallarına Uyarak Yapmış OLduumuz Bağlantı sınıfı Bu kadar

        DataTable table;
        public DataTable Refresh()
        {
            Connection.Connection();
            table = new DataTable();  // Tarih , Sicaklik as Sıcaklık , Nem , Basinc as Basınc , Yagmur
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from Veriler ", Connection.ConString);
            adtr.Fill(table);
            Connection.Disconnect();
            return table;
        }

        public void Delete()
        {
            Connection.Connection();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = Connection.ConString;
            komut.CommandText = "Delete From Veriler";
            komut.ExecuteNonQuery();
            Connection.Disconnect();
        }

        public int Ort(string Command)
        {

            Connection.Connection();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = Connection.ConString;
            komut.CommandText = Command;
            string deger = komut.ExecuteScalar().ToString();
            Connection.Disconnect();
            return Convert.ToInt32(deger);
        }

        public void topla(Label lbl)
        {
            Connection.Connection();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = Connection.ConString;
            komut.CommandText = "SELECT Sıcaklık, COUNT(Sıcaklık) AS ADET FROM Veriler GROUP BY Sıcaklık HAVING COUNT(*) > 0";
            lbl.Text = komut.ExecuteScalar().ToString();
            Connection.Disconnect();
        }



    }
}
