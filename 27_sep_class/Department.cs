using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_sep_class
{
    public class Department
    {
        public int Deptcode { get; set; }

        public string Deptname { get; set; }

        public List<Employee> emps = new List<Employee>();
    }

    public class Employee
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
    }
}
