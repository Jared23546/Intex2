using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Intex2.Models
{
    public class ListModel
    {
        public UserManager<IdentityUser> UserManager;
        public ListModel(UserManager<IdentityUser> userManager)
        {
            UserManager = userManager;
        }
        public IEnumerable<IdentityUser> Users { get; set; }
        public void OnGet()
        {
            Users = UserManager.Users;
        }
    }
}
