using System;
using System.Collections.Generic;

namespace PIZZAPORTAL.Models
{
    public partial class Customer
    {
        public int IdCustomer { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public decimal? Phone { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public decimal? Buildingno { get; set; }
        public decimal? Flatno { get; set; }
    }
}
