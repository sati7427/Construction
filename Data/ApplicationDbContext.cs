using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Microsoft.AspNetCore.Identity;

namespace ConstructionCoreApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public class ApplicationUser : IdentityUser
        {
            public string Name { get; set; }
            public string Designation { get; set; }
            public int AMobile { get; set; }
            public string Location { get; set; }
        }
    }
}
