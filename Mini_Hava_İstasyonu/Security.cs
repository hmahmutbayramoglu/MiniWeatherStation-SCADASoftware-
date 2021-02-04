using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Hava_İstasyonu
{
    public class Security
    {

        #region Field

        private string _username;

        private string _password;


        #endregion

        #region Property

        public string Username { get { return _username; } set { _username = value; } }

        public string Password { get { return _password; } set { _password = value; } }

        #endregion

    }
}
