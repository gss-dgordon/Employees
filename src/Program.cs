using src.Employee;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            // Create Chris
            employees.Add(new Employee("Chris Allers", 47899, "Accounting", "Vice President"));
            // Create Cranky Dave
            employees.Add(new Employee("\"Cranky Dave\" Brinkley", 39119, "IT", "Developer"));
            // Create Maxine
            employees.Add(new Employee("Maxine Andrews", 81774, "Manufacturing", "Engineer"));

            // get max field size
            int maxName = "Name".Length;
            int maxID = "ID Number".Length;
            int maxDept = "Department".Length;
            int maxPos = "Position".Length;

            foreach (var employee in employees)
            {
                maxName = Math.Max(maxName, employee.Name.Length);
                maxID = Math.Max(maxID, employee.IDNumber.ToString().Length);
                maxDept = Math.Max(maxDept, employee.Department.Length);
                maxPos = Math.Max(maxPos, employee.Position.Length);
            }

            // Print out table
            Console.WriteLine(string.Format("-{0," + maxName + "}-{1," + maxID + "}-{2," + maxDept + "}-{3," + maxPos + "}-", new string('-', maxName), new string('-', maxID), new string('-', maxDept), new string('-', maxPos)));
            Console.WriteLine(string.Format("|{0," + maxName + "}|{1," + maxID + "}|{2," + maxDept + "}|{3," + maxPos + "}|", "Name", "ID Number", "Department", "Position"));
            foreach (var employee in employees)
            {
                Console.WriteLine(string.Format("|{0," + maxName + "}|{1," + maxID + "}|{2," + maxDept + "}|{3," + maxPos + "}|", new string('-', maxName), new string('-', maxID), new string('-', maxDept), new string('-', maxPos)));
                Console.WriteLine(string.Format("|{0," + maxName + "}|{1," + maxID + "}|{2," + maxDept + "}|{3," + maxPos + "}|", employee.Name, employee.IDNumber, employee.Department, employee.Position));
            }
            Console.WriteLine(string.Format("-{0," + maxName + "}-{1," + maxID + "}-{2," + maxDept + "}-{3," + maxPos + "}-", new string('-', maxName), new string('-', maxID), new string('-', maxDept), new string('-', maxPos)));
        }
    }
}