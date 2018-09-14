using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _501_HW2
{
    public class Faculty : IFaculty
    {

        private string name;
        private List<Section> _sections;

        public Faculty(string name)
        {
            this.name = name;
        }

        public void AssignSection(Section assignedSection)
        {
            _sections.Add(assignedSection);
        }

        public string GetName()
        {
            return name;
        }
    }
}
