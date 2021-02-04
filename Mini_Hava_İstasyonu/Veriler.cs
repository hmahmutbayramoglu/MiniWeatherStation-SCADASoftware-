using System;
using System.Collections.Generic;
using System.Data.OleDb; //...
using System.Data; //...
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Hava_İstasyonu
{
    class Veriler
    {

        #region Field
        private int _Sicaklik;

        private int _Nem;

        private double _Basinc;

        private bool _Yagis;

        private string _Tarih;

        #endregion

        #region Property

        public string Tarih { get { return _Tarih ; } set { _Tarih = Convert.ToDateTime(value).ToLongTimeString(); } }

        public int Sicaklik { get { return _Sicaklik; } set { _Sicaklik = value; } }

        public int Nem { get { return _Nem; } set { _Nem = value; } }

        public double Basinc { get { return _Basinc; } set { _Basinc = value; } }

        public bool Yagis { get { return _Yagis; } set { _Yagis = value; } }

        #endregion

    }
}
