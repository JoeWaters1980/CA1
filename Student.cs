using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    public class Student : IComparable
    {
        string Name { get; set; }
        string DateOfBirth { get; set; }
        // List< Subject[Subject]>
            
            


        public Student(string name, string dateOfBirth)
        {
            this.Name= name;
             this.DateOfBirth= dateOfBirth;
        }
        public override string ToString()
        {
            return string.Format($"stundent name : {Name}\t student dob : {DateOfBirth}");

        }

        public int CompareTo(object obj)
        {
            Student that = (Student)obj;
            return this.DateOfBirth.CompareTo(that.DateOfBirth);
        }
    }
}
