﻿using Microsoft.AspNetCore.Identity;
namespace argeson.Models
{
    public class AppUser: IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
