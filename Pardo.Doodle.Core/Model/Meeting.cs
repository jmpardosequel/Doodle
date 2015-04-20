using System.Collections.Generic;
using Pardo.Doodle.Core.Common;

namespace Pardo.Doodle.Core.Model
{
    public class Meeting : IEntity<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        public Person Organizer { get; set; }

        public IList<Person> Attendants { get; set; }
        public IList<DatePropossal> DatePropossals { get; set; }

    }
}