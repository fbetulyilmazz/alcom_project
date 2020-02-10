using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Alcom.Entity
{
    public class Satis : Base
    {
        [Required]
        //[Index(IsUnique=true)]
        public int SepetId { get; set; }
        public decimal? IndirimTutari { get; set; }
        public double? IndirimOrani { get; set; }
        [Required]
        public decimal SatisTutari { get; set; }
        [Required]
        public int SatisDurumu { get; set; }
        [Required]
        public int FaturaAdresiId { get; set; }

        public Nullable<int> KargoId { get; set; }

        //nav prop
        [ForeignKey("SepetId")]
        public virtual Sepet Sepeti { get; set; }

        [ForeignKey("KargoId")]
        public virtual KargoBilgileri KargoBilgileri { get; set; }
        //[ForeignKey("FaturaAdresiId")]
        //public virtual Adres FaturaAdresi { get; set; }

    }
}