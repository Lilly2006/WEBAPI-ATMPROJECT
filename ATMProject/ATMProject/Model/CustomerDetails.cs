using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATMProject.Model
{
    public class CustomerDetails
    {
        [Key]
        public long AccountNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public long Contact { get; set; }
        public long CardNumber { get; set; }
        public int PinNumber { get; set; }
        public string AccountType { get; set; }
       
        public double Balance { get; set; }


    }
}
