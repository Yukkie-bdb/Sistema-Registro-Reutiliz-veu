﻿using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;

namespace RegisterTest.Models
{
    public class RegisterModelSimples
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string? ReturnUrl { get; internal set; }
    }
}
