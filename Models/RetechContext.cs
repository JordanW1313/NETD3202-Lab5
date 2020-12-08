/********
 * Name: Jordan Wriker
 * Date: December 7, 2020
 * Assignmnent: Lab5
 * 
 ********/

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETD_Lab5.Models
{

    // ReTech Context class
    public class RetechContext : DbContext
    {
        public RetechContext(DbContextOptions<RetechContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
