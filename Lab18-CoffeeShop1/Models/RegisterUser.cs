﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab18_CoffeeShop1.Models
{
    public class RegisterUser
    {
        [Required(ErrorMessage ="First name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Last name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required"), EmailAddress(ErrorMessage ="Invalid email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required"), RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$",
            ErrorMessage ="Invalid Password: Must contain 1 capital letter, 1 number, and at least 8 characters")]
        public string Password { get; set; }
    }
}