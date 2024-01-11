using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace class_tasks
{
    internal class Student
    {
       
        public Student(string fullname  , byte point )
        {
            this.Fullname = fullname ;
            this.Point = point ;
        }

        public string Fullname;
        public DateTime BirthDate;
        public int GroupNo;
        public byte Point; 
        
        public void ShowInfo()
        {
            Console.WriteLine($"Fullname: {this.Fullname},GroupNO:{this.GroupNo},Point:{this.Point},BirthDate:{this.BirthDate.ToString("dd.MM.yyyy")}");
        }
    }
}
