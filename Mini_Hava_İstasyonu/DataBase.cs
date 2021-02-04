using System;
using System.Collections.Generic;
using System.Data; //...
using System.Data.OleDb; //...
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Hava_İstasyonu
{
    interface DataBase
    {
        //İnterfaceler sadece metodun İmzasını Tutar 
        //İnterface kullanılmasının Nedeni Yazılımın Devamlılığı İçin Farklı Veri Tabanlarını Direnç Göstermeden Ekleyebilmemizi Sağlayacak

         void Save_Delete_Update(OleDbCommand komut, string sorgu);

         DataTable Refresh(OleDbDataAdapter adtr, string sorgu);

    }
}
