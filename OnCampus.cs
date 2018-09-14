using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _501_HW2
{
    public class OnCampus : Section
    {
        public OnCampus(Semester semester, Course course, Faculty teacher, string number, int cap)
        {
            this._semester = semester;
            this._course = course;
            this._faculty = teacher;
            this.number = number;
            this.cap = cap;
        }

        public string ToString()
        {
            return ""; // pull in how it is done in Oneline.cs
        }
    }
}
