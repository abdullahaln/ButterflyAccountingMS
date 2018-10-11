using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ButterflyAccountingMS.Models
{
    public class Incomes
    {
        [Key]
        public string IncomesId { get; set; }

        public decimal Amount { get; set; }

        [StringLength(512),Required]
        public string Description { get; set; }

        public DateTime Date { get; set; }

        public DateTime? PaymentDate { get; set; }

        public bool IsPaid { get; set; }

        public string BillNumber { get; set; }

        //Relational entity

        [Required]
        public virtual User User { get; set; }

        public string UserId { get; set; }
    }
}
