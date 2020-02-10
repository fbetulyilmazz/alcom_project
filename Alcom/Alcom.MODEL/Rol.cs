using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Alcom.MODEL
{
    public class Rol : Base
    {
        public bool Durum { get; set; }
        [Required]
        public string Aciklama { get; set; }
        //nav prop

        public virtual ICollection<Kullanici> Kullanicilari { get; set; }
    }
}