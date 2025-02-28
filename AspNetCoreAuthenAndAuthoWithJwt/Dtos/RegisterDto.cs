﻿using System.ComponentModel.DataAnnotations;

namespace AspNetCoreAuthenAndAuthoWithJwt.Dtos
{
    public class RegisterDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
