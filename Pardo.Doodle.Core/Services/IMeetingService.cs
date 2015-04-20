using Pardo.Doodle.Core.Commands;

namespace Pardo.Doodle.Core.Services
{
    public interface IMeetingService
    {
        void Create(CreateMeetingCommand createMeetingCommand);
    }
}