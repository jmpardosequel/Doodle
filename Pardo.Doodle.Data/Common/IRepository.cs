namespace Pardo.Doodle.Data.Common
{
    public interface IRepository<TEnt,TKey> where TEnt: class, IEntity<TKey>
    {
        
    }
}