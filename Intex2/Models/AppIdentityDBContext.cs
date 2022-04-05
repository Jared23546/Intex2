using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Intex2.Models
{
    public class AppIdentityDBContext : IdentityDbContext<IdentityUser>
    {


        public AppIdentityDBContext(DbContextOptions options) : base(options)
        {

        }
    }
}


//namespace Advanced.Models
//{
//    public class IdentityContext : IdentityDbContext<IdentityUser>
//    {
//        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options) { }
//    }
//}