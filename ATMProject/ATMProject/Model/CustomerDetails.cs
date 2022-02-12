using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATMProject.Model
{
    public class CustomerDetails
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public int Contact { get; set; }
        public int CardNumber { get; set; }
        public int PinNumber { get; set; }
        public string AccountType { get; set; }
        [Key]
        public int AccountNumber { get; set; }
        public double Balance { get; set; }


    }
}
