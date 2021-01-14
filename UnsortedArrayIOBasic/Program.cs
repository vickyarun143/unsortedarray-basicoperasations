using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsortedArrayIOBasic
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            //// #2
            //int [] Getelementsvalus=GetElement(Convert.ToInt32(userinput("ArraySize")));
            //// #3
            //int[] GetelementRangevalues = GetElementWithrange(Convert.ToInt32(userinput("ArraySize")), Convert.ToInt32(userinput("Random Min")), Convert.ToInt32(userinput("Random Max")));
            ////#4
            //int[] getarrayvaluesandelementvalues = getarraysizeandarrayvalues(Convert.ToInt32(userinput("Array min")), Convert.ToInt32(userinput("array max")), Convert.ToInt32(userinput("Random min")), Convert.ToInt32(userinput("Random Max")));
            //// #5
            //PrintArrays(Convert.ToInt32(userinput("Array Size")));
            //#6
            //Printarrayreturn(Convert.ToInt32(userinput("Array Size")));
            // #7
            printOddloaction(Convert.ToInt32(userinput("Array Size")));

        }
        //----------------------------------------------------------------
        public static string userinput(string Valuetype)
        {
            Console.WriteLine("Enter The InputValue "+Valuetype+" :");
            string s=Console.ReadLine();
            return s;
        }
        public static int[] Arrayfill(int startingpoint,int arraysize,int randstart=0,int randend=100)
        {
            int[] GetRangevalues = new int[arraysize];
            for (startingpoint = 0; startingpoint < GetRangevalues.Length; startingpoint++)
            {
                GetRangevalues[startingpoint] = rand.Next(randstart, randend);
            }
            return GetRangevalues;
        } 
       

        //---------------------------------------------------------




//QUES-2  Get the Array Elements from the user return array
        public static int[] GetElement(int arraysize)
        {
            int[] Getelements = new int[arraysize];
            for (int i = 0; i < Getelements.Length; i++)
            {
                Getelements[i]=Utility.Intinput(userinput("ArrayElement"+i+""));
            }
            return Getelements;
        }
        public static  int[] GetElementWithrange(int arraysize,int start,int End)
        {
            return Arrayfill(0, arraysize, start, End);
        }

        public static int[] getarraysizeandarrayvalues(int x,int y,int start,int end)
        {
            int arraysize = rand.Next(x, y);
            return Arrayfill(0, arraysize, start, end);
        }

        public  static void PrintArrays(int arraysize)
        {
          
            foreach(int values in Arrayfill(0, arraysize))
            {
                Console.WriteLine("ArrayElement  : "+values+"");
            
            }
            Console.ReadLine();
        }

        public static void Printarrayreturn(int arraysize)
        {
            int[] returnarray = Arrayfill(0, arraysize);
            for (int i = returnarray.Length-1;i<returnarray.Length  ; i--)
            {
                if (i < 0)
                {
                    break;
                }
                Console.WriteLine("ArrayElement "+i+" : " + returnarray[i] + "");
              
            }
            Console.ReadLine();
        }

        public static void printOddloaction(int arraysize)
        {
            int[] returnarray = Arrayfill(0, arraysize);
            for (int i =1; i<returnarray.Length; i+=2)
            {
              
                Console.WriteLine("ArrayElement " + i + " : " + returnarray[i] + "");

            }
            Console.ReadLine();
        }
    }
}
