using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ButterflyAccountingMS.Models
{
    public class User
    {
        [Key]
        public string UserId { get; set; }

        [StringLength(25),Required]
        public string FirstName { get; set; }

        [StringLength(25), Required]
        public string LastName { get; set; }

        [StringLength(25), Required]
        public string PhoneNumber { get; set; }

        [StringLength(50), Required]
        public string Email { get; set; }

        [StringLength(256), Required]
        public string  Address { get; set; }

        [StringLength(512), Required]
        public string Description { get; set; }

        public bool IsBlocked { get; set; }

        //Relational entity
        public virtual List<Incomes> Incomess { get; set; }

        public virtual List<Outcomes> Outcomess { get; set; }



    }
}
