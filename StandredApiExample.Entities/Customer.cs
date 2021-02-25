using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StandredApiExample.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Customer> Customers { set; get; }
    }
}
