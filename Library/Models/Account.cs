using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models {
    public class Account {
        public int AccountId { get; set; }
        public int CustomerId { get; set; }
        public int OpeningBalance { get; set; }
        public string Status { get; set; }
        public string account_type { get; set; }

        public DateTime CreateDate { get; set; }

    }
}