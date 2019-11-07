using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Subject> subject = new List<Subject>();

            Subject subject1 = new Subject("Vivan","programming", 1);
            Subject subject2 = new Subject("adrian", "ux", 1);
            Subject subject3 = new Subject("keith", "oop", 1);
            Subject subject4 = new Subject("padraig", "database", 1);

            subject.Add(subject1);
            subject.Add(subject2);
            subject.Add(subject3);
            subject.Add(subject4);

            Student student1 = new Student("joe", "09/05/1980");
            Student student2 = new Student("mary", "08/06/1979");

            Console.WriteLine(student1.ToString()) ;
            Display(subject);
            Console.WriteLine(student2.ToString());
            Console.ReadLine();
        }

        static void Display(List<Subject> subjects)
        {
            foreach(Subject subject in subjects)
                Console.WriteLine(subjects.ToString());
        }



    }
}
