using CarDiagnostic.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CarDiagnostic.Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public PersonName PersonName { get; set; }
        public ICollection<PersonContactInformaction> PersonContactInformaction { get; set; }
        public ICollection<PersonAddress> PersonAddressDetails { get; set; }

    }
}