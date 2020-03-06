using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp___CLASSES___Student__Hobby__Sport
{
    class Student
    {
        public static int numOfStudents = 0;
        public static List<string> studentList = new List<string>();

        public string Name { get; set; }
        public int Grade { get; set; }
        public int Age { get; set; }

        public Student(string name, int grade, int age)
        {
            numOfStudents += 1;
            Name = name;
            if(grade >= 9 && grade <=12)
            {
                Grade = grade;
            }
            else
            {
                Grade = 9;
            }
            Age = age;

            studentList.Add(name);
        }

        public static bool Contains(string name)
        {
            if (studentList.Contains(name))
            {
                return true;
            }
            return false;
        }

    }
}
