using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMDA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee> { new Employee(), new Employee(), new Employee(), new Employee(), new Employee(), new Employee(), new Employee(), new Employee(), new Employee(), new Employee() }; // 10 employees
            employeeList[0].FirstName = "Daniel"; //instance of joe
            employeeList[0].Id = 5; // assign id = 

            employeeList[1].FirstName = "Jada"; //instance of joe
            employeeList[1].Id = 6; // assign id =

            employeeList[2].FirstName = "Daniel"; //instance of sue
            employeeList[2].Id = 7; // assign id =

            List<Employee> joeList = new List<Employee>();

            foreach (Employee employee in employeeList)
            {

                if (employee.FirstName == "Daniel")
                {
                    joeList.Add(employee);
                    //Console.WriteLine(employee.FirstName);  // test result
                }

            }

            List<Employee> newjoeList = employeeList.Where(x => x.FirstName == "Daniel").ToList();
            //Console.WriteLine(newdanielList[0].FirstName + ", " + newdanielList[1].FirstName);    // test result

            List<Employee> idjoeList = employeeList.Where(x => x.Id > 5).ToList(); // Lambda to return Id greater than 5
            //Console.WriteLine(iddanielList[0].Id + ", " + iddanielList[1].Id);  // test result

            Console.ReadLine();
        }
    }
}
