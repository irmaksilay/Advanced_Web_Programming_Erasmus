using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModel
{
    public class Role
    {
        public RoleValue RoleValue { get; set; }

        Role(){}
        Role(string name,RoleValue rolevalue){}
    }
}