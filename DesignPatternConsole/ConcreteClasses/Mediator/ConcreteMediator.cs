using System;
using System.Collections.Generic;
using DesignPatternConsole.Interfaces.Mediator;

namespace DesignPatternConsole.ConcreteClasses.Mediator
{
    public class ConcreteMediator : IMediator
    {
        readonly List<IParticipant> _participants = new List<IParticipant>();
        public void AddParticipant(IParticipant participant)
        {
            _participants.Add(participant);
        }
        public void BroadcastMessage(string message, IParticipant sender)
        {
            // Write code here to broadcast the message to the participants
            Console.WriteLine("Broadcast Mediator: " + _participants.Count + " participants." + "Message " + message + " " + sender.ParticipantName);
        }
    }

}
