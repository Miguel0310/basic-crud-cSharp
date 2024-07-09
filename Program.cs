using SimpleCRUDApp;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var memberManager = new MemberManager();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Create Member");
                Console.WriteLine("2. Read Members");
                Console.WriteLine("3. Update Member");
                Console.WriteLine("4. Delete Member");
                Console.WriteLine("5. Exit");
                Console.WriteLine("6. Search Member");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Name: ");
                        var name = Console.ReadLine();
                        Console.Write("Enter Email: ");
                        var email = Console.ReadLine();
                        Console.Write("Enter Phone: ");
                        var phone = Console.ReadLine();
                        memberManager.CreateMember(name, email, phone);
                        break;
                    case "2":
                        memberManager.ReadMembers();
                        break;
                    case "3":
                        Console.Write("Enter Email of the member to update: ");
                        var oldEmail = Console.ReadLine();
                        Console.Write("Enter new Name: ");
                        var newName = Console.ReadLine();
                        Console.Write("Enter new Email: ");
                        var newEmail = Console.ReadLine();
                        Console.Write("Enter new Phone: ");
                        var newPhone = Console.ReadLine();
                        memberManager.UpdateMember(oldEmail, newName, newEmail, newPhone);
                        break;
                    case "4":
                        Console.Write("Enter Email of the member to delete: ");
                        var deleteEmail = Console.ReadLine();
                        memberManager.DeleteMember(deleteEmail);
                        break;
                    case "5":
                        return;
                    case "6":
                        Console.Write("Insert a search: ");
                        var searchMember = Console.ReadLine();
                        memberManager.searchMember(searchMember);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}