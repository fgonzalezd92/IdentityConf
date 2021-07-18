using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Escuela.Core.Models.Auth
{
    public class AppUser : IdentityUser
    {
        [Display(Name="Nombre completo")]
        public string FullName { get; set; }
        public UserStatus Status { get; set; }
    }

    public enum UserStatus
    {
        Activo = 1,
        Inactivo = 0
    }
}
