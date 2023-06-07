using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models {
    public class BalanceAccount {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int LastTransaction { get; set; }
        public decimal Balance { get; set; }
    }
}