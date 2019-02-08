using System;
using System.Collections.Generic;

namespace CodingChallenge.Models
{
    public partial class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CompanyId { get; set; }
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }

        public Company Company { get; set; }
    }
}
