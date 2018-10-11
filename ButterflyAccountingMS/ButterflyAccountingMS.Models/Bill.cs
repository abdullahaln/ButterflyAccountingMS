using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ButterflyAccountingMS.Models
{
    public class Bill
    {
        [Key]
        public string BillId { get; set; }

        [Required, StringLength(512)]
        public string Description { get; set; }

        public string BillNumber { get; set; }

        public decimal FullAmount { get; set; }

        public DateTime Date { get; set; }

        public bool IsFinished { get; set; }

        //Relational entity

        public virtual List<Payment> Payments { get; set; }

        [Required]
        public virtual Customer Customer { get; set; }

        public string CustomerId { get; set; }

    }
}
