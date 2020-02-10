using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Alcom.MODEL
{
    public class Ilce:Base
    {
        public int IlId { get; set; }
        [Required]
        public string Adi { get; set; }
        //navigation properties
        [ForeignKey("IlId")]
        public virtual Il Ili { get; set; }
    }
}