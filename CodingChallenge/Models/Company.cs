using System;
using System.Collections.Generic;

namespace CodingChallenge.Models
{
    public partial class Company
    {
        public Company()
        {
            Employee = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public int? CompanyType { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Name { get; set; }

        public Categories Categories { get; set; }
        public ICollection<Employee> Employee { get; set; }
    }
}
