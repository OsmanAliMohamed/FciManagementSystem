using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FciManagementSystem
{
    public class Technician:Person
    {
        public string Department { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return string.Format("ID is : {0} \t Name is : {1} \t Age is : {2} \t Address is : {3} \t " +
                "Gender is : {4} \t  Department is : {5} \t Salary is : {6}"
                , ID, Name, Age, Address, Gender, Department,Salary);
        }
    }
}
