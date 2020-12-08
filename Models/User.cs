/********
 * Name: Jordan Wriker
 * Date: December 7, 2020
 * Assignmnent: Lab5
 * 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NETD_Lab5.Models
{
    // User class
    public class User
    {
        // Data Member Declaration

        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserAddress { get; set; }
    }
}
