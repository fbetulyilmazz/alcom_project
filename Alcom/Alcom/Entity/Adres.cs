using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Alcom.Entity
{
    public class Adres : Base
    {
        public int KullaniciId { get; set; }
        public int IlceId { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Adres 2-200 karakter aralığında olmalıdır.")]
        public string Aciklama { get; set; }
       
        //navigation properties
        [ForeignKey("IlceId")]
        public virtual Ilce Ilcesi { get; set; }
        [ForeignKey("KullaniciId")]
        public virtual Kullanici Kullanicisi { get; set; }
    }
}