using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;


namespace JSONObjectQuickSort
{   
    //To act similarily to the prior to the other file readers in the larger solution refactored to read
    //json elements of a particular made class in this case its an "employee database" 
    public class JsonFileReader
    {
        public string path;

        public string FiletoCall;
        public string NewFileName;

        public string jsontext;
        public string tojson;

        public List<Employee> NewCollection;
        public JsonFileReader()
        {
            this.path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            
            this.FiletoCall = "test";
            this.NewFileName = "NewFile";

            this.NewCollection = new List<Employee>();
        }
        public void ToDeserialize()
        {
            //Collects the information of the json file for later serialization
             jsontext = File.ReadAllText($"{path}\\..\\..\\..\\jsonfiles\\{FiletoCall}.json");
            try
            {
                NewCollection = ClassObject();
            }
            catch
            {
                System.Console.WriteLine("failed to extract the json file in question");
            }
        }
        public void ToSerailize(List<Employee> employees)
        {
            //To ensure that everything is fresh
            File.Delete($"{path}\\..\\..\\..\\jsonfiles\\{NewFileName}.json");
            //Gets the updated list of json objects
            var tojson = JsonConvert.SerializeObject(employees);
            //Writes to a new file named NewFile.json in the jsonfiles folder
            File.AppendAllText($"{path}\\..\\..\\..\\jsonfiles\\{NewFileName}.json",tojson);
        }
        //Makes sure that a list gets created and separate the processes clearly
        public List<Employee> ClassObject()
        {
            var employees = JsonConvert.DeserializeObject<List<Employee>>(jsontext);
            return employees;
        }
    }
}
