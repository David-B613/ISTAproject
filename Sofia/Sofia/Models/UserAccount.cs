using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Sofia.Models
{
    public class UserAccount
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage ="First Name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Last Name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="E-Mail address is required")]
        [RegularExpression(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$")]
        public string Email { get; set; }

        [Required(ErrorMessage ="User Name is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]

        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Please confirm your password.")]
        [DataType(DataType.Password)]

        public string ConfirmPassword { get; set; }


    }
}