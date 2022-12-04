using CSharpBasic.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Browsers
{
    public class Chrome : IWebDriver
    {
        public void Click()
        {
             Console.WriteLine("Click the element in Chrome");
        }

        public void FindElement()
        {
            Console.WriteLine("Find UI element in Chrome"); ;
        }


        public void SendKeys(string keys)
        {
            Console.WriteLine("Send a text in Chrome" + keys);
        }

        public void SendKeysWithSplChar(string keys, string splChar)
        {
            SendKeys(keys);
            SendKeys(splChar);
        }
    }
}
