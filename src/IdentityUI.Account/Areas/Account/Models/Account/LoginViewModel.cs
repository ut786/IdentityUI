﻿using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SSRD.IdentityUI.Account.Areas.Account.Models.Account
{
    public class LoginViewModel
    {
        [DisplayName("Username")]
        public string UserName { get; set; }
        public string Password { get; set; }
        [DisplayName("Remember me")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
        public bool RegistrationEnabled { get; set; }
        public bool PasswordRecoveryEnabled { get; set; }

        public string Error { get; set; }
        public List<AuthenticationScheme> ExternalLogins { get; set; }

        public LoginViewModel(string returnUrl, bool registrationEnabled, bool passwordRecoveryEnabled, string error, List<AuthenticationScheme> externalLogins)
        {
            ReturnUrl = returnUrl;
            RegistrationEnabled = registrationEnabled;
            PasswordRecoveryEnabled = passwordRecoveryEnabled;

            Error = error;

            ExternalLogins = externalLogins;
        }
    }
}
