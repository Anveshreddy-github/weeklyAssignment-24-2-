using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment
{
    class Student
    {
        private string name;
        private int RollNo;
        private string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Name cannot be empty");
                name = value;
            }
        }

        private int rollno
        {
            get { return RollNo; }
            set
            {
                if (value <= 0)
                    throw new Exception("Roll Number cannot be less than or equal to 0");
                RollNo = value;
            }
        }

        public Student(string name, int RollNo)
        {
            this.name = name;
            this.RollNo = RollNo;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Roll Number : " + RollNo);
        }
    }
}
