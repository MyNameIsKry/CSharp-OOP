namespace QuanLyNhanVien {
    public interface IWork {
        void Work();
    }

    abstract class Employee: IWork {
        protected string Name { get; set; }
        protected int Age { get; set; }
        protected double Salary { get; set; }

        public Employee(string name, int age, double salary) {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public abstract void Work();

        public virtual void ShowInfo() {
            Console.WriteLine($"Tên: {Name}\nTuổi: {Age}\nLương: {Salary}");
        }
    }

    class Developer: Employee {
        protected string[] Languages { get; set; }

        public Developer(string name, int age, int salary, string[] languages) : base(name, age, salary) {
            Languages = languages;
            Console.WriteLine(languages);
        }

        public override void Work() {
            Console.WriteLine($"Làm việc với ngôn ngữ: {string.Join(", ", Languages)}");
        }

        public override void ShowInfo() {
            base.ShowInfo();
            Console.WriteLine($"Ngôn ngữ lập trình: {string.Join(", ", Languages)}");
        }
    }

    class Manager: Employee {
        protected int TeamSize { get; set; }

        public Manager(string name, int age, double salary, int teamSize): base(name, age, salary) {
            TeamSize = teamSize;
        }

        public override void Work() {
            Console.WriteLine($"Quản lý {TeamSize} người trong team");
        }
    }

    class Program {
        public static void Main() {
            List<Employee> employees = new List<Employee> {
                new Developer("Cá", 25, 2000, ["C#", "TypeScript"]),
                new Manager("Riki", 35, 5000, 10)
            };

            Console.WriteLine("Danh sách:");

            foreach(Employee e in employees) {
                e.ShowInfo();
                e.Work();
                Console.WriteLine("----------------------");
            }
        }
    }
}