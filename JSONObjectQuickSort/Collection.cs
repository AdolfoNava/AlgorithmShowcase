using System;
using System.Collections.Generic;
using System.Text;

namespace JSONObjectQuickSort
{
    //Made this as a enum as it would be in a checkbox in a real app
    public enum gender { Male,Female,PreferNotStated}
    //The complete object that mimics an employee database for json serialization
    [Serializable]
    public class Employee
    {
        //the names of the variables is to mimic the json that im calling to the read and write
        public string firstName { get; set; }
        public string lastName { get; set; }
        public gender gender { get; set; }
        public int salary { get; set; }
        public int id { get; set; }
    }
}
