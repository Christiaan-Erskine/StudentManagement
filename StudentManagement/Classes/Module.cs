using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Classes
{
    internal class Module
    {
        public string ModuleCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Module(string moduleCode, string name, string description)
        {
            ModuleCode = moduleCode;
            Name = name;
            Description = description;
        }
    }
}
