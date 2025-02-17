using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Backend_API.Models;
using Microsoft.AspNetCore.Identity;

namespace Backend_API.Areas.Identity.Data;

// Add profile data for application users by adding properties to the SiteUser class
public class SiteUser : IdentityUser
{
    //public virtual ICollection<Content> Posts { get; set; }
}

