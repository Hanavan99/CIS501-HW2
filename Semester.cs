using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _501_HW2
{

    /// <summary>
    /// A semester has a name, and a list of 0 or more sections.
    /// </summary>
    public class Semester
    {
        private string _name;
        private List<Section> _sections;

        public Semester(string name)
        {
            this._name = name;
            this._sections = new List<Section>();
        }

        public string GetName()
        {
            return this._name;
        }

        public void IncludeSection(Section newSection)
        {
            _sections.Add(newSection);
        }
    }
}
