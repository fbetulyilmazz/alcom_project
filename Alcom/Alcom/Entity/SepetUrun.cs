using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Alcom.Entity
{
    public class SepetUrun :Base
    {
        public int SepetId { get; set; }
        public int UrunId { get; set; }
        public int Adet { get; set; }

        //nav prop
        [ForeignKey("SepetId")]
        public virtual Sepet Sepeti { get; set; }
        [ForeignKey("UrunId")]
        public virtual Urun Urunu { get; set; }
    }
}