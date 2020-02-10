using Alcom.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alcom.BLL
{
   public class AdresRepository :BaseRepository<Adres, int>
    {
        public Adres KullanicininVarsayilanAdresiniGetir(int kullaniciId)
        {
            var kullanici = context.Kullanici.Find(kullaniciId);
          return  context.Adres.FirstOrDefault(x => x.Id == kullanici.VarsayilanAdresId.Value);
        }
    }
}
