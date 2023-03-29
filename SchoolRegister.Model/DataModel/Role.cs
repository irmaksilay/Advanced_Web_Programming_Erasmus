using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SchoolRegister.Model.DataModel
{
    public class Role : IdentityRole<int>
    {   
        [Key]
        public RoleValue RoleValue { get; set; }

        Role(){}
        Role(string name,RoleValue rolevalue){}
    }
}