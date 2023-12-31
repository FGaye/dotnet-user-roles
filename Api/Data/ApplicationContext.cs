using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class ApplicationContext : IdentityDbContext<User>
    {
         public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
    }
}