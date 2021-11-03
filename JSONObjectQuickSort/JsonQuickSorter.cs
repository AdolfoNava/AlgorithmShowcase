using System;
using System.Collections.Generic;
using System.Text;

namespace JSONObjectQuickSort
{
    //Here is all work in the project is called and acted for in this console app
    //This is refactored from my quicksortconsoleapp project in the solution to deal with list of class objects
    public class JsonQuickSorter
    {
        JsonFileReader fileReader;
        public JsonQuickSorter()
        {
            this.fileReader = new JsonFileReader();
            
            fileReader.ToDeserialize();

            SortJsonCollection(fileReader.NewCollection);
            //Displays the output of the sorting method that I made
            foreach(Employee person in fileReader.NewCollection)
            {
                Console.WriteLine(@$"First Name: {person.firstName}
Last Name: {person.lastName}
Gender: {person.gender}
Salary: ${person.salary}
id number: {person.id}
");

            }
            //Makes sure that a new file is created to view outside the debugger console app
            fileReader.ToSerailize(fileReader.NewCollection);

        }
        private void SortJsonCollection(List<Employee> list)
        {
            Quicksort(list, 0, list.Count - 1);
        }
        //The sorting is by their id int values in lowest to high 1,2,3,etc.
        private static void Quicksort(List<Employee> list, int left, int right)
        {
            //The left and right are the bounds of the function and to re iterate the values
            var i = left;
            var j = right;
            //The main
            var pivot = list[(left + right) / 2].salary;

            while (i <= j)
            {
                //These are the bounds of the method call and will determine the exact array slot for the transfer to commence
                while (list[i].salary < pivot)
                {
                    i++;
                }
                while (list[j].salary > pivot)
                {
                    j--;
                }
                if (i <= j)
                {//Begins the transfer of the values around 
                    var tempSpot = list[i];
                    list[i] = list[j];
                    list[j] = tempSpot;
                    i++;
                    j--;
                }
            }
            //This is to continue the function until there is no more values that are not unsorted in ascending order
            if (left < j)
            {
                Quicksort(list, left, j);
            }
            if (i < right)
            {
                Quicksort(list, i, right);
            }
            
        }
    }
}
