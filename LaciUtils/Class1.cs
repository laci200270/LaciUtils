using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaciUtils
{
    public class ConsoleUtils
    {
        private static int readNumber()
        {
            bool canRun = true;
            int returnable = 0;
            while (canRun)
            {
                String str = Console.ReadLine();
                if (!isNumber(str))
                {
                    Console.WriteLine("Számot írjál be kérlek!");
                }
                else
                {
                    returnable = Int16.Parse(str);
                    canRun = false;
                }
            }
            return returnable;
        }
        private static int readNumber(String message)
        {
            Console.Write(message + ": ");
            return readNumber();

        }
        private static bool isNumber(String str)
        {
            try
            {
                Int16.Parse(str);
                return true;
            }
            catch 
            {
                return false;
            }
        }
        

    }
}
