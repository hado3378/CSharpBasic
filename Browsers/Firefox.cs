using CSharpBasic.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Browsers
{
    class Firefox : IWebDriver
    {
        public void Click()
        {
            Console.WriteLine("Click the element in Firefox");
        }

        public void FindElement()
        {
            Console.WriteLine("Find UI element in Firefox"); ;
        }


        public void SendKeys()
        {
            Console.WriteLine("Send a text in Firefox");
        }

        public void SendKeys(string keys)
        {
            throw new NotImplementedException();
        }
    }
}
