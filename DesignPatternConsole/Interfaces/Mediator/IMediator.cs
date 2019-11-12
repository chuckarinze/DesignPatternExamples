namespace DesignPatternConsole.Interfaces.Mediator
{
    public interface IMediator
    {
        void AddParticipant(IParticipant participant);
        void BroadcastMessage(string message, IParticipant sender);
    }

}
