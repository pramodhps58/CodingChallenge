using System;
using System.Collections.Generic;

namespace CodingChallenge.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Company = new HashSet<Company>();
        }

        public int Id { get; set; }
        public string Category { get; set; }

        public ICollection<Company> Company { get; set; }
    }
}
