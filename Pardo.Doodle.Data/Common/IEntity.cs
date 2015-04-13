namespace Pardo.Doodle.Data.Common
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}