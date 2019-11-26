using domain.DTOs;
using domain.Entities;
using System.Collections.Generic;

namespace frontend.Models
{
    public class CustomerViewModel
    {
        public CustomerDTO Filter { get; set; }
        public IEnumerable<Customer> List { get; set; }
    }
}