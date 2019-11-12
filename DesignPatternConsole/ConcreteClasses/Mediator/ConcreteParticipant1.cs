using System;
using DesignPatternConsole.Interfaces.Mediator;

namespace DesignPatternConsole.ConcreteClasses.Mediator
{
    public class ConcreteParticipant1 : IParticipant
    {
        protected IMediator Mediator;

        public ConcreteParticipant1(IMediator mediator, string name = "")
        {
            Mediator = mediator;
            ParticipantName = !string.IsNullOrWhiteSpace(name)
                ? "Participant: " + name
                : "Participant: " + Guid.NewGuid();
        }

        public void SendMessage(string message)
        {
            Mediator.BroadcastMessage(message + " for " + ParticipantName, this);
        }

        public string ParticipantName { get; set; }
    }

    public class ConcreteParticipant2 : IParticipant
    {
        protected IMediator Mediator;

        public ConcreteParticipant2(IMediator mediator, string name = "")
        {
            Mediator = mediator;
            ParticipantName = !string.IsNullOrWhiteSpace(name)
                ? "Participant: " + name
                : "Participant: " + Guid.NewGuid();
        }

        public void SendMessage(string message)
        {
            Mediator.BroadcastMessage(message + " nothing mega for " + ParticipantName, this);
        }

        public string ParticipantName { get; set; }
    }

    public class ConcreteParticipant3 : IParticipant
    {
        protected IMediator Mediator;

        public ConcreteParticipant3(IMediator mediator, string name = "")
        {
            Mediator = mediator;
            ParticipantName = !string.IsNullOrWhiteSpace(name)
                ? "Participant: " + name
                : "Participant: " + Guid.NewGuid();
        }

        public void SendMessage(string message)
        {
            Mediator.BroadcastMessage(message + " with another implementation for " + ParticipantName, this);
        }

        public string ParticipantName { get; set; }
    }

    public class ConcreteParticipant4 : IParticipant
    {
        protected IMediator Mediator;

        public ConcreteParticipant4(IMediator mediator, string name = "")
        {
            Mediator = mediator;
            ParticipantName = !string.IsNullOrWhiteSpace(name)
                ? "Participant: " + name
                : "Participant: " + Guid.NewGuid();
        }

        public void SendMessage(string message)
        {
            Mediator.BroadcastMessage(message + " with some details for " + ParticipantName, this);
        }

        public string ParticipantName { get; set; }
    }
}