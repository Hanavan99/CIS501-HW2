using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _501_HW2
{

    /// <summary>
    /// A course has a title, number and a list containing 0 or more sections.
    /// </summary>
    public class Course
    {
        public string title;
        public int number;
        private List<Section> _sections;
    }
}
