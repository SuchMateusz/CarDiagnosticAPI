using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDiagnostic.Domain.Entities
{
    public class OwnerVehicle : Person
    {
        public int NumberOfRepairs { get; set; }

        public uint Discount { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}