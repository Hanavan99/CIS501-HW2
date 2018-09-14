using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _501_HW2
{

    /// <summary>
    /// IFaculty is an interface with two methods for getting the name and adding a section.
    /// </summary>
    public interface IFaculty
    {

        string GetName();

        void AssignSection(Section assignedSection);

    }
}
