using Pardo.Doodle.Services.Common;

namespace Pardo.Doodle.Services.Commands
{
    public class CreateEventCommand : Command
    {
        public CreateEventCommand(ICommandHandler handler) 
        {
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string OrganizerName { get; set; }
        public string OrganizerEmail { get; set; }

    }
}