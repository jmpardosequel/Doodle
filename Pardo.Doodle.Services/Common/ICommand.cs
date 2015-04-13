namespace Pardo.Doodle.Services.Common
{
    public interface ICommand<TCmdId>
    {
        TCmdId Id { get; }
    }
}