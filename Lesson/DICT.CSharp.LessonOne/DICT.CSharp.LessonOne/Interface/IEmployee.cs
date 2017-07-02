using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICT.CSharp.LessonOne.Model
{
    interface IEmployee
    {
        int EmployeeId { get; set; }
        string DoTask();
    }
}
