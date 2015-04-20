using Pardo.Doodle.Core.Common;

namespace Pardo.Doodle.Core.Commands
{
    public class CreateMeetingCommand : Command
    {
        public CreateMeetingCommand() 
        {
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string OrganizerName { get; set; }
        public string OrganizerEmail { get; set; }

    }
}