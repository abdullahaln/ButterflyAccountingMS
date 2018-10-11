using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ButterflyAccountingMS.Models
{
    public class Draw
    {
        [Key]
        public string DrawId { get; set; }

        [Required, StringLength(512)]
        public string Description { get; set; }

        [Required, StringLength(256)]
        public string To { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }


    }
}
