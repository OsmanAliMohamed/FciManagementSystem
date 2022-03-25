using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace FciManagementSystem
{
    public class TechnicianAdmin : ISearchableRemovale<Technician>
    {
        List<Technician> Technicians;
        public TechnicianAdmin()
        {
            Technicians = Repository.LoadTechniciandata();
        }
        public List<Technician>GetAllTechnicians()
        {
            return Technicians;
        }
        public List<Technician> Search(string name)
        {
            List<Technician> matches =
                Technicians.Where(techname => techname.Name.ToLower() == name).ToList();
            return matches;
        }
        public void Delete(string name, string Department)
        {

            Technicians.RemoveAll(tech => tech.Name == name && tech.Department == Department);
        }
        public void DisplayTechnicianData(List<Technician> technicians)
        {
            if (technicians == null) return;
            foreach (var student in technicians)
            {
                WriteLine(student.ToString());
            }
        }
    }
}
