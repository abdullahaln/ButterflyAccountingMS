using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ButterflyAccountingMS.Models
{
    public class Payment
    {
        [Key]
        public string PaymentId { get; set; }

        public DateTime Date { get; set; }

        [Required, StringLength(512)]
        public string Description { get; set; }

        public decimal Amount { get; set; }

        public bool IsPaid { get; set; }

        public DateTime? PaymentDate { get; set; }

        public DateTime? NotifyPaymentDate { get; set; } //nullable

        //Relational entity

        [Required]
        public virtual Bill Bill { get; set; }

        public string BillId { get; set; }
    }
}
