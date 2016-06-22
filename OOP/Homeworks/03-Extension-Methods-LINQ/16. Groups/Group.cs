namespace _16.Groups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Group
    {
        //Create a class Group with properties GroupNumber and DepartmentName.
        //Introduce a property GroupNumber in the Student class.
        //Extract all students from "Mathematics" department.
        //Use the Join operator.*/

        public int GroupNumber { get; set; }
        public string DepartementName { get; set; }

        public Group(int groupNumber, string departementName)
        {
            this.GroupNumber = groupNumber;
            this.DepartementName = departementName;
        }
    }
}
