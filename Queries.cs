using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FciManagementSystem.Options;

namespace FciManagementSystem
{
    public static class Queries
    {
        public static IEnumerable<T> Filter<T>(IEnumerable<T>list,Func<T,bool>predicate)
        {
            foreach(var item in list)
            {
                if(predicate(item))
                {
                    yield return item;
                }
            }
        }
        public static List<Student> StudentFiltrtBasedOnDepartment(List<Student> students,string deptName)
        {
            if (deptName == Deptartmens.CS.ToString())
            {
                var result = students.Where(std => std.Department == Deptartmens.CS.ToString()).ToList();
                return result; // Using Lamda Expression
            }
            else if(deptName == Deptartmens.IS.ToString())
            {
                var result = from student in students
                             where student.Department == Deptartmens.IS.ToString()
                             select student;
                return result.ToList();     // Using Query Syntax
            }
            else if(deptName == Deptartmens.IT.ToString())
            {
                var result = Filter(students, std => std.Department == Deptartmens.IT.ToString()).ToList();
                return result; // Using My Filter Function
            }
            else
            {
                var result = Filter(students, std => std.Department == Deptartmens.MM.ToString()).ToList();
                return result;
            }
        }
        public static List<Student> StudentFilterBasedOnGender(List<Student> students, string gender)
        {
            if (gender == Sex.Male.ToString())
            {
                var result = students.Where(std => std.Gender == Sex.Male.ToString()).ToList();
                return result; // Using Lamda Expression
            }
            else
            {
                var result = students.Where(std => std.Gender == Sex.Female.ToString()).ToList();
                return result; // Using Lamda Expression
            }
        }
        public static List<Student> StudentFilterBasedOnAddress(List<Student> students, string address)
        {
            //var result = from student in students
            //             where student.Address == address
            //             select student;
            //return result.ToList();
            var result = Filter(students, std => std.Address == address).ToList();
            return result;
        }

        public static List<Student> StudentFilterBasedOnSpcifiedName(List<Student> students,string name)
        {
            // equal search Method
            return (students.Where(std => std.Name == name).ToList());
        }
        public static List<Student> StudentFilterBasedOnIDAndGPaMoreThan3(List<Student>students)
        {
            return (students.Where(std => std.Gpa > 3).ToList());
        }
        public static List<Instructor> InstructorFilterBasedOnDepartment(List<Instructor> instructors, string deptName)
        {
            if (deptName == Deptartmens.CS.ToString())
            {
                var result = instructors.Where(inst => inst.Department == Deptartmens.CS.ToString()).ToList();
                return result; // Using Lamda Expression
            }
            else if (deptName == Deptartmens.IS.ToString())
            {
                var result = from inst in instructors
                             where inst.Department == Deptartmens.IS.ToString()
                             select inst;
                return result.ToList();     // Using Query Syntax
            }
            else if (deptName == Deptartmens.IT.ToString())
            {
                var result = Filter(instructors, inst => inst.Department == Deptartmens.IT.ToString()).ToList();
                return result; // Using My Filter Function
            }
            else
            {
                var result = Filter(instructors, inst => inst.Department == Deptartmens.MM.ToString()).ToList();
                return result;
            }
        }
        public static List<Instructor> FilterBasedOnSalary(List<Instructor>instructors)
        {
            return (instructors.Where(inst => inst.Salary > 5000).ToList());
        }
        public static List<Technician> TechnicianFilterBasedOnDepartment(List<Technician> technicians,string dept)
        {
            if (dept == Deptartmens.CS.ToString())
            {
                var result = technicians.Where(tech => tech.Department == Deptartmens.CS.ToString()).ToList();
                return result; // Using Lamda Expression
            }
            else if (dept == Deptartmens.IS.ToString())
            {
                var result = from inst in technicians
                             where inst.Department == Deptartmens.IS.ToString()
                             select inst;
                return result.ToList();     // Using Query Syntax
            }
            else if (dept == Deptartmens.IT.ToString())
            {
                var result = Filter(technicians, tech => tech.Department == Deptartmens.IT.ToString()).ToList();
                return result; // Using My Filter Function
            }
            else
            {
                var result = Filter(technicians, tech => tech.Department == Deptartmens.MM.ToString()).ToList();
                return result;
            }
        }



    }
}
