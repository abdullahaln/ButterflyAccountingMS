using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ButterflyAccountingMS.Models
{
    public class Customer
    {
        [Key]
        public string CustomerId { get; set; }

        [Required,StringLength(25)]
        public string FirstName { get; set; }

        [Required,StringLength(25)]
        public string LastName { get; set; }

        [Required,StringLength(40)]
        public string StoreName { get; set; }

        public DateTime Birthday { get; set; }

        [Required, StringLength(30)]
        public string City { get; set; }

        [Required, StringLength(512)]
        public string Address { get; set; }

        [Required, StringLength(50)]
        public string Phone { get; set; }

        [Required, StringLength(50)]
        public string Email { get; set; }

        [Required, StringLength(50)]
        public string Website { get; set; }

        //Relational entity

        public virtual List<Bill> Bills { get; set; }


    }
}
