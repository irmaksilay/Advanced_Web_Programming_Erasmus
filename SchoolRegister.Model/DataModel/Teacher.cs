using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolRegister.Model.DataModels;

namespace SchoolRegister.Model.DataModel
{
    public class Teacher
    {
        public virtual IList<Subject> Subjects { get; set; }
        public string Title { get; set; }
        Teacher(){}
    }
}