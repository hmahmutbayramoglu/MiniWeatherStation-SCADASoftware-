using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;//...

namespace Mini_Hava_İstasyonu
{
    public class LogınControl
    {

        ConnectionString conString = ConnectionString.Getİnstance();


        public bool Control(string Command)
        {
            bool Onay = false;
            try
            {

                conString.Connection();
                OleDbCommand kmt = new OleDbCommand(Command, conString.ConString);
                OleDbDataReader oku = kmt.ExecuteReader();
                if (oku.Read())
                {
                    Onay = true;
                }
                else
                {
                    conString.Disconnect();
                    Onay = false;
                }

            }
            catch (Exception)
            {}
            return Onay;
        }

        public void Add(Security security)
        {
            try
            {
                conString.Connection();
                //...
                OleDbCommand command = new OleDbCommand("insert into Güvenlik (ad , sifre) Values (@ad , @sifre)");
                command.Parameters.AddWithValue("@ad", security.Username);
                command.Parameters.AddWithValue("@sifre", security.Password);
                command.Connection = conString.ConString;
                command.ExecuteNonQuery();
                //...
                conString.Disconnect();
            }
            catch (Exception)
            {
            }

        }
    }
}
