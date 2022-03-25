using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace FciManagementSystem
{
    public class StudentAdmin :Person, ISearchableRemovale<Student>
    {
        List<Student> Students;
        
        public StudentAdmin()
        {
            Students = Repository.LoadStudentData();
        }
        public List<Student>GetAllStudents()
        {
            return Students;
        }
        public bool ValidationOnDepartment(string department)
        {
            return 
                (
                    department.ToUpper() == Options.Deptartmens.CS.ToString()  || 
                    department.ToUpper() == Options.Deptartmens.IS.ToString()  ||
                    department.ToUpper() == Options.Deptartmens.IT.ToString()  || 
                    department.ToUpper() == Options.Deptartmens.MM.ToString()
                );
        }
        public List<Student>Search(string name)
        {
            List<Student> Matches = new List<Student>();
            Matches = Students.Where(x => x.Name == name).ToList();
            return Matches;
        }
        public void Delete(string name, string Department)
        {
            List<Student> res = Search(name);
            if (res.Count == 0) WriteLine("\n\nThis Student isn't Found!\n\n");
            else
            {
                Students.RemoveAll(std => std.Name == name && std.Department == Department);
                WriteLine("\n\n----------You Have Successfully Delete Student With Name " + name + " In " + Department + " Department ----------\n\n");

            }
        }
        public void clear()
        {
            Students.Clear();
        }
        public void DisplayStudentData(List<Student> students)
        {
            if (students == null) 
                return;
            foreach(var student in students)
            {
                WriteLine(student.ToString());
            }
        }
    }
}
