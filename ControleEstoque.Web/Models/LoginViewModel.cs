using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleEstoque.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o usuário!")]
        [Display(Name="User:")]
        public string User { get; set; }

        [Required(ErrorMessage = "Informe a senha!")]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Remeber me")]
        public bool LembrarMe { get; set; }
    }
}