using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace FciManagementSystem
{
    public class Student:Person
    {
        private float _Gpa;
        public float Gpa
        {
            get
            {
                return this._Gpa;
            }
            set
            {
                if(value > 4)
                {
                    this._Gpa = 4;
                }
                else
                {
                    this._Gpa = value;
                }
            }
        
        }
        public string Department { get; set; }
        public override string ToString()
        {
            WriteLine("               *******************************************************                     ");
            return string.Format("ID is : {0} \t Name is : {1} \t Age is : {2} \t Address is : {3} \t " +
                "Gender is : {4} \n Gpa is : {5} \t Department is : {6}"
                , ID, Name, Age, Address, Gender, Gpa, Department);
            

        }
    }
}
