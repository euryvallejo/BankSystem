using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models {
    public class Transaction {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreateDate { get; set; }

    }
}