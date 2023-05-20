using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_vjezbe_sve.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
    public class Teacher : Person
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool CheckPassword(string password)
        {
            return Password == password;
        }

    }
    public class Student : Person
    {
        public int Grade { get; set; }
    }

}
