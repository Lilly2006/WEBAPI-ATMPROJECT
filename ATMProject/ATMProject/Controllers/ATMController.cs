using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATMProject.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ATMProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ATMController : ControllerBase
    {
        private readonly ATMDbContext atmdbcontext;
        public ATMController(ATMDbContext _atmDbContext)
        {
            atmdbcontext = _atmDbContext;
        }
        [HttpGet]
        public IEnumerable<CustomerDetails> GetCustomerDetails()
        {
            return atmdbcontext.customerDetails.ToList();
        }
        [HttpGet("GetAccountNumber")]
        public CustomerDetails GetAccountNumber(long AccountNumber)
        {
            return atmdbcontext.customerDetails.Find(AccountNumber);
        }
        [HttpPost("InsertCustomer")]
        public IActionResult InsertCargo([FromBody] CustomerDetails customerDetails)
        {
            if (customerDetails.AccountNumber.ToString() != "")
            {
                atmdbcontext.customerDetails.Add(customerDetails);
                atmdbcontext.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut("UpdateCustomer")]
        public IActionResult UpdateCustomer([FromBody] CustomerDetails customerDetails)
        {
            if (customerDetails.AccountNumber.ToString() != "")
            {
                atmdbcontext.Entry(customerDetails).State = EntityState.Modified;
                atmdbcontext.SaveChanges();
                return Ok("Customer Details updated successfully!");
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete("DeleteCustomer")]
        public IActionResult DeleteCustomer(long AccountNumber)
        {
            var result = atmdbcontext.customerDetails.Find(AccountNumber);
            atmdbcontext.customerDetails.Remove(result);
            atmdbcontext.SaveChanges();
            return Ok("Deleted Successfully");

        }
    }
}
