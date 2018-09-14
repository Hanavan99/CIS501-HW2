using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _501_HW2
{

    /// <summary>
    /// OnCampus extends section, and has one semester, one course, one faculty, a section number, and a capacity. It 
    /// also overrides ToString() for the text representation.
    /// </summary>
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

        public override string ToString()
        {
            return String.Format("{0} section {1} ({2}) is being taught by {3} in {4}", _course.number, number, _course.title, _faculty.GetName(), _semester.GetName());
        }
    }
}
