using System.Security.Cryptography;

namespace ProgramTest {
    public enum JobType {
        Developer,
        Leader
    }
    public abstract class Employee {
        protected string Name { get; set; }
        protected int Age { get; set; }
        protected double Salary { get; set; }
        protected string JobName { get; set; }
        public Employee(string name, int age, double salary, string jobName) {
            Name = name;
            Age = age;
            Salary = salary;
            JobName = jobName;
        }
        public abstract void Work();
        public virtual void ShowInfo() => Console.WriteLine($"Tên: {Name}\nTuổi: {Age}\nLương: {Salary}$\nCông việc: {JobName}");
    }

    public class Developer: Employee {
        public Developer(string name, int age, double salary, string jobName): base(name, age, salary, jobName) {}
        public override void Work() => Console.WriteLine("Đang fix bug sml....");
        public override void ShowInfo()
        {
            base.ShowInfo();
            Work();
        }
    }

    public class Manager: Employee {
        public Manager(string name, int age, double salary, string jobName): base(name, age, salary, jobName) {}
        public override void Work() => Console.WriteLine("Đang quản lý...");
        public override void ShowInfo()
        {
            base.ShowInfo();
            Work();
        }
    }

    public sealed class EmployeeFactory {
        public static Employee CreateEmployee(string name, int age, double salary, string jobName, JobType jobType) {
            return jobType switch
            {
                JobType.Developer => new Developer(name, age, salary, jobName),
                JobType.Leader => new Manager(name, age, salary, jobName),
                _ => throw new NotImplementedException()
            };
        }

        public static void Main() {
            Employee dev = EmployeeFactory.CreateEmployee("Cá", 20, 100000, "Developer", JobType.Developer);
            dev.ShowInfo();
            Console.WriteLine();
            Employee lead = EmployeeFactory.CreateEmployee("Vẹt", 19, 100000000, "Leader", JobType.Leader);
            lead.ShowInfo();
        } 
    }
}