namespace Pardo.Doodle.Core.Common
{
    public interface IRepository<TEnt,TKey> where TEnt: class, IEntity<TKey>
    {
        
    }
}