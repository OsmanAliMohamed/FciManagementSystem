using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FciManagementSystem.Options;

namespace FciManagementSystem
{
    public class Repository
    {
        
        public static List<Student> LoadStudentData()
        {
            return new List<Student>
            {
                new Student
                {
                    ID = 1,
                    Name = "Osman",
                    Age = 22,
                    Address = "Assiut",
                    Gpa = 3,
                    Department = Deptartmens.CS.ToString(),
                    Gender = Sex.Male.ToString()
                },
                new Student
                {
                    ID = 2,
                    Name = "Ali",
                    Age = 21,
                    Address = "Alex",
                    Gpa = 3.2f,
                    Department = Deptartmens.IS.ToString(),
                    Gender = Sex.Male.ToString()
                },
                new Student
                {
                    ID = 3,
                    Name = "Moaz",
                    Age = 22,
                    Address = "Assiut",
                    Gpa = 2.8f,
                    Department = Deptartmens.IT.ToString(),
                    Gender = Sex.Male.ToString()
                },
                new Student
                {
                    ID = 4,
                    Name = "Ola",
                    Age = 20,
                    Address = "Assiut",
                    Gpa = 3,
                    Department = Deptartmens.CS.ToString(),
                    Gender = Sex.Female.ToString()
                },
                new Student
                {
                    ID = 5,
                    Name = "Hosni",
                    Age = 22,
                    Address = "Assiut",
                    Gpa = 3,
                    Department = Deptartmens.MM.ToString(),
                    Gender = Sex.Male.ToString()
                },
                new Student
                {
                    ID = 6,
                    Name = "Omar",
                    Age = 22,
                    Address = "Giza",
                    Gpa = 3,
                    Department = Deptartmens.MM.ToString(),
                    Gender = Sex.Male.ToString()
                },
                new Student
                {
                    ID = 16,
                    Name = "Omar",
                    Age = 22,
                    Address = "Giza",
                    Gpa = 3,
                    Department = Deptartmens.MM.ToString(),
                    Gender = Sex.Male.ToString()
                },
                new Student
                {
                    ID = 17,
                    Name = "Hamid",
                    Age = 22,
                    Address = "Assiut",
                    Gpa = 3,
                    Department = Deptartmens.IS.ToString(),
                    Gender = Sex.Male.ToString()
                },
                new Student
                {
                    ID = 7,
                    Name = "Asmaa",
                    Age = 22,
                    Address = "Assiut",
                    Gpa = 3,
                    Department = Deptartmens.CS.ToString(),
                    Gender = Sex.Female.ToString()
                },
                new Student
                {
                    ID = 8,
                    Name = "Amira",
                    Age = 22,
                    Address = "Assiut",
                    Gpa = 3,
                    Department = Deptartmens.CS.ToString(),
                    Gender = Sex.Female.ToString()
                },
                new Student
                {
                    ID = 9,
                    Name = "Mohamed",
                    Age = 21,
                    Address = "Minia",
                    Gpa = 3,
                    Department = Deptartmens.IT.ToString(),
                    Gender = Sex.Male.ToString()
                },
                new Student
                {
                    ID = 10,
                    Name = "Hamdy",
                    Age = 22,
                    Address = "Assiut",
                    Gpa = 3,
                    Department = Deptartmens.CS.ToString(),
                    Gender = Sex.Male.ToString()
                },
                new Student
                {
                    ID = 11,
                    Name = "Asmaa",
                    Age = 22,
                    Address = "Assiut",
                    Gpa = 3,
                    Department = Deptartmens.IT.ToString(),
                    Gender = Sex.Female.ToString()
                },
                new Student
                {
                    ID = 12,
                    Name = "Khalid",
                    Age = 22,
                    Address = "loxur",
                    Gpa = 3,
                    Department = Deptartmens.MM.ToString(),
                    Gender = Sex.Male.ToString()
                },
                new Student
                {
                    ID = 13,
                    Name = "Doaa",
                    Age = 22,
                    Address = "Assiut",
                    Gpa = 3,
                    Department = Deptartmens.CS.ToString(),
                    Gender = Sex.Female.ToString()
                },
                new Student
                {
                    ID = 14,
                    Name = "Aya",
                    Age = 22,
                    Address = "Assiut",
                    Gpa = 3,
                    Department = Deptartmens.MM.ToString(),
                    Gender = Sex.Female.ToString()
                },
                new Student
                {
                    ID = 15,
                    Name = "Mayer",
                    Age = 22,
                    Address = "Assiut",
                    Gpa = 3,
                    Department = Deptartmens.CS.ToString(),
                    Gender = Sex.Female.ToString()
                },
            };
        }
        public static List<Instructor>LoadInstructorData()
        {
            return new List<Instructor>
            {
                new Instructor
                {
                    ID = 20,
                    Name = "Khaled",
                    Age = 40,
                    Address = "Giza",
                    Phone = "01155212548",
                    Department = Deptartmens.CS.ToString(),
                    Gender = Sex.Male.ToString(),
                    Salary = 7000
                },
                new Instructor
                {
                    ID = 21,
                    Name = "Mohamed",
                    Age = 30,
                    Address = "Assiut",
                    Phone = "01546468464",
                    Department = Deptartmens.IT.ToString(),
                    Gender = Sex.Male.ToString(),
                    Salary = 7500f
                },
                new Instructor
                {
                    ID = 22,
                    Name = "Menna",
                    Age = 27,
                    Address = "Luxor",
                    Phone = "01175212548",
                    Department = Deptartmens.CS.ToString(),
                    Gender = Sex.Female.ToString(),
                    Salary = 7000
                },
                new Instructor
                {
                    ID = 23,
                    Name = "Hosni",
                    Age = 33,
                    Address = "Cairo",
                    Phone = "01135212548",
                    Department = Deptartmens.CS.ToString(),
                    Gender = Sex.Male.ToString(),
                    Salary = 7000
                },
                new Instructor
                {
                    ID = 24,
                    Name = "Alaa",
                    Age = 25,
                    Address = "Assiut",
                    Phone = "01157212548",
                    Department = Deptartmens.IS.ToString(),
                    Gender = Sex.Male.ToString(),
                    Salary = 6000
                },
                new Instructor
                {
                    ID = 25,
                    Name = "Ziad",
                    Age = 40,
                    Address = "Minia",
                    Phone = "01153312548",
                    Department = Deptartmens.CS.ToString(),
                    Gender = Sex.Male.ToString(),
                    Salary = 8000
                },
                new Instructor
                {
                    ID = 26,
                    Name = "Aml Tarik",
                    Age = 44,
                    Address = "Giza",
                    Phone = "01120212548",
                    Department = Deptartmens.CS.ToString(),
                    Gender = Sex.Female.ToString(),
                    Salary = 10000
                },
                new Instructor
                {
                    ID = 27,
                    Name = "Hassan Ali",
                    Age = 40,
                    Address = "Giza",
                    Phone = "01155212548",
                    Department = Deptartmens.CS.ToString(),
                    Gender = Sex.Male.ToString(),
                    Salary = 7000
                },
                new Instructor
                {
                    ID = 28,
                    Name = "Moaz Ali",
                    Age = 40,
                    Address = "Giza",
                    Phone = "01155212548",
                    Department = Deptartmens.CS.ToString(),
                    Gender = Sex.Male.ToString(),
                    Salary = 7000
                },
            };


        }
        public static List<Technician>LoadTechniciandata()
        {
            return new List<Technician>
            {
                new Technician
                {
                    ID = 30,
                    Name = "Hanan Ahmed",
                    Address = "Assiut",
                    Age = 30,
                    Department = Deptartmens.CS.ToString(),
                    Gender = Sex.Male.ToString(),
                    Phone = "01222265445",
                    Salary = 6000
                },
                new Technician
                {
                    ID = 3,
                    Name = "Farraj Ahmed",
                    Address = "Assiut",
                    Age = 25,
                    Department = Deptartmens.IS.ToString(),
                    Gender = Sex.Male.ToString(),
                    Phone = "01222265445",
                    Salary = 5000   
                },
                new Technician
                {
                    ID = 32,
                    Name = "Essam Ahmed",
                    Address = "Assiut",
                    Age = 33,
                    Department = Deptartmens.MM.ToString(),
                    Gender = Sex.Male.ToString(),
                    Phone = "01522265445",
                    Salary = 4000
                },
                new Technician
                {
                    ID = 33,
                    Name = "Abdo malek",
                    Address = "Assiut",
                    Age = 20,
                   Department = Deptartmens.CS.ToString(),
                    Gender = Sex.Male.ToString(),
                    Phone = "01122265445",
                    Salary = 3000
                }
            };
        }
    }
}
