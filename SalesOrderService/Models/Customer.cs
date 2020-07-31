using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesOrderService.Models {
    public class Customer {

        //[]
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public decimal Sales { get; set; }

        public Customer() {

        }

    }
}
