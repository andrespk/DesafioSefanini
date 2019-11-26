using domain.Entities;
using System;

namespace domain.DTOs
{
    public class CustomerDTO : Customer
    {
        public DateTime UntilLastPurchase { get; set; }
    }
}