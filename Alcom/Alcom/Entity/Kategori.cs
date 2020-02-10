using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Alcom.Entity
{
    public class Kategori:Base
    {
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Kategori Id 2-50 karakter aralığında olmalıdır.")]
        public string Adi { get; set; }
        public int? UstKategoriId { get; set; }

        //navigation properties
        public virtual ICollection<Urun> Urunleri { get; set; }

        [ForeignKey("UstKategoriId")]
        public virtual Kategori UstKategorisi { get; set; }
    }
}