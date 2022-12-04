using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    public class CollectionExamples
    {


        public static void Main(string[] args)
        {



            GenericCollectionsWithCustomClass();

            Console.Read();
        }

        public static void NonGenericCollecion()
        {
            Hashtable table = new Hashtable();
            table.Add("UserName", "ea");
            table.Add("Password", "ea123");
            table.Add("Button", "Submit");

            foreach (var key in table.Keys)
            {
                Console.WriteLine("The value for " + key + " is: " + table[key]);
            }
        }

        public static void GenericCollecion()
        {
            string[] user1 = new string[] { "Katherine", "8", "kat@yahoo.com" };
            string[] user2 = new string[] { "Tom", "13", "kat@yahoo.com" };
            string[] user3 = new string[] { "Ha", "40", "ha@yahoo.com" };
            string[] user4 = new string[] { "Minh", "30", "minh@yahoo.com" };

            Dictionary<int, string[]> dict = new Dictionary<int, string[]>();
            dict.Add(1, user1);
            dict.Add(2, user2);
            dict.Add(3, user3);
            dict.Add(4, user4);

            foreach (var value in dict)
            {

                string[] userinfo = value.Value;

                foreach (var user in userinfo)
                {
                    Console.Write(user + " ");
                }

                Console.WriteLine();
            }
        }

        public static void GenericCollectionsWithCustomClass()
        {
            List<User> users = new List<User>();
            users.Add(new User { UserId = 1, Name = " Katherine", Age = 7, Phone = 11111111 });
            users.Add(new User { UserId = 2, Name = " Tommy", Age = 13, Phone = 222222222 });
            users.Add(new User { UserId = 3, Name = " Ha", Age = 40, Phone = 333333333 });
            users.Add(new User { UserId = 4, Name = " Minh", Age = 40, Phone = 444444444 });

            /* foreach (var user in users)
             {
                 Console.WriteLine(String.Format("The user {0} with Age {1} has Email {2} and Phone {3}", user.Name, user.Age, user.Email, user.Phone));
             }*/

            var userlist = from user in users
                           where user.Age == 40
                           select new { FirstName = user.Name, Age = user.Age, Phone = user.Phone };

            foreach(var user in userlist)
            {
                Console.WriteLine("User{0} has phone number {1} and age of {2} ", user.FirstName, user.Phone, user.Age);
            }
        }


    }


    public class User
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public Int64 Phone { get; set; }
    }

}



