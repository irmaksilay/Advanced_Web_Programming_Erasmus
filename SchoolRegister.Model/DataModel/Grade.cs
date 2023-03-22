using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolRegister.Model.DataModels;

namespace SchoolRegister.Model.DataModel
{
    public class Grade
    {
        public DateTime DateOFIssue { get; set; }
        public GradeScale GradeValue { get; set; }
        public Subject Subject { get; set; }
        public int SubjectId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        Grade(){}
    }
}