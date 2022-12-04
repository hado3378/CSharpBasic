using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Delegates
{

    //Delcaration Delegates

    delegate void Printer(string printvalue);

    public class DelegateTry
    {
       




        public static void PrintValue(string values)
        {
            Console.WriteLine($" The value is : {values}  ");
        }

        public static void PrintValue1(string values)
        {
            Console.WriteLine($" The value is from PrinValue 1 : {values}  ");
        }
    }
}
