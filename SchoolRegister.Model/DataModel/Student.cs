using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModel
{
    public class Student
    {
        public Group Group { get; set; }
        public int? GroupId { get; set; }
        public virtual IList<Grade> Grades { get; set; }
        public Parent Parent { get; set; }
        public int? ParentId { get; set; }
        public double AverageGrade { get; }
        public virtual IDictionary<string,double> AverageGradePerSubject { get;}
        public virtual IDictionary<string,List<GradeScale>> GradesPerSubject { get; }
        Student(){}

    }
}