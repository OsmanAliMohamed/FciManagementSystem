using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace FciManagementSystem
{
    public class InstructorAdmin : ISearchableRemovale<Instructor>
    {
        List<Instructor> Instructors = Repository.LoadInstructorData();
        public InstructorAdmin()
        {
        }
        public List<Instructor>GetAllInstructors()
        {
            return Instructors;
        }
        public List<Instructor> Search(string name)
        {
            List<Instructor> Matches = new List<Instructor>();
            Matches = Instructors.Where(x => x.Name.ToLowerInvariant() == name).ToList();
            return Matches;
        }
        public void Delete(string name,string Department)
        {
            Instructors.Where(inst => inst.Name == name && inst.Department == Department);
        }
        public void DisplayInstructortData(List<Instructor> students)
        {
            foreach (var student in students)
            {
                WriteLine(student.ToString());
            }
        }
    }
}
