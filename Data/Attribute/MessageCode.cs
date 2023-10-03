using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Attribute
{
    public class MessageCode
    {   public enum Codes
        {
            [Description("Başarılı işlem")]
            basarili = 100,
            [Description("Başarısız işlem")]
            basarisiz = 200,
            [Description("Hatalı işlem")]
            hata = 300,
            [Description("Listeleme Hatası")]
            listeleme_hata = 301,
            [Description("username or passord is wrong")]
            Yetki_Hata = 400
        }
       
    }
}
