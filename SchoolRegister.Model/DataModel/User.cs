using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SchoolRegister.Model.DataModels
{
public class User : IdentityUser<int>
{
public string FirstName { get; set; } = default!;
public string LastName { get; set; } = default!;
public DateTime RegistrationDate { get; set; }
}
}