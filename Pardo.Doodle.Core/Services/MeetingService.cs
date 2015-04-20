using System;
using System.Linq;
using Pardo.Doodle.Core.Commands;
using Pardo.Doodle.Core.Model;
using Pardo.Doodle.Core.Repositories;

namespace Pardo.Doodle.Core.Services
{
    public class MeetingService : IMeetingService
    {
        private readonly IMeetingRepository _repository;
        private readonly IPersonRepository _personRepository;

        public MeetingService(IMeetingRepository repository, 
                              IPersonRepository personRepository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("repository");
            }

            if (personRepository == null)
            {
                throw new ArgumentNullException("personRepository");
            }
            
            _repository = repository;
            _personRepository = personRepository;
        }

        public void Create(CreateMeetingCommand createMeetingCommand)
        {
            if (createMeetingCommand == null)
            {
                throw new ArgumentNullException("createMeetingCommand");
            }

            Person organizer = _personRepository.Find(x => x.Email == createMeetingCommand.OrganizerEmail)
                                                .SingleOrDefault();

            if (organizer == null)
            {
                organizer = new Person()
                {
                    Email = createMeetingCommand.OrganizerEmail,
                    Name = createMeetingCommand.OrganizerName
                };

                _personRepository.Add(organizer);
            }

            var newMeeting = new Meeting()
            {
                Title = createMeetingCommand.Title,
                Location = createMeetingCommand.Location,
                Description = createMeetingCommand.Description,
                Organizer = organizer,
            };

            _repository.Add(newMeeting);

            // Uow.Commit();
        }
    }
}