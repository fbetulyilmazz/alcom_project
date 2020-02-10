using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Alcom.Entity
{
    public class KargoBilgileri : Base
    {

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Firma Adı 2-20 karakter aralığında olmalıdır.")]
        public string FirmaAdi { get; set; }
        public int Durumu { get; set; }

        public int TeslimatAdresId { get; set; }

        public string KargoTakipNo { get; set; }

        //nav prop
        [ForeignKey("TeslimatAdresId")]
        public virtual Adres TeslimatAdresi { get; set; }
    }
}