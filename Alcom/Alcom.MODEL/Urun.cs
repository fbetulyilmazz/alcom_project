using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Alcom.MODEL
{
    public class Urun : Base
    {
        [Required]
        [ForeignKey("Kategorisi")]
        public int KategoriId { get; set; }
        [Required]
        public int UrunKodu { get; set; }
        [Required]
        public int MarkaId { get; set; }
        [Required]
        public int UrunOzellikId { get; set; }
        [Required]
        public string UrunAdi { get; set; }
        public decimal Fiyati { get; set; }
        public int Durum { get; set; }
        public int Stok { get; set; }

        //navigation properties
        //[ForeignKey("KategoriId")]
        public virtual Kategori Kategorisi { get; set; }
        [ForeignKey("MarkaId")]
        public virtual MarkaBilgileri Markasi { get; set; }
        [ForeignKey("UrunOzellikId")]
        public virtual UrunOzellikleri UrununOzellikleri { get; set; }
    }
}