using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDiagnostic.Domain.Entities
{
    public class PersonAddress
    {
        public string BuildingNumber { get; set; }

        public string Street { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public int PersonId { get; set; }

        public Person Person { get; set; }
    }
}
