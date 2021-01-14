using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsortedArrayIOBasic
{
    class Utility
    {
        public static int Intinput(string Number)
        {
            bool Num = false;
            int intvalue = 0;
            while (Num == false)
            {
                Num = int.TryParse(Number, out intvalue);

                if (Num)
                {
                    Num = true;
                }
                else
                {
                    Console.WriteLine("Enter Correct Format Input");
                    Number = Console.ReadLine();
                }
            }
            return intvalue;

        }
        public static float Floatinput(string Number)
        {
            bool FNum = false;
            float floatvalue = 0;
            while (FNum == false)
            {
                FNum = float.TryParse(Number, out floatvalue);

                if (FNum)
                {
                    FNum = true;
                }
                else
                {
                    Console.WriteLine("Enter Correct Format Input");
                    Number = Console.ReadLine();
                }
            }
            return floatvalue;

        }
        public static string Stringinput(string Name)
        {

            while (string.IsNullOrEmpty(Name))
            {
                Console.WriteLine("Name can't be empty");
                Name = Console.ReadLine();
            }

            return Name;

        }
    }

}
