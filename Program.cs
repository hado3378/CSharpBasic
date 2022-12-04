using CSharpBasic.Browsers;
using CSharpBasic.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpBasic.ExtensionMethods;
using CSharpBasic.Delegates;
using CSharpBasic.Sharp7;


namespace CSharpBasic
{

      public class Program
    {


        public static void Main(string[] args)
        {

            NewFeatures feature = new NewFeatures();

           
            feature.GetStudentInfoWithGrade(feature.student.Where(x => x.Grade =="Third").FirstOrDefault());



            Console.Read();

        }



    }
}



