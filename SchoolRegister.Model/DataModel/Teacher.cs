using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolRegister.Model.DataModels;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace SchoolRegister.Model.DataModel
{
    public class Teacher
    {
        public virtual IList<Subject> Subjects { get; set; }
        
        [Required] 
        public string Title { get; set; }
        Teacher(){}
    }
}