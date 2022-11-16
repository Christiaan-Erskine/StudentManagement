using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Classes
{
    internal class Student
    {
        public Student( string name, string surname, string image, DateTime dOB, string gender, string phone, string address, string moduleCode)
        {
            Name = name;
            Surname = surname;
            Image = image;
            DOB = dOB;
            Gender = gender;
            Phone = phone;
            Address = address;
            ModuleCode = moduleCode;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ModuleCode { get; set; }
        

    }
}
