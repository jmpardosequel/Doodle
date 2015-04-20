using System;
using System.Linq;

namespace Pardo.Doodle.Core.Common
{
    public interface IRepository<TEnt,TKey> where TEnt: class, IEntity<TKey>
    {
        TEnt Get(TKey id);

        void Add(TEnt meeting);

        IQueryable<TEnt> Find(Func<TEnt, bool> predicate);
    }
}