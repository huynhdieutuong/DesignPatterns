using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_SOLID
{
    // CEO class can replace Employee class, but in this case it throw exception => violated LSP
    //public static class LiskovSubstitution
    //{
    //    public static void Main()
    //    {
    //        Manager accountingVP = new Manager();
    //        accountingVP.FirstName = "Emma";
    //        accountingVP.LastName = "Stone";
    //        accountingVP.CalculatePerHourRate(4);

    //        Employee emp = new CEO();
    //        emp.FirstName = "Tim";
    //        emp.LastName = "Corey";
    //        emp.AssignManager(accountingVP); // throw exception with CEO
    //        emp.CalculatePerHourRate(2);

    //        Console.WriteLine($"{emp.FirstName}'s salary is {emp.Salary}/hour.");
    //    }
    //}

    //public class Employee
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public Employee Manager { get; set; } = null;
    //    public decimal Salary { get; set; }

    //    public virtual void AssignManager(Employee manager)
    //    {
    //        Manager = manager;
    //    }

    //    public virtual void CalculatePerHourRate(int rank)
    //    {
    //        decimal baseAmount = 12.50M;
    //        Salary = baseAmount + (rank * 2);
    //    }
    //}

    //public class Manager : Employee
    //{
    //    public override void CalculatePerHourRate(int rank)
    //    {
    //        decimal baseAmount = 19.75M;
    //        Salary = baseAmount + (rank * 4);
    //    }

    //    public void GeneratePerformanceReview()
    //    {
    //        Console.WriteLine("I'm reviewing a direct report's performance.");
    //    }
    //}

    //public class CEO : Employee
    //{
    //    public override void CalculatePerHourRate(int rank)
    //    {
    //        decimal baseAmount = 150M;
    //        Salary = baseAmount * rank;
    //    }

    //    public void GeneratePerformanceReview()
    //    {
    //        Console.WriteLine("I'm reviewing a direct report's performance.");
    //    }

    //    public override void AssignManager(Employee manager)
    //    {
    //        throw new InvalidOperationException("The CEO has no manager");
    //    }

    //    public void FireSomeone()
    //    {
    //        Console.WriteLine("You're Fired!");
    //    }
    //}

    
    public static class LiskovSubstitution // ================ Fix this case
    {
        public static void Main()
        {
            IManager accountingVP = new Manager();
            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate(4);

            IManaged emp = new Employee(); // CEO can't replace IManaged (defined below) => it's compliant with LSP
            // IEmployee emp2 = new CEO(); // CEO can replace IManager or IEmployee that don't have AssignManager method
            emp.FirstName = "Tim";
            emp.LastName = "Corey";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is {emp.Salary}/hour.");
        }
    }

    // Create 3 Interfaces
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }

        void CalculatePerHourRate(int rank);
    }

    public interface IManager : IEmployee
    {
        void GeneratePerformanceReview();
    }

    public interface IManaged : IEmployee
    {
        IEmployee Manager { get; set; }

        void AssignManager(IEmployee manager);
    }

    // Classes inherit Interfaces
    public class BaseEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;
            Salary = baseAmount + (rank * 2);
        }
    }

    public class Employee : BaseEmployee, IManaged
    {
        public IEmployee Manager { get; set; } = null;

        public void AssignManager(IEmployee manager)
        {
            Manager = manager;
        }
    }

    public class Manager : Employee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 19.75M;
            Salary = baseAmount + (rank * 4);
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }
    }

    public class CEO : BaseEmployee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;
            Salary = baseAmount * rank;
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }

        public void FireSomeone()
        {
            Console.WriteLine("You're Fired!");
        }
    }

}
