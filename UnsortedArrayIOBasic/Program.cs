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
        static int Count = 0;
       
        static void Main(string[] args)
        {

            int[] Demoarray = new int[] { 20,30,40,60,80};
            //// #02
            //int [] Getelementsvalus=GetElement(Convert.ToInt32(userinput("ArraySize")));
            //// #03
            //int[] GetelementRangevalues = GetElementWithrange(Convert.ToInt32(userinput("ArraySize")), Convert.ToInt32(userinput("Random Min")), Convert.ToInt32(userinput("Random Max")));
            ////#04
            //int[] getarrayvaluesandelementvalues = getarraysizeandarrayvalues(Convert.ToInt32(userinput("Array min")), Convert.ToInt32(userinput("array max")), Convert.ToInt32(userinput("Random min")), Convert.ToInt32(userinput("Random Max")));
            //// #05
            //PrintArrays(Convert.ToInt32(userinput("Array Size")));
            //#6
            //Printarrayreturn(Convert.ToInt32(userinput("Array Size")));
            //// #07
            //printOddloaction(Convert.ToInt32(userinput("Array Size")));
            ////#08
            //printevenloaction(Convert.ToInt32(userinput("Array Size")));
            ////#09
            //PrintuptoKth(Convert.ToInt32(userinput("Arraysize")), Convert.ToInt32(userinput("Kth Number")));
            ////#10
            //PrintBeforekth(Convert.ToInt32(userinput("Arraysize")), Convert.ToInt32(userinput("Kth Number")));

            ////#11
            //Printformat(Convert.ToInt32(userinput("Arraysize")));

            ////#12
            //indexsubtracetElement(Convert.ToInt32(userinput("Arraysize")));
            ////#13
            //sumofelements(Convert.ToInt32(userinput("Arraysize")));
            ////#14
            //printOddloactionsum(Convert.ToInt32(userinput("Arraysize")));
            ////#15
            //printevenloactionsum(Convert.ToInt32(userinput("Arraysize")));
            ////#16
            //meanofarrayvalues(Convert.ToInt32(userinput("Arraysize")));
            ////#17
            //Nonzeroelementcount(Demoarray);
            ////#18
            //Positivelementcount(Demoarray);
            ////#19
            //negativelementcount(Demoarray);
            ////#20
            //equalnegativeandpositivecount(Demoarray);
            ////#20
            //Meanvaluewithoutzero(Demoarray);
            ////#21

            // Subtractmeanvalueofelements(Convert.ToInt32(userinput("Arraysize")));

            ////#22
            //returnaddoreven(Convert.ToInt32(userinput("Arraysize")), Convert.ToBoolean(userinput("Odd number enter -true")), Convert.ToBoolean(userinput("even number enter -true")));

            ////#23
            //perfectsquare(Convert.ToInt32(userinput("Arraysize")));

            ////#24
            //Perfectsquarescount(Convert.ToInt32(userinput("Arraysize")));

            //#25
            //Primenumbers(Convert.ToInt32(userinput("Arraysize")));

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

        public static int printOddloaction(int arraysize)
        {
            Count = 0;
            int[] returnarray = Arrayfill(0, arraysize);
            for (int i =1; i<returnarray.Length; i+=2)
            {
                Count += 1;
                Console.WriteLine("ArrayElement " + i + " : " +  returnarray[i] + "");
              
            }
            return Count;
            Console.ReadLine();
        }
        public static int printevenloaction(int arraysize)
        {
            Count = 0;
            int[] returnarray = Arrayfill(0, arraysize);
            for (int i = 0; i < returnarray.Length; i += 2)
            {
                Count += 1;
                Console.WriteLine("ArrayElement " + i + " : " + returnarray[i] + "");

            }
            Console.ReadLine();
            return Count;
        }

        public static void PrintuptoKth(int arraysize,int Kthnumber)
        {
            int[] returnarray = Arrayfill(0, arraysize);
            for (int i = 0; i < Kthnumber; i++)
            {

                Console.WriteLine("ArrayElement " + i + " : " + returnarray[i] + "");

            }
            Console.ReadLine();
        }

        public static void PrintBeforekth(int arraysize, int Kthnumber)
        {
            int[] returnarray = Arrayfill(0, arraysize);
            for (int i = Kthnumber; i < returnarray.Length; i++)
            {

                Console.WriteLine("ArrayElement " + i + " : " + returnarray[i] + "");

            }
            Console.ReadLine();
        }

        public static void Printformat(int arraysize)
        {
            int[] returnarray = Arrayfill(0, arraysize);
            for (int i = 0; i < returnarray.Length; i++)
            {
                if (i==returnarray.Count()-1)
                {
                    Console.Write("{" + i + " : " + returnarray[i] + "}");
                }
                else
                {
                    Console.Write("{" + i + " : " + returnarray[i] + "},");
                }
      
            }
            Console.ReadLine();
        }

        public static void indexsubtracetElement(int arraysize)
        {
            int[] returnarray = Arrayfill(0, arraysize);
            for (int i = 1; i < returnarray.Length; i++)
            {
                returnarray[i]=returnarray[0] - returnarray[i];
                Console.WriteLine("ArrayElement " + i + " : " + returnarray[i] + "");

            }
            Console.ReadLine();
        }

        public static void sumofelements(int arraysize)
        {
            int[] returnarray = Arrayfill(0, arraysize);
            for (int i = 1; i < returnarray.Length; i++)
            {
                returnarray[0] +=returnarray[i];
               

            }
            Console.WriteLine("ArrayElementTotal  : " + returnarray[0] + "");
            Console.ReadLine();
        }
        public static void printOddloactionsum(int arraysize)
        {
            int[] returnarray = Arrayfill(0, arraysize);
            for (int i = 3; i < returnarray.Length; i += 2)
            {

                returnarray[1] += returnarray[i];

            }
            Console.WriteLine("ArrayElement Odd total : " + returnarray[1] + "");
            Console.ReadLine();
        }
        public static void printevenloactionsum(int arraysize)
        {
            int[] returnarray = Arrayfill(0, arraysize);
            for (int i = 2; i < returnarray.Length; i += 2)
            {

                returnarray[0] += returnarray[i];

            }

            Console.WriteLine("ArrayElement Eventotal : " + returnarray[0] + "");
            Console.ReadLine();
        }

        public static void meanofarrayvalues(int arraysize)
        {
            int[] returnarray = Arrayfill(0, arraysize);
            for (int i = 1; i < returnarray.Length; i++)
            {
                returnarray[0] += returnarray[i];


            }
            Console.WriteLine("ArrayElementTotal  : " + returnarray[0]/returnarray.Count() + "");
            Console.ReadLine();
        }

        public static int Nonzeroelementcount(int[] array)
        {
            Count = 0;
         
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    Count += 1;
                    Console.WriteLine("ArrayElement " + i + " : " + array[i] + "");
                }
            }
            Console.WriteLine("Non-Zero count " +Count+"");
            Console.ReadLine();

            return Count;
        }
        public static int Positivelementcount(int[] array)
        {
            Count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    Count += 1;
                    Console.WriteLine("ArrayElement " + i + " : " + array[i] + "");
                }
            }
            Console.WriteLine("Positive count " + Count + "");
            Console.ReadLine();

            return Count;
        }
        public static int negativelementcount(int[] array)
        {
            Count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    Count += 1;
                    Console.WriteLine("ArrayElement " + i + " : " + array[i] + "");
                }
            }
            Console.WriteLine("Negative count " + Count + "");
            Console.ReadLine();

            return Count;
        }

        public static void equalnegativeandpositivecount(int[] array)
        {
            if (Positivelementcount(array) == negativelementcount(array))
            {
                Console.WriteLine("Positive == Negative");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            Console.ReadLine();
        }

        public static void Meanvaluewithoutzero(int[] array)
        {
            Count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    Count += array[i];
                }
            }
            Count = Count / array.Count();
            Console.WriteLine("ArrayElementMeanvalue  : " + Count + "");
            Console.ReadLine();
           
        }


        public static void Subtractmeanvalueofelements(int arraysize)
        {
                
            int[] returnarray = Arrayfill(0, arraysize);
            Meanvaluewithoutzero(returnarray);
            for (int i = 0; i < returnarray.Length; i++)
            {
                Console.WriteLine("ArrayElementActual"+i+"  : " + returnarray[i] + "");
                returnarray[i]=Count- returnarray[i];

                Console.WriteLine("ArrayElementAfter "+i+" : " + returnarray[i]+ "");
            }
           
            Console.ReadLine();
        }

        public static void returnaddoreven(int arraysize,bool odd=false,bool even=false)
        {
           
            if (odd)
            {
               Console.WriteLine( "Oddnumber in the array :" +printOddloaction(arraysize));
            }
            else
            {
                Console.WriteLine("Oddnumber in the array :" +printevenloaction(arraysize));
            }
            Console.ReadLine();
        }

        public static int perfectsquare(int arraysize)
        {
            Count = 0;
            int[] returnarray = Arrayfill(0, arraysize);
            for (int i = 0; i < returnarray.Length; i++)
            {
                
              double a= Math.Sqrt(returnarray[i]);
               if( a - Math.Floor(a) == 0)
                {
                    Count += 1;
                    Console.WriteLine("ArrayElement " + i + " : " + returnarray[i] + "");
                }
               

            }
            Console.ReadLine();

            return Count;
        }
        public static void Perfectsquarescount(int arraysize)
        {
           Console.WriteLine("Number of perfect squares :"+ perfectsquare(arraysize));
            Console.ReadLine();
        }

        //public static int Primenumbers(int number)
        //{
          
            
        //}
    }
}
