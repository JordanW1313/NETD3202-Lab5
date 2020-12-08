/********
 * Name: Jordan Wriker
 * Date: December 7, 2020
 * Assignmnent: Lab5
 * 
 ********/

using System;

namespace NETD_Lab5.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
