using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela.Core.ViewModels
{
    public class User
    {
        [Required]
        [Display(Name="Nombre completo")]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Email no valido")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
