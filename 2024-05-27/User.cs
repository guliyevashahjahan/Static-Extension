using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_05_27
{
    public class User : IAccount
    {
        private static int Count = 0;
        public User(string email, string password)
        {
            Count++;
            Id = Count;
            Email = email;
            if (this.PasswordChecker(password))
            {
                Password = password;
            }
        }
        public User(string email, string password, string fullName) : this(email, password) 
        {
            FullName = fullName;
        }
        public int Id { get; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public bool PasswordChecker(string password)
        {
            bool flag = false;
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;
            if (password.Length < 8)
            {
                return flag;
            }
            else
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsUpper(password[i]))
                    {
                        hasUpper = true;
                    }
                    if (char.IsLower(password[i]))
                    {
                        hasLower = true;
                    }
                    if (char.IsDigit(password[i]))
                    {
                        hasDigit = true;
                    }
                }
            }
            if (hasUpper && hasDigit && hasLower) 
            { 
                flag = true;
            }
            return flag;
        }

        public void ShowInfo(User user)
        {
            Console.WriteLine($"Id: {user.Id}\n Full Name: {user.FullName} \n Email: {user.FullName}");
        }
    }
}
