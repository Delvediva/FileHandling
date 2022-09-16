using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;  
using System.Threading.Tasks;
using System.Configuration;

namespace Application
{
    public class Add
    {
        public static void Execute()
        {
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string path = desktopPath + @"\file.txt";

                List<User> UserData = ListData.getUserData();

                
                string[] previousData;

                try
                {
                    
                    File.ReadAllText(path);

                }
                catch (Exception e)
                {
                    File.WriteAllText(path,"");

                }
                finally
                {

                }

                string[] UserName = UserData.Select(i => i.UserName.ToString()).ToArray();
                string[] UserID = UserData.Select(i => i.UserID.ToString()).ToArray();
                string[] str = new string[1] { " " };

                previousData = File.ReadAllLines(path);
                bool flag = false;

                for (int i=0;i<UserData.Count;i++)
                {
                    File.AppendAllText(path, UserName[i]);
                    File.AppendAllText(path," ");
                    File.AppendAllText(path, UserID[i]);
                    flag = true;

                    if(previousData.Length > 0||flag==true)
                    {
                        File.AppendAllLines(path, str);
                    }
                }

                previousData = File.ReadAllLines(path);

                Console.WriteLine("List of all users:");
                foreach (string key in previousData)
                {
                    Console.WriteLine($"{key}");
                }
                Console.ReadLine();

            }
        }
    }
}
