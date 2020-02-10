using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Alcom.Entity
{
    public class Kullanici :Base
    {
        [Required]
        [StringLength(20,MinimumLength =2, ErrorMessage ="Ad 2-20 karakter aralığında olmalıdır.")]
        public string Ad { get; set; }
        [Required]
        [StringLength(20,MinimumLength =2, ErrorMessage ="Soyad 2-20 karakter aralığında olmalıdır.")]
        public string Soyad { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }
        [Required]
        [StringLength(20,MinimumLength =5, ErrorMessage ="Kullanici adı 5-20 karakter aralığında olmalıdır.")]
        //[Index(IsUnique=true)]
        public string KullaniciAdi { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? DogumTarihi { get; set; }
        public int? VarsayilanAdresId { get; set; }
        public int Durum { get; set; }
        public DateTime SonGirisZamani { get; set; }

        //navigation prop 
        public virtual ICollection<Rol> Rolleri { get; set; }
    }
}