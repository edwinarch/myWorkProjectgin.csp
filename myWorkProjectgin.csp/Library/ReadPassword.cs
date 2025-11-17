using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myWorkProjectgin.csp.Library.ReadPassword
{
   public class publicReadPassword
    {
        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo keyInfo;

            while (true)
            {
                keyInfo = Console.ReadKey(intercept: true); // 不显示按键

                if (keyInfo.Key == ConsoleKey.Enter)
                    break;

                if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    if (password.Length > 0)
                        password = password[..^1];
                    continue;
                }

                password += keyInfo.KeyChar;
            }

            Console.WriteLine(); // 换行
            return password;
        }
    }
}
