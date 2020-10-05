using System;
using System.Diagnostics;

namespace dayCalc
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    class Program
    {
        static void Main(string[] args)
        {
            // a C# program to tell day of the week based on number using functions
           
            Console.Write("Enter day number: ");
            int dayNum =Convert.ToInt32(Console.ReadLine());
            Console.Write(dayName(dayNum));
            
        }

        static string dayName(int dayNum){
            string dName;

            switch(dayNum){
                case 0:
                    dName = "Sunday";
                    break;
                case 1:
                    dName = "Monday";
                    break;
                case 2:
                    dName = "Tuesday";
                    break;
                case 3:
                    dName = "Wednesday";
                    break;
                case 4:
                    dName = "Thursday";
                    break;
                case 5:
                    dName = "Friday";
                    break;
                case 6:
                    dName = "Saturday";
                    break;
                default:
                     dName = "Invalid day number";
                     break;


            }

            return dName;
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
