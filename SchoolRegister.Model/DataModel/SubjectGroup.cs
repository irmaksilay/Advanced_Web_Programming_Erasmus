using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolRegister.Model.DataModels;

using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolRegister.Model.DataModel
{
   
    public class SubjectGroup
    {
        public virtual Subject? Subject { get; set; }
        [ForeignKey("Subject")]
       
       
        public virtual int? SubjectId { get; set; }
        
        public virtual Group Group { get; set; }
        public int GroupId { get; set; }
        SubjectGroup(){}
    }
}