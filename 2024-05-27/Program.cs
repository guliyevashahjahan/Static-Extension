namespace _2024_05_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Full name: ");
            string fullName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            User user = new User(fullName, email, password);

            Console.Clear();
            Console.WriteLine("1.Show Info \n2.Create a new group");
           
            if(Console.ReadKey(true).Key == ConsoleKey.D1)
            {
                Console.Clear();
                IAccount.ShowInfo(user);
            }
            else if(Console.ReadKey(true).Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.Write("Group number: ");
                string groupNo = Console.ReadLine();
                Console.Write("Student limit (between 5-18): ");
                byte studentLimit =byte.Parse(Console.ReadLine());

                Group group = new Group(groupNo, studentLimit);
                Console.WriteLine("1.Show all students \n2.Get a student by ID: \n3.Add a new student \n0.Quit");
                if (Console.ReadKey(true).Key == ConsoleKey.D1)
                {
                    group.GetAllStudents();
                }
                else if (Console.ReadKey(true).Key == ConsoleKey.D2)
                {
                    Console.Write("ID: ");
                    int id = int.Parse(Console.ReadLine());
                    group.GetStudent(id);
                }
                else if (Console.ReadKey(true).Key == ConsoleKey.D3)
                {
                    Console.Write("Full name: ");
                    string fullname = Console.ReadLine();
                    Console.Write("Point: ");
                    double point = double.Parse(Console.ReadLine());
                    Student student = new Student(fullname, point);
                    group.AddStudent(student);
                }
                else if (Console.ReadKey(true).Key == ConsoleKey.D0)
                {
                    Environment.Exit(0);
                }

            }


        }
    }
}
