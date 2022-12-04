using CSharpBasic.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Browsers
{
    class IE : IWebDriver
    {
        public void Click()
        {
            Console.WriteLine("Click the element in IE");
        }

        public void FindElement()
        {
            Console.WriteLine("Find UI element in IE"); ;
        }


        public void SendKeys()
        {
            Console.WriteLine("Send a text in IE");
        }

        public void SendKeys(string keys)
        {
            throw new NotImplementedException();
        }
    }
}
