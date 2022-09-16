using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal class ListData
    {
        public static List<User> getUserData()
        {
            List<User> UserData = new List<User>();

            Console.WriteLine("Enter number of Users you want to add: ");
            int num;
            bool check = int.TryParse(Console.ReadLine(), out num);

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Enter Name for DataEntry{i}");
                string UserName = Console.ReadLine();

                Console.WriteLine($"Enter Id for DataEntry{i}");
                string userID = Console.ReadLine();

                Console.Write("================================\n");

                User u = new User();
                u.UserName = UserName;
                u.UserID = userID;

                UserData.Add(u);
            }
            return UserData;
        }
    }
 
}
