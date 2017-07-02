using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICT.CSharp.LessonOne.Model
{
    class Developer : IEmployee
    {
        public int EmployeeId { get; set; }

        public string DoTask()
        {
            return "From Developer";
        }
    }
}
