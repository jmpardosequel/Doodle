using Pardo.Doodle.Data.Common;

namespace Pardo.Doodle.Data.Model
{
    public abstract class Person: IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

    }
}
