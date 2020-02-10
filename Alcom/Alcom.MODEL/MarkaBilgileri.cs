using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alcom.MODEL
{
    public class MarkaBilgileri:Base
    {
        public string Ad { get; set; }
        public int Durum { get; set; }
        //nav prop
        public virtual ICollection<Urun> Urunleri { get; set; }
    }
}