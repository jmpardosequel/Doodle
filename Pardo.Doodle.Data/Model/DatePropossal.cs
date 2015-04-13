using System;
using System.Collections.Generic;

namespace Pardo.Doodle.Data.Model
{
    public class DatePropossal
    {
        public DateTime Date { get; private set; }
        public IList<TimeSpan> Times { get; private set; } 
    }
}