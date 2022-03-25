using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FciManagementSystem
{
    public abstract  class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public Person()
        {
        
        }
        public override string ToString()
        {
            return
                string.Format("ID is : {0} \t Name is : {1} \t Age is : {2} \t Address is : {3} \t Gender is : {4}"
                , ID, Name, Age, Address, Gender);
        }

    }
}
