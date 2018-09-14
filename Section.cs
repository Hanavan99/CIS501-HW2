using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _501_HW2
{
    public abstract class Section
    {
        protected Course _course;
        protected Semester _semester;
        private IFaculty _faculty;

        public string number;
        public int cap;

        public void SetNumber(string number);
        public string GetNumber();

        public void SetCap(int cap);
        public int GetCap();
    }
}
