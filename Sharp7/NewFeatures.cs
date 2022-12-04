using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Sharp7
{
    public class NewFeatures
    {
        //create field student

        public List<Students> student = null;

       public NewFeatures()
        {
            var student = new List<Students> 
            {
                new Students()
                {
                    Name = " HA DO",
                    Age = 30,
                    Gender = "Male",
                    Grade = "First"
                },
                new Students()
                {
                    Name = " Tom DO",
                    Age = 20,
                    Gender = "Male",
                    Grade = "Second"
                },

                new Students()
                {
                    Name = " Katherine DO",
                    Age = 10,
                    Gender = "Female",
                    Grade = "Third"
                }

            };

            this.student = student;
        }

        public void GetStudentInfoWithGrade(Students student)
        {

            
            switch(student)
            {
                case Students s when (s.Grade == "First"):

                    Console.WriteLine($"Student with name {s.Name} is with Age {s.Age}");

                    break;

                case Students s when (s.Grade == "Second"):

                    Console.WriteLine($"Student with name {s.Name} is with Age {s.Age}");

                    break;


                case Students s when (s.Grade == "Third"):

                    Console.WriteLine($"Student with name {s.Name} is with Age {s.Age}");

                    break;



                default:
                    break;


            }




        }
    }


    public class Students
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Grade { get; set; }

        public string Gender { get; set; }

    }
}
