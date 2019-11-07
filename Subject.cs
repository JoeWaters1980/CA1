using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
   public class Subject
    {
        // constructor
        public string Name { get; set; }
        public string Lecturer { get; set; }
        public int Year { get; set; }

        public Subject(string name, string leturer, int year)
        {

            name = this.Name;
            leturer = this.Lecturer;
            year = this.Year;
        }

    

        // methods

        public override string ToString()
        {
            
            return string.Format($"Subject name :{Name}\t Lecturer Name : {Lecturer}\t Year :{Year}");

        }

       
    }
}

