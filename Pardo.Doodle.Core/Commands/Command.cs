using System;
using Pardo.Doodle.Core.Common;

namespace Pardo.Doodle.Core.Commands
{
    public abstract class Command : ICommand<Guid>
    {
        public Guid Id { get; private set; }
    }
}