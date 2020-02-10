using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Alcom.Entity
{
    public class Il : Base
    {
        public Il()
        {
            this.Ilceleri = new HashSet<Ilce>();
        }
        [Required]
        public string Adi { get; set; }
        public int PlakaKodu { get; set; }
        //navigation properties
        public virtual ICollection<Ilce> Ilceleri { get; set; }

    }

    
}