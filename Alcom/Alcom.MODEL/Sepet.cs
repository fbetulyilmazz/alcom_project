using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Alcom.MODEL
{
    public class Sepet : Base
    {

        [Required]
        public int KullaniciId { get; set; }
        [Required]
        public decimal ToplamTutar { get; set; }

        //navigation properties
        [ForeignKey("KullaniciId")]
        public virtual Kullanici Kullanicisi { get; set; }

    }
}