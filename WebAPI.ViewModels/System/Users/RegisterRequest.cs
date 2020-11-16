using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.ViewModels.System.Users
{
    public class RegisterRequest
    {
        public string firstName { get; set; }

        public string lastName { get; set; }

        public DateTime birthday { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
