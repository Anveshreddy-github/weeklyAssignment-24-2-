using CSharpAssessment;
using ooops_practice_;
using Practise_exam;

namespace oops_practice_
{
    public class Program
    {
        public void BankAccount()
        {
            BankAccount account = new BankAccount(12345, 1000);
            account.Deposit(500);
            account.GetBalance();
            account.Withdraw(200);
            account.GetBalance();
        }

        public void Vehicle()
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Start();
            Car car = new Car();
            car.Start();
            Bike bike = new Bike();
            bike.Start();
        }
        public void Shape()
        {
            Rectangle rectangle = new Rectangle(10, 20);
            rectangle.CalculateArea();

            Circle circle = new Circle(5);
            circle.CalculateArea();
        }
        public void Book()
        {
            Book book1 = new Book("Harry Potter");
            Book book2 = new Book("Harry Potter", "J.K. Rowling");
            Book book3 = new Book("Harry Potter", "J.K. Rowling", 500);
        }
        public void Student()
        {
            Student student = new Student("John", 123);
            student.DisplayDetails();
        }
        public void Person()
        {
            Person person1 = new Student2("Alice", 20, "S12345");
            Person person2 = new Teacher("Mr. Smith", 45, "Mathematics");

            Console.WriteLine("---- Student Details ----");
            person1.GetDetails();

            Console.WriteLine("\n---- Teacher Details ----");
            person2.GetDetails();
        }

        public void Calculator()
        {
            Calculator calculator = new Calculator();
            int sum1 = calculator.Add(10, 20);
            int sum2 = calculator.Add(10, 20, 30);
            double sum3 = calculator.Add(10.5, 12.1);

            Console.WriteLine("A + B = " + sum1);
            Console.WriteLine("A + B + C = " + sum2);
            Console.WriteLine("A + B = " + sum3);
        }
        public void Playable()
        {
            MusicPlayer musicPlayer = new MusicPlayer();
            VideoPlayer videoPlayer = new VideoPlayer();
            musicPlayer.Play();
            videoPlayer.Play();
        }
        public void Report()
        {
            Report report = new Report("Report Title", "Report Content");
            report.PrintDetails();
            report.SaveToFile("report.txt");
        }
        public void User()
        {
            Admin admin = new Admin { Username = "admin_user" };
            Customer customer = new Customer { Username = "customer_user" };

            Console.WriteLine($"{admin.Username} ({admin.Role}) - {admin.AccessControl()}");
            Console.WriteLine($"{customer.Username} ({customer.Role}) - {customer.AccessControl()}");
        }
        public void ComplexNumber()
        {
            ComplexNumber c1 = new ComplexNumber(3, 4);
            ComplexNumber c2 = new ComplexNumber(2, 5);

            ComplexNumber result = c1 + c2;

            Console.Write("Sum: ");
            result.Display();
        }
        public void Department()
        {
            Department dept1 = new Department("cse", "Anvesh");
            Console.WriteLine("Original:");
            dept1.Display();

            Department shallowCopy = dept1.ShallowCopy();
            shallowCopy.DeptManager.Name = "jp";
            Console.WriteLine("\nAfter modifying shallow copy:");
            dept1.Display();
            shallowCopy.Display();

            Department deepCopy = dept1.DeepCopy();
            deepCopy.DeptManager.Name = "arun";
            Console.WriteLine("\nAfter modifying deep copy:");
            dept1.Display();
            deepCopy.Display();
        }
        public   void Bank()
        {
            Bank acc1 = new Bank("Anvesh", 1000000);
            Bank acc2 = new Bank("jp", 25000);

            Console.WriteLine("Before % interest rate:");
            acc1.DisplayAccountInfo();
            acc2.DisplayAccountInfo();

           // Bank.SetInterestRate(4);

            Console.WriteLine("\nAfter interest rate:");
            acc1.DisplayAccountInfo();
            acc2.DisplayAccountInfo();
        }
        public void Security()
        {
            SecuritySystem system = new SecuritySystem("1234");

            Console.WriteLine("Enter security code:");
            string inputCode = Console.ReadLine();

            system.Authenticate(inputCode);

        }
        public void Button()
        {
            Button btn = new Button();
            static void ButtonClickResponse()
            {
                Console.WriteLine("Event Triggered: Button was clicked!");
            }

            btn.OnClick += ButtonClickResponse;

            Console.WriteLine("Press any key to simulate button click...");
            Console.ReadKey();

            btn.Click();
        }
        public void VehcileFactory()
        {
            Console.WriteLine("Choose Vehicle Type (Car/Bike):");
            string vehicleType = Console.ReadLine();

            try
            {
                IVehicle vehicle = VehicleFactory.GetVehicle(vehicleType);
                vehicle.Drive();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            //program.BankAccount();
            //program.Vehicle();
            //program.Book();
            //program.Shape();
            //program.Student();
            // program.Person();
            //program.Calculator();
            // program.Playable();
            //program.Report();
            //program.User();
            // program.ComplexNumber();
            // program.Department();
            // program.Bank();
            //program.Security();
            //program.Button();
            //program.VehcileFactory();
        }
    }
}
