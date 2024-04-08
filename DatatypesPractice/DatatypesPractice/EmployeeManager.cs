using Newtonsoft.Json.Linq;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;

namespace DatatypesPractice
{
    public class EmployeeManager : SQLiteDatabaseManager
    {
        public EmployeeManager()
        {
        }

        // Custom methods specific to the Employee table, if needed
        public void InsertEmployee(Employee employee)
        {
            string query = "INSERT INTO Employees (DepartmentId,Name,PhoneNumber,DateOfBirth,Salary) VALUES (@DepartmentId,@Name,@PhoneNumber,@DateOfBirth,@Salary)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            // parameters.Add("@@EmployeeId", employee.EmployeeId);
            parameters.Add("@DepartmentId", employee.DepartmentId);
            parameters.Add("@Name", employee.Name);
            parameters.Add("@DateOfBirth", employee.DateOfBirth);
            parameters.Add("@PhoneNumber", employee.PhoneNumber);
            parameters.Add("@Salary", employee.Salary);
            ExecuteNonQuery(query, parameters);
        }

        public List<Employee> GetAllEmployees()
        {
            string query = "SELECT EmployeeId, DepartmentId, Name, PhoneNumber, DateOfBirth, Salary FROM Employees";

            // Dictionary<string, object> parameters = new Dictionary<string, object>();


            var results = ExecuteQuery(query);
            var employees = new List<Employee>();


            foreach (var result in results)
            {



                Employee employee = new Employee()
                {
                    EmployeeId = Convert.ToInt32(result["EmployeeId"]),
                    DepartmentId = Convert.ToInt32(result["DepartmentId"]),
                    Name = Convert.ToString(result["Name"]),
                    PhoneNumber = Convert.ToString(result["PhoneNumber"]),
                    DateOfBirth = Convert.ToDateTime(result["DateOfBirth"]),
                    Salary = Convert.ToDouble(result["Salary"]),

                };
                employees.Add(employee);
            }



            return employees;
        }

        public List<Employee> NewGetAllEmployees()
        {
            string query = "SELECT EmployeeId, DepartmentId, Name, PhoneNumber, DateOfBirth, Salary FROM Employees";

            // Dictionary<string, object> parameters = new Dictionary<string, object>();


            var results = ExecuteQueryInClassType<Employee>(query);

            //var employees = new List<Employee>();


            //foreach (var result in results)
            //{



            //    Employee employee = new Employee()
            //    {
            //        EmployeeId = Convert.ToInt32(result["EmployeeId"]),
            //        DeparmentId = Convert.ToInt32(result["DepartmentId"]),
            //        Name = Convert.ToString(result["Name"]),
            //        PhoneNumber = Convert.ToString(result["PhoneNumber"]),
            //        DateOfBirth = Convert.ToDateTime(result["DateOfBirth"]),

            //        Salary = new Currency(Tools.ExtractNumbers(Convert.ToString(result["Salary"])), Tools.ExtractAlphaChars(Convert.ToString(result["Salary"]))),
            //        //Convert.toc(result["Salary"])
            //    };
            //    employees.Add(employee);
            //}



            return results;
        }

        public Employee ReadEmployeeDataAt(int employeeId)
        {
            string query = "SELECT DepartmentId, Name, PhoneNumber, EmployeeId, DateOfBirth, Salary FROM Employees WHERE EmployeeId = @EmployeeId";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
               { "@EmployeeId", employeeId }

            };
            var result = ExecuteQuery(query, parameters);

            if (result.Count > 0)
            {
                Dictionary<string, object> employeeData = result[0]; // Assuming only one employee is returned

                Employee employee = new Employee()
                {
                    EmployeeId = Convert.ToInt32(employeeData["EmployeeId"]),
                    DepartmentId = Convert.ToInt32(employeeData["DepartmentId"]),
                    Name = Convert.ToString(employeeData["Name"]),
                    PhoneNumber = Convert.ToString(employeeData["PhoneNumber"]),
                    DateOfBirth = Convert.ToDateTime(employeeData["DateOfBirth"]),
                    Salary = Convert.ToDouble(employeeData["Salary"])
                };

                return employee;
            }
            else
            {
                return null; // No employee found with the given ID
            }
        }

        public void UpdateEmployee(int employeeId, string newName)
        {
            string query = @"UPDATE Employees SET Name = @NewName WHERE EmployeeId = @EmployeeId";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
               { "@NewName", newName },
               { "@EmployeeId", employeeId }
            };

            ExecuteNonQuery(query, parameters);
        }
        public void DeleteEmployee(int employeeId)
        {
            string query = @"DELETE FROM Employees WHERE EmployeeId = 'EmployeeId' ;";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@EmployeeId", employeeId }
            };

            if (parameters.Count>0)
            {
                ExecuteNonQuery(query, parameters);
            }
            //else
            //{
            //    return null;
            //}
            
        }
            
    }
}


