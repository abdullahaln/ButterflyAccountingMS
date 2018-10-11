using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ButterflyAccountingMS.Models
{
    public class DebtPayment
    {
        [Key]
        public string DebtPaymentId { get; set; }

        public DateTime Date { get; set; }

        [Required, StringLength(512)]
        public string Description { get; set; }

        public decimal Amount { get; set; }

        public bool IsPaid { get; set; }

        public DateTime? DebtPaymentDate { get; set; }

        public DateTime? NotifyDebtPaymentDate { get; set; }

        //Relational entity

        [Required]
        public virtual Debt Debt { get; set; }

        public string DebtId { get; set; }

    }
}
