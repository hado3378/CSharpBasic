using CSharpBasic.Selenium;
using CSharpBasic.Browsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.ExtensionMethods
{
    public static class WebDriverExtension
    {

        public static void SendKeysWithSplChar(this Chrome driver, string keys, string splChar)
        {
           
            driver.SendKeys(keys);
            driver.SendKeys(splChar);
            

        }
    }
}
