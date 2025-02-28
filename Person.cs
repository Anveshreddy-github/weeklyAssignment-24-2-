using System;

namespace oops_practice_
{
    class Person
    {
        protected string? name;
        protected int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void GetDetails()
        {
            Console.WriteLine("Person Name : " + name);
            Console.WriteLine("Person Age : " + age);
        }
    }

    class Student2 : Person
    {
        private string studentId;

        public Student2(string name, int age, string studentId) : base(name, age)
        {
            this.studentId = studentId;
        }

        public override void GetDetails()
        {
            Console.WriteLine("Student Name : " + name);
            Console.WriteLine("Student Age : " + age);
            Console.WriteLine("Student ID : " + studentId);
        }
    }

    class Teacher : Person
    {
        private string subject;

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            this.subject = subject;
        }

        public override void GetDetails()
        {
            Console.WriteLine("Teacher Name : " + name);
            Console.WriteLine("Teacher Age : " + age);
            Console.WriteLine("Subject : " + subject);
        }
    }
}
