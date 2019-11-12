namespace DesignPatternConsole.Interfaces.Mediator
{
    public interface IParticipant
    {
        void SendMessage(string message);
        string ParticipantName { get; set; }
    }
}