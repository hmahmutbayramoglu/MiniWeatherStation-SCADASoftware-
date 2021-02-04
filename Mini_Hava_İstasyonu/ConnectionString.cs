using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Mini_Hava_İstasyonu
{
    public class ConnectionString
    {

        #region İnstance
        private static ConnectionString _instance;

        private ConnectionString()
        {
        }

        public static ConnectionString Getİnstance()
        {
            if (_instance == null)
            {
                _instance = new ConnectionString();
            }
            return _instance;
        }

        #endregion

        public OleDbConnection ConString = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\WIN7\Desktop\DateBase\Mini_Hava_İstasyonu.accdb");


        public void Connection()
        {
            try
            {
                if (ConString.State == System.Data.ConnectionState.Closed)
                {
                    ConString.Open();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sql Connection Error 01", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Disconnect()
        {

            try
            {
                if (ConString.State == System.Data.ConnectionState.Open)
                {
                    ConString.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sql Disconnect Error 02", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
