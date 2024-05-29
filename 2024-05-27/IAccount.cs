using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_05_27
{
    public interface IAccount
    {
        public bool PasswordChecker(string password);
        public static void ShowInfo(User user) { }
    }
}
