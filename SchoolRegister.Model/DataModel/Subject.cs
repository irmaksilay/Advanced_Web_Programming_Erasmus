using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolRegister.Model.DataModel;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolRegister.Model.DataModels
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        
        [Required] 
        public string Name { get; set; }
        
        public string Description { get; set; }
        public virtual IList<SubjectGroup> SubjectGroups { get; set; }
        
        public virtual Teacher? Teacher { get; set; }
        [ForeignKey("Teacher")]
        public virtual int? TeacherId { get; set; }
        
        public virtual IList<Grade> Grades { get; set; }
        public Subject(){} 
    }
}