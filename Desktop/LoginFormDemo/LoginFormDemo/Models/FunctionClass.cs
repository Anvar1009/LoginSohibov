using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginFormDemo.Models
{
    public static class FunctionClass
    {
        public static List<Users> ReadAllLines(List<string> list)
        {
            List<Users> users = new List<Users>();
            foreach (string line in list)
            {
                string[] parts = line.Split(',');
                users.Add(new Users
                {
                    ID=int.Parse(parts[0]),
                    FIO = parts[1],
                    UserName = parts[2],
                    Password = parts[3],
                    role = parts[4]
                });
            }
            return users;
        }
    }
}
