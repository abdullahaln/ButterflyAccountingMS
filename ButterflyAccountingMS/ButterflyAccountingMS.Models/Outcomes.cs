using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ButterflyAccountingMS.Models
{
    public class Outcomes
    {
        [Key]
        public string OutcomesId { get; set; }

        public decimal Amount { get; set; }

        [Required,StringLength(512)]
        public string Description { get; set; }

        public DateTime Date { get; set; }

        public bool IsPaid { get; set; }

        public DateTime? Paymentdate { get; set; }

        public string DebtNumber { get; set; }    //referance type

        //Relational entity

        [Required]
        public virtual User User { get; set; }

        public string UserId { get; set; }
    }
}
