using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolRegister.Model.DataModels;

using System.ComponentModel.DataAnnotations.Schema;


namespace SchoolRegister.Model.DataModel
{
    public class Grade
    {
        public DateTime DateOfIssue { get; set; }
        public GradeScale GradeValue { get; set; }
        
        public virtual Subject? Subject { get; set; }
        [ForeignKey("Grade")]
        public int? SubjectId { get; set; }
        
        public virtual Student? Student { get; set; }
        [ForeignKey("Student")]
        public int? StudentId { get; set; }

        
        Grade(){}
    }
}