using Pardo.Doodle.Core.Common;

namespace Pardo.Doodle.Core.Model
{
    public class  Person : IEntity<int>
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}