using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _501_HW2
{

    /// <summary>
    /// Section is an abstract class that has a course, a semester, a faculty member implementing IFaculty,
    /// a section number, and a capacity.
    /// </summary>
    public abstract class Section
    {

        protected Course _course;
        protected Semester _semester;
        protected IFaculty _faculty;

        public string number;
        public int cap;

        public void SetNumber(string number)
        {
            this.number = number;
        }
        public string GetNumber()
        {
            return number;
        }

        public void SetCap(int cap)
        {
            this.cap = cap;
        }

        public int GetCap()
        {
            return cap;
        }
    }
}
