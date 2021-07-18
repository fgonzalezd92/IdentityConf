using Escuela.Core.Models.Auth;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Escuela.Pesistence
{
    public class ApplicationDbContext: IdentityDbContext<AppUser>
    {
         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        
        }
    }
}
