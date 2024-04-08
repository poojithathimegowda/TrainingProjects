using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypesPractice
{
    public class Employee
    {

        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int EmployeeId { get; set; }
        public DateTime DateOfBirth { get; set; }

       

        public Double Salary { get; set; }


        public Employee()
        {
        }
        public Employee(int id, int depId, string name, string pNo, DateTime dob, double salary)
        {
            EmployeeId = id;
            Name = name;
            PhoneNumber = pNo;
            DepartmentId = depId;
            DateOfBirth = dob;
            Salary = salary;
        }
        public override string ToString()
        {
            return Name;
        }

    }

}
