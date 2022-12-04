using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class TestClass1
    {
        private int num = 0;

        public void SetValue(int number)
        {
            num = number;
        }

        public int GetValue()
        {
            return num;
        }


        public void TestCase1(string result)
        {
            Console.WriteLine("Executing TestCase 1 " + result);
        }

        public void TestCase2(string result )
        {
            Console.WriteLine("Executing TestCase 2 " + result);
        }


    }
}
