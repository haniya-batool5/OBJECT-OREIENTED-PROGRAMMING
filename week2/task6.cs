using System;
using System.IO;

namespace week2
{
    public class MUser
    {
        // Attributes
        public string Username;
        public string Password;
        public string Role;

        // Constructor
        public MUser(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }

        // Sign Up
        public static void SignUp()
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            Console.Write("Enter Role: ");
            string role = Console.ReadLine();

            // Reference variable
            MUser user = new MUser(username, password, role);

            StreamWriter file = new StreamWriter("users.txt", true);

            file.WriteLine(user.Username + "," +
                           user.Password + "," +
                           user.Role);

            file.Close();

            Console.WriteLine("Sign Up successful.");
        }

        // Sign In
        public static void SignIn()
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (!File.Exists("users.txt"))
            {
                Console.WriteLine("No user file found.");
                return;
            }

            StreamReader file = new StreamReader("users.txt");

            string line;
            bool found = false;

            while ((line = file.ReadLine()) != null)
            {
                string[] data = line.Split(',');

                // Reference variable
                MUser user = new MUser(
                    data[0],
                    data[1],
                    data[2]
                );

                if (user.Username == username &&
                    user.Password == password)
                {
                    Console.WriteLine("Sign In successful.");
                    Console.WriteLine("Welcome " + user.Username);
                    Console.WriteLine("Role: " + user.Role);

                    found = true;
                    break;
                }
            }

            file.Close();

            if (found == false)
            {
                Console.WriteLine("Invalid Username or Password.");
            }
        }

        // Menu
        public static int Menu()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("     USER MANAGEMENT");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Sign Up");
            Console.WriteLine("2. Sign In");
            Console.WriteLine("3. Exit");

            Console.Write("Enter choice: ");

            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                int choice = Menu();

                if (choice == 1)
                {
                    SignUp();
                }
                else if (choice == 2)
                {
                    SignIn();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Program ended.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
