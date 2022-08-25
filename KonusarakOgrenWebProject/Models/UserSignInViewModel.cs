﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgrenWebProject.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage="Lütfen kullanıcı adını giriniz.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        public string Password { get; set; }

    }
}
