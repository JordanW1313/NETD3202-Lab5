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
    // Product class
    public class Product
    {

        // Data member declaration
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SellerID { get; set; }
        public double ProductPrice { get; set; }
        public string ProductCondition { get; set; }
        public string ProductDescription { get; set; }

        //public Product(int id, string name, User seller, double price, string condition, string description) 
        //{
        //    ProductID = id;
        //    ProductName = name;
        //    UserID = seller;
        //    ProductPrice = price;
        //    ProductCondition = condition;
        //    ProductDescription = description;
        //}
    }
}
