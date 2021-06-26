using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Data
{
    public class ApplicationDbcontext :DbContext
    {

        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options):base(options)
        {


        }

        public DbSet<Category> Category { get; set; }


        public DbSet<ApplicationType> ApplicationType { get; set; }
    }
}
