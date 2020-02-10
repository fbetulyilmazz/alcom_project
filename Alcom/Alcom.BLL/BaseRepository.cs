using Alcom.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Alcom.BLL
{
    public class BaseRepository<T,ID>: IDisposable where T : class, new()
    {
        //crud işlemleri
        protected readonly AlcomContext context = new AlcomContext();

        public bool Ekle(T data)
        {
            //context.Set<T>().Add(data);
            var addedData = context.Entry<T>(data);
            addedData.State = EntityState.Added;
            int durum = context.SaveChanges();
            //ternary if
            //return durum > 0 ? true : false;
            return durum > 0 ;
        }

        public bool Guncelle(T data)
        {
            var updatedData = context.Entry<T>(data);
            updatedData.State = EntityState.Modified;
            int durum = context.SaveChanges();
            //ternary if
            //return durum > 0 ? true : false;
            return durum > 0;
        }

        public bool Sil(ID id)
        {
            //context.Set<T>().Add(data);
            //idsine göre silinecek datayı buluyorum.
            var data = context.Set<T>().Find(id);
            //state i değiştirerek siliyorum.
            var deletedData = context.Entry<T>(data);
            deletedData.State = EntityState.Deleted;
            int durum = context.SaveChanges();
            //ternary if
            //return durum > 0 ? true : false;
            return durum > 0;
        }
     
        public ICollection<T> Listele(Expression<Func<T,bool>> filtre = null)
        {
            if (filtre == null)
            {
                return context.Set<T>().ToList();
            }
           else
            {
                return context.Set<T>().Where(filtre).ToList();
            }

        }

        public T Getir(Expression<Func<T, bool>> filtre)
        {
            return context.Set<T>().FirstOrDefault(filtre);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~BaseRepository()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion


    }
}
