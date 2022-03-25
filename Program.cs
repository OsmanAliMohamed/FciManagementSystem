using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace FciManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Type1 = new Student();
            Person Type2 = new Instructor();
            Person Type3 = new Technician();
            InstructorAdmin instructorAdmin = new InstructorAdmin();
            StudentAdmin studentAdmin = new StudentAdmin();
            TechnicianAdmin technicianAdmin = new TechnicianAdmin();
            List<Student> students = studentAdmin.GetAllStudents();
            List<Instructor> instructors = instructorAdmin.GetAllInstructors();
            List<Technician> technicians = technicianAdmin.GetAllTechnicians();
            WriteLine("*****************************************=>> Login Firstly <<=***************************");
            Retry: Write("Enter Username : ");
            string Username = ReadLine();
            Write("Enter Passward : ");
            string Password = ReadLine();
            while (true)
            {
                if (Login(Username, Password))
                {
                    while (true)
                    {
                        WriteLine();
                        MainMinu();
                        WriteLine();

                        int Choice = int.Parse(ReadLine());
                        if (Choice == 1)
                        {
                            while (true)
                            {
                                DispalyMinu();
                                WriteLine();
                                WriteLine("\n\n==> ***************************** Enter Your Choice ************************************\n\n");
                                int DisplayChoice = int.Parse(ReadLine());
                                if (DisplayChoice == 1)
                                {
                                    studentAdmin.DisplayStudentData(studentAdmin.GetAllStudents());
                                }
                                else if (DisplayChoice == 2)
                                {
                                    instructorAdmin.DisplayInstructortData(instructorAdmin.GetAllInstructors());
                                }
                                else if (DisplayChoice == 3)
                                {
                                    technicianAdmin.DisplayTechnicianData(technicianAdmin.GetAllTechnicians());
                                }
                                else if (DisplayChoice == 4)
                                {
                                    break;
                                }
                                else
                                {
                                    WriteLine("Hhmmmmmm Enter Correct Chioce !!");
                                }
                            }
                        }
                        else if (Choice == 2)
                        {
                            while (true)
                            {
                                AddMinu();
                                int AddChoice = int.Parse(ReadLine());
                                if (AddChoice == 1)
                                {
                                    WriteLine(" == >   Enter Number Of Students That U Want To Add   <== ");
                                    int NumOfStudent = int.Parse(ReadLine());
                                    for (int i = 0; i < NumOfStudent; i++)
                                    {
                                        WriteLine("Enter ID Of Student  : " + (i + 1));
                                        int ID = int.Parse(ReadLine());
                                        WriteLine("Enter Name Of Student  : " + (i + 1));
                                        string Name = ReadLine();
                                        Dept:
                                        WriteLine("Enter Department Of Student  : " + (i + 1));
                                        string Department = ReadLine();
                                        if (studentAdmin.ValidationOnDepartment(Department))
                                        {
                                            WriteLine("Enter Gender Of Student  : " + (i + 1));
                                            string Gender = ReadLine();
                                            WriteLine("Enter Age Of Student  : " + (i + 1));
                                            int Age = int.Parse(ReadLine());
                                            WriteLine("Enter Gpa Of Student  : " + (i + 1));
                                            float GPA = float.Parse(ReadLine());
                                            WriteLine("Enter Address Of Student  : " + (i + 1));
                                            string Address = ReadLine();
                                            WriteLine("Enter Phone Of Student  : " + (i + 1));
                                            string Phone = ReadLine();
                                            Student student = new Student
                                            {
                                                ID = ID,
                                                Name = Name,
                                                Department = Department,
                                                Age = Age,
                                                Address = Address,
                                                Gender = Gender,
                                                Gpa = GPA,
                                                Phone = Phone
                                            };
                                            students.Add(student);
                                        }
                                        else
                                        {
                                            WriteLine("Enter Correct Department!");
                                            goto Dept;
                                        }
                                    }
                                    WriteLine();
                                    WriteLine("---------------------------------->> You Have Successfully Added <<-------------------------- ");
                                    WriteLine();

                                }
                                else if (AddChoice == 2)
                                {
                                    WriteLine(" == >   Enter Number Of Instructors That U Want To Add   <== ");
                                    int NumOfInstructor = int.Parse(ReadLine());
                                    for (int i = 0; i < NumOfInstructor; i++)
                                    {
                                        WriteLine("Enter ID Of Instructor  : " + (i + 1));
                                        int ID = int.Parse(ReadLine());
                                        WriteLine("Enter Name Of Instructor  : " + (i + 1));
                                        string Name = ReadLine();
                                        WriteLine("Enter Department Of Instructor  : " + (i + 1));
                                        string Department = ReadLine();
                                        WriteLine("Enter Gender Of Instructor  : " + (i + 1));
                                        string Gender = ReadLine();
                                        WriteLine("Enter Age Of Instructor  : " + (i + 1));
                                        int Age = int.Parse(ReadLine());
                                        WriteLine("Enter Salary Of Student  : " + (i + 1));
                                        double Salary = double.Parse(ReadLine());
                                        WriteLine("Enter Address Of Instructor  : " + (i + 1));
                                        string Address = ReadLine();
                                        WriteLine("Enter Phone Of Instructor  : " + (i + 1));
                                        string Phone = ReadLine();
                                        Instructor instructor = new Instructor
                                        {
                                            ID = ID,
                                            Name = Name,
                                            Department = Department,
                                            Age = Age,
                                            Address = Address,
                                            Gender = Gender,
                                            Salary = Salary,
                                            Phone = Phone
                                        };
                                        instructors.Add(instructor);
                                    }
                                    WriteLine();
                                    WriteLine("---------------------------------->> You Have Successfully Added <<-------------------------- ");
                                    WriteLine();
                                }
                                else if (AddChoice == 3)
                                {
                                    WriteLine(" == >   Enter Number Of Technicians That U Want To Add   <== ");
                                    int NumOfTechnician = int.Parse(ReadLine());
                                    for (int i = 0; i < NumOfTechnician; i++)
                                    {
                                        WriteLine("Enter ID Of Technician  : " + (i + 1));
                                        int ID = int.Parse(ReadLine());
                                        WriteLine("Enter Name Of Technician  : " + (i + 1));
                                        string Name = ReadLine();
                                        WriteLine("Enter Department Of Technician  : " + (i + 1));
                                        string Department = ReadLine();
                                        WriteLine("Enter Gender Of Technician  : " + (i + 1));
                                        string Gender = ReadLine();
                                        WriteLine("Enter Age Of Technician  : " + (i + 1));
                                        int Age = int.Parse(ReadLine());
                                        WriteLine("Enter Salary Of Technician  : " + (i + 1));
                                        double Salary = double.Parse(ReadLine());
                                        WriteLine("Enter Address Of Technician  : " + (i + 1));
                                        string Address = ReadLine();
                                        WriteLine("Enter Phone Of Technician  : " + (i + 1));
                                        string Phone = ReadLine();
                                        Technician technician = new Technician
                                        {
                                            ID = ID,
                                            Name = Name,
                                            Department = Department,
                                            Age = Age,
                                            Address = Address,
                                            Gender = Gender,
                                            Salary = Salary,
                                            Phone = Phone
                                        };
                                        technicians.Add(technician);
                                    }
                                    WriteLine();
                                    WriteLine("---------------------------------->> You Have Successfully Added <<-------------------------- ");
                                    WriteLine();

                                }
                                else if (AddChoice == 4)
                                {
                                    break;
                                }
                                else
                                {
                                    WriteLine("Hhmmmmmm Enter Correct Chioce !!");
                                }

                            }
                        }
                        else if (Choice == 3)
                        {
                            while (true)
                            {
                                DeleteMinu();
                                int DeleteChoice = int.Parse(ReadLine());
                                if (DeleteChoice == 1)
                                {
                                    Write("Enter Name Of Student That U Want To Delete Him/Her : ");
                                    string StudentName = ReadLine();
                                    Write("Enter His/Her Department : ");
                                    string StudentDepartment = ReadLine();
                                    studentAdmin.Delete(StudentName, StudentDepartment);
                                }
                                else if (DeleteChoice == 2)
                                {
                                    Write("Enter Name Of Instructor That U Want To Delete Him/Her : ");
                                    string instructortName = ReadLine();
                                    Write("Enter His/Her Department : ");
                                    string instructorDepartment = ReadLine();
                                    instructorAdmin.Delete(instructortName, instructorDepartment);
                                }
                                else if (DeleteChoice == 3)
                                {
                                    Write("Enter Name Of Technitian That U Want To Delete Him/Her : ");
                                    string TechnitiantName = ReadLine();
                                    Write("Enter His/Her Department : ");
                                    string TechnitianDepartment = ReadLine();
                                    instructorAdmin.Delete(TechnitiantName, TechnitianDepartment);
                                    WriteLine("\n\n----------You Have Successfully Delete Technician With Name " + TechnitiantName + " In " + TechnitianDepartment + " Department ----------\n\n");
                                }
                                else if (DeleteChoice == 4)
                                {
                                    break;
                                }
                                else
                                {
                                    WriteLine("Hhmmmmmm Enter Correct Chioce !!");
                                }
                            }
                        }
                        else if (Choice == 4)
                        {
                            while (true)
                            {
                                SearchMinu();
                                int SearchChoice = int.Parse(ReadLine());
                                if (SearchChoice == 1)
                                {
                                    WriteLine("Enter Student Name That U Want To Search About Him/Her : ");
                                    string studentName = ReadLine();
                                    List<Student> Matches = studentAdmin.Search(studentName);
                                    if (Matches.Count == 0)
                                    {
                                        WriteLine("\n\n--------This Student can't be found !------------\n\n");
                                    }
                                    studentAdmin.DisplayStudentData(Matches);
                                }
                                else if (SearchChoice == 2)
                                {
                                    WriteLine("Enter Instructor Name That U Want To Search About Him/Her : ");
                                    string InstructorName = ReadLine();
                                    List<Instructor> Matches = instructorAdmin.Search(InstructorName);
                                    if (Matches.Count == 0)
                                    {
                                        WriteLine("\n\n--------This Instructor can't be found !------------\n\n");
                                    }
                                    instructorAdmin.DisplayInstructortData(Matches);
                                }
                                else if (SearchChoice == 3)
                                {
                                    WriteLine("Enter Technician Name That U Want To Search About Him/Her : ");
                                    string TechnicianName = ReadLine();
                                    List<Technician> Matches = technicianAdmin.Search(TechnicianName);
                                    if (Matches.Count == 0)
                                    {
                                        WriteLine("\n\n--------This Technician can't be found !------------\n\n");
                                    }
                                    technicianAdmin.DisplayTechnicianData(Matches);
                                }
                                else if (SearchChoice == 4)
                                {
                                    break;
                                }
                                else
                                {
                                    WriteLine("Hhmmmmmm Enter Correct Chioce !!");
                                }
                            }
                        }
                        else if (Choice == 5)
                        {
                            while (true)
                            {
                                WriteLine();
                                QueryMinu();
                                int FilterChoice = int.Parse(ReadLine());
                                if (FilterChoice == 1)
                                {
                                    WriteLine("Enter Student Department : ");
                                    string department = ReadLine();
                                    List<Student> res = Queries.StudentFiltrtBasedOnDepartment(students, department);
                                    studentAdmin.DisplayStudentData(res);
                                }
                                else if (FilterChoice == 2)
                                {
                                    WriteLine("Enter Student Gender : ");
                                    string gender = ReadLine();
                                    studentAdmin.DisplayStudentData(Queries.StudentFilterBasedOnGender(students, gender));
                                }
                                else if (FilterChoice == 3)
                                {
                                    WriteLine("Enter Student Address : ");
                                    string address = ReadLine();
                                    studentAdmin.DisplayStudentData(Queries.StudentFilterBasedOnAddress(students, address));
                                }
                                else if (FilterChoice == 4)
                                {
                                    studentAdmin.DisplayStudentData(Queries.StudentFilterBasedOnIDAndGPaMoreThan3(students));
                                }
                                else if (FilterChoice == 5)
                                {
                                    WriteLine("Enter Instructor Department : ");
                                    string department = ReadLine();
                                    List<Instructor> res = Queries.InstructorFilterBasedOnDepartment(instructors, department);
                                    instructorAdmin.DisplayInstructortData(res);
                                }
                                else if (FilterChoice == 6)
                                {
                                    instructorAdmin.DisplayInstructortData(Queries.FilterBasedOnSalary(instructors));
                                }
                                else if (FilterChoice == 7)
                                {
                                    WriteLine("Enter technition Department : ");
                                    string department = ReadLine();
                                    List<Technician> res = Queries.TechnicianFilterBasedOnDepartment(technicians, department);
                                    technicianAdmin.DisplayTechnicianData(res);
                                }
                                else if (FilterChoice == 8)
                                {
                                    break;
                                }
                                else
                                {
                                    WriteLine("Hmmmmm Enter Choice from 1 to ==== > 9 ");
                                }
                            }
                        }
                        else if (Choice == 6)
                        {
                            while (true)
                            {
                                int ClearChoice = int.Parse(ReadLine());
                                if (ClearChoice == 1)
                                {
                                    studentAdmin.clear();
                                    WriteLine("Return to display students to check if list is empty or No");
                                }
                                else if (ClearChoice == 2)
                                {
                                    instructors.Clear();
                                    WriteLine("Return to display instructors to check if list is empty or No");
                                }
                                else if (ClearChoice == 3)
                                {
                                    technicians.Clear();
                                    WriteLine("Return to display technicians to check if list is empty or No");
                                }
                                else if(ClearChoice == 4)
                                {
                                    break;
                                }
                                else WriteLine("Hhmmmmmm Enter Correct Chioce !!");
                            }
                        }
                        else if (Choice == 7)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    WriteLine("\n---------------------------------- >> incorrect Username Or Password << --------------------------\n\n");
                    WriteLine("---------------------------------- >> To Login Again Press 1 : << --------------------------");
                    WriteLine("---------------------------------- >> To  Close The Program Press Any Key << --------------------------");
                    int test = int.Parse(ReadLine());
                    if(test == 1)
                    {
                        goto Retry;
                    }
                    else
                    {
                        break;
                    }
                
                }
            }
            ReadKey();

        }
        public static bool Login(string username, string password)
        {
            return username.ToLowerInvariant() == "ahmed@gmail.com" && password.ToLowerInvariant() == "ahmed ali";
        }
        public static void MainMinu()
        {

            WriteLine("                            **********************************************         ");
            WriteLine();
            WriteLine("*****************************************=>> To Diaplay Press : 1 <<=***************************");
            WriteLine("*****************************************=>> To Add Person Press : 2 <<= ***********************");
            WriteLine("*****************************************=>> To Delete Person Press : 3 <<= ***********************");
            WriteLine("*****************************************=>> To Search About Person Press : 4 <<= ***********************");
            WriteLine("*****************************************=>> To Do Some Query Press : 5 <<= ***********************");
            WriteLine("*****************************************=>> To Clear List press : 6 <<= ***********************");
            WriteLine("*****************************************=>> To End The Program Press : 7 <<= ***********************");
            WriteLine();
            WriteLine("                           -----------------------------------------------              ");
        }
        public static void DispalyMinu()
        {
            WriteLine();
            WriteLine("1   ==>> To Display All Students ");
            WriteLine("2   ==>> To Display All Instructors ");
            WriteLine("3   ==>> To Display All Technicians ");
            WriteLine("4   ==>  To Back");
        }
        public static void AddMinu()
        {
            WriteLine();
            WriteLine("1   ==>> To Add Student ");
            WriteLine("2   ==>> To Add Instructor ");
            WriteLine("3   ==>> To Add Technician ");
            WriteLine("4   ==>  To Back");
            WriteLine();
            WriteLine("\n\n==> ***************************** Enter Your Choice ************************************\n\n");
        }
        public static void DeleteMinu()
        {
            WriteLine();
            WriteLine("1   ==>> To Delete Student ");
            WriteLine("2   ==>> To Delete Instructor ");
            WriteLine("3   ==>> To Delete Technician ");
            WriteLine("4   ==>  To Back");
            WriteLine();
            WriteLine("==> ***************************** Enter Your Choice ************************************");  
        }
        public static void SearchMinu()
        {
            WriteLine();
            WriteLine("1   ==>> To Search About Student ");
            WriteLine("2   ==>> To Search About Instructor ");
            WriteLine("3   ==>> To Search About Technician ");
            WriteLine("4   ==>  To Back");
            WriteLine();
            WriteLine("\n\n==> ***************************** Enter Your Choice ************************************\n\n");
        }
        public static void QueryMinu()
        {
            WriteLine();
            WriteLine("1   ==>>           To Get All Students in Spicified Department");
            WriteLine("2   ==>>           To Filter Student Based On Gender");
            WriteLine("3   ==>>           To Filter Student Based On Address");
            WriteLine("4   ==>            To Get All Student With Gpa More Than 3");
            WriteLine("5   ==>>           To Get All Instructor in Spicified Department");
            WriteLine("6   ==>            To Get All Instructor With Salary More Than 5000");
            WriteLine("7   ==>>           To Get All Technition in Spicified Department");
            WriteLine("8   ==>            To Back");
            WriteLine();
            WriteLine("==> ***************************** Enter Your Choice ************************************");
        }
        public static void ClearMinue()
        {
            WriteLine();
            WriteLine("1   ==>> To Clear Student    List ");
            WriteLine("1   ==>> To Clear Instructor List ");
            WriteLine("1   ==>> To Clear Technician List ");
            WriteLine("4   ==>  To Back");
        }


    }
}
