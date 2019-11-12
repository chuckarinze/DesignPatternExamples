using System;
using DesignPatternConsole.ConcreteClasses.Factory.FactoryClient;
using DesignPatternConsole.ConcreteClasses.Mediator;
using DesignPatternConsole.ConcreteClasses.Observer;
using DesignPatternConsole.Interfaces.Mediator;
using DesignPatternConsole.Interfaces.Observer;

namespace DesignPatternConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Pattern pattern;

            if (args.Length == 0)
            {
                Console.WriteLine("Please 0 for mediator, 1 for observer or 2 for factory.");
                var chosenPattern = Console.ReadLine();
                var test = int.TryParse(chosenPattern, out num);
                if (!test) Console.WriteLine("You refused to enter a number so we will default to the Mediator.");
            }
            else
            {
                var test = int.TryParse(args[0], out num);
                if (!test) Console.WriteLine("You refused to enter a number so we will default to the Mediator.");
            }

            switch (num)
            {
                case 0:
                    pattern = Pattern.Mediator;
                    break;
                case 1:
                    pattern = Pattern.Observer;
                    break;
                case 2:
                    pattern = Pattern.Factory;
                    break;
                default:
                    pattern = Pattern.Mediator;
                    break;
            }

            switch (pattern)
            {
                case Pattern.Mediator:
                    IMediator mediator = new ConcreteMediator();
                    IParticipant participant1 = new ConcreteParticipant1(mediator, "Jay Hardcore");
                    IParticipant participant2 = new ConcreteParticipant2(mediator, "Chuck");
                    IParticipant participant3 = new ConcreteParticipant3(mediator, "Brenda");
                    IParticipant participant4 = new ConcreteParticipant4(mediator, "Hal Jordan");
                    mediator.AddParticipant(participant1);
                    mediator.AddParticipant(participant2);
                    mediator.AddParticipant(participant3);
                    mediator.AddParticipant(participant4);
                    participant1.SendMessage("Sending message for the first participant");
                    participant2.SendMessage("Sending message for  the second participant");
                    participant3.SendMessage("Sending message for the third participant");
                    participant4.SendMessage("Sending message for  the fourth participant");
                    mediator.BroadcastMessage("Mediator message for participant:", participant1);
                    mediator.BroadcastMessage("Mediator message for participant:", participant2);
                    mediator.BroadcastMessage("Mediator message for participant:", participant3);
                    mediator.BroadcastMessage("Mediator message for participant:", participant4);
                    break;
                case Pattern.Observer:
                    var observable = new Observable();
                    var anotherObservable = new AnotherObservable();

                    using (IObserver observer = new Observer(observable, "Tony Stark's Observer"))
                    {
                        Console.WriteLine(observer.GetName());
                        observer.GetName();
                        observable.DoSomething();
                        observer.Add(anotherObservable);
                        anotherObservable.DoSomething();
                    }

                    break;
                case Pattern.Factory:
                    new FactoryClient().EnergizeStarShipClient();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            Console.WriteLine("----------press enter to exit----------");
            Console.ReadLine();
        }

        public enum Pattern
        {
            Mediator = 0,
            Observer = 1,
            Factory = 2
        }
    }
}