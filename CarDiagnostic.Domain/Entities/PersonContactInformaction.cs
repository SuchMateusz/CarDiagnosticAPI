using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDiagnostic.Domain.Entities
{
    public class PersonContactInformaction
    {

        public string DirectPersonAddressEmail { get; set; }

        public string DirectPhoneNumber { get; set; }

        public int PersonRef { get; set; }

        public Person Person { get; set; }
    }
}
