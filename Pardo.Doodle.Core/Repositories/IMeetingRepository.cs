using Pardo.Doodle.Core.Common;
using Pardo.Doodle.Core.Model;

namespace Pardo.Doodle.Core.Repositories
{
    public interface IMeetingRepository: IRepository<Meeting,int>
    {
    }

    public interface IPersonRepository : IRepository<Person, int>
    {
        
    }
}
