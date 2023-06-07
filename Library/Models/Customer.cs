using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models {
    public class Customer {
        public int customerId { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string city { get; set; }
        public string mobileNumber { get; set; }
        public DateTime createDate { get; set; }

    }
}