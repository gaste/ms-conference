using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Conference.Business.Interfaces
{
    public interface IService <TEntity, TKey> where TEntity : class
    {
        void Add(TEntity newItem);
        void Update(TEntity changedItem);
        void Delete(TEntity deleteItem);

        IEnumerable<TEntity> GetItems();

        TEntity GetSingleItemByID(TKey id);       

    }
}
