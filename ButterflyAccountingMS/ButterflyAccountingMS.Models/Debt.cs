using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ButterflyAccountingMS.Models
{
    public class Debt
    {
        [Key]
        public string DebtId { get; set; }

        [Required,StringLength(512)]
        public string Description { get; set; }

        public int DebtNumber { get; set; }

        public decimal FullAmount { get; set; }

        public DateTime Date { get; set; }

        public bool IsFinished { get; set; }

        //Relational entity

        public virtual List<DebtPayment> DebtPayments { get; set; }

    }
}
