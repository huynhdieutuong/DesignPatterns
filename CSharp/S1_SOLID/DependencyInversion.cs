using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_SOLID
{
    // High-level modules shouldn't depend on low-level modules. Both should depend on abstractions and abstractions shouldn't depend on detail.
    //public static class DependencyInversion
    //{
    //    // Main (high-level) depends on Person, Chore (low-level) => violet DIP
    //    public static void Main()
    //    {
    //        Person owner = new Person
    //        {
    //            FirstName = "Tim",
    //            LastName = "Corey",
    //            EmailAddress = "tim@iamtimcorey.com",
    //            PhoneNumber = "555-1212"
    //        };

    //        Chore chore = new Chore
    //        {
    //            ChoreName = "Take out the trash",
    //            Owner = owner
    //        };

    //        chore.PerformedWork(3);
    //        chore.PerformedWork(1.5);
    //        chore.CompleteChore();

    //        Console.WriteLine();
    //    }
    //}

    //// Chore (high-level) depends on Logger, Emailer (low-level) => violet DIP
    //public class Chore
    //{
    //    public string ChoreName { get; set; }
    //    public Person Owner { get; set; }
    //    public double HoursWorked { get; set; }
    //    public bool IsComplete { get; set; }

    //    public void PerformedWork(double hours)
    //    {
    //        HoursWorked += hours;
    //        Logger log = new Logger();
    //        log.Log($"Performed work on {ChoreName}");
    //    }

    //    public void CompleteChore()
    //    {
    //        IsComplete = true;

    //        Logger log = new Logger();
    //        log.Log($"Completed {ChoreName}");

    //        Emailer emailer = new Emailer();
    //        emailer.SendEmail(Owner, $"The chore {ChoreName} is complete.");
    //    }
    //}

    //public class Logger
    //{
    //    public void Log(string message)
    //    {
    //        Console.WriteLine($"Write to Console: {message}");
    //    }
    //}

    //public class Emailer
    //{
    //    public void SendEmail(Person person, string message)
    //    {
    //        Console.WriteLine($"Simulating sending an email to {person.EmailAddress}");
    //    }
    //}

    //public class Person
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string PhoneNumber { get; set; }
    //    public string EmailAddress { get; set; }
    //}

    public static class DependencyInversion
    {
        // ============= Fix to comply Denpendency Inversion Principle
        // Main depends on IPerson, IChore (interfaces) and Factory.
        public static void Main()
        {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Tim";
            owner.LastName = "Corey";
            owner.EmailAddress = "tim@iamtimcorey.com";
            owner.PhoneNumber = "555-1212";

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.WriteLine();
        }
    }

    public static class Factory
    {
        public static IPerson CreatePerson() => new Person();
        public static IChore CreateChore() => new Chore(CreateLogger(), CreateMesasgeSender());
        public static ILogger CreateLogger() => new Logger();
        // When change Texter, we'll change only in Factory (instead of change multiple places that use Emailer class)
        //public static IMessageSender CreateMesasgeSender() => new Emailer();
        public static IMessageSender CreateMesasgeSender() => new Texter();
    }

    // Create Interfaces
    public interface IPerson
    {
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
    }

    public interface IChore
    {
        string ChoreName { get; set; }
        double HoursWorked { get; set; }
        bool IsComplete { get; set; }
        IPerson Owner { get; set; }

        void CompleteChore();
        void PerformedWork(double hours);
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public interface IMessageSender
    {
        void SendMessage(IPerson person, string message);
    }

    // Implement Interfaces
    public class Chore : IChore
    {
        ILogger _logger;
        IMessageSender _messageSender;

        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; set; }
        public bool IsComplete { get; set; }

        // We use Dependency Injection to inject ILogger, IMessageSender.
        // We we change IMessageSender to ITexter, we'll change only where Inject (instead of change multiple places that use Emailer class)
        public Chore(ILogger logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            ILogger log = Factory.CreateLogger();
            log.Log($"Performed work on {ChoreName}");
        }

        public void CompleteChore()
        {
            IsComplete = true;

            // Logger log = new Logger();
            _logger.Log($"Completed {ChoreName}");

            // Emailer emailer = new Emailer();
            _messageSender.SendMessage(Owner, $"The chore {ChoreName} is complete.");
        }
    }

    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Write to Console: {message}");
        }
    }

    public class Emailer : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"Simulating sending an email to {person.EmailAddress}");
        }
    }

    public class Texter : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"I am texting {person.FirstName} to say {message}");
        }
    }

    public class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
