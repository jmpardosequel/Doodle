using System;
using Pardo.Doodle.Services.Common;

namespace Pardo.Doodle.Services.Commands
{
    public abstract class Command : ICommand<Guid>
    {
        public Guid Id { get; private set; }
    }
}