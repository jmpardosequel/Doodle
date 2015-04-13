using System.Collections.Generic;
using Pardo.Doodle.Data.Common;

namespace Pardo.Doodle.Data.Model
{
    public class Event : IEntity<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        public Organizer Organizer { get; set; }

        public IList<Attendant> Attendants { get; set; }
        public IList<DatePropossal> DatePropossals { get; set; }

    }
}