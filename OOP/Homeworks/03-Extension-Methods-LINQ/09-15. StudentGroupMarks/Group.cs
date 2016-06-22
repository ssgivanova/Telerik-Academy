namespace _09_15.StudentGroupMarks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

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
