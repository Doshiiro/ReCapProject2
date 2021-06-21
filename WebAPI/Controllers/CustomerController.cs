using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        ICustomerService _customerservice;

        public CustomerController(ICustomerService customerservice)
        {
            _customerservice = customerservice;
        }

        [HttpGet("getallcustomer")]
        public IActionResult GetAll()
        {
            var result = _customerservice.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcustomerbyid")]
        public IActionResult GetById(int id)
        {
            var result =_customerservice.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addcustomer")]
        public IActionResult Add(Customer customer)
        {
            var result = _customerservice.Add(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deletecustomer")]
        public IActionResult Delete(Customer customer)
        {
            var result = _customerservice.Delete(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("updatecustomer")]
        public IActionResult Update(Customer customer)
        {
            var result = _customerservice.Update(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
