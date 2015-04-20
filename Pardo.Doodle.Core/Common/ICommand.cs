namespace Pardo.Doodle.Core.Common
{
    public interface ICommand<TCmdId>
    {
        TCmdId Id { get; }
    }
}