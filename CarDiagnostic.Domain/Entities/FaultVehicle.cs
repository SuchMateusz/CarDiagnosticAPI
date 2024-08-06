using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDiagnostic.Domain.Entities
{
    public class FaultVehicle
    {
        public int Id { get; set; }

        public string FaultCodeName { get; set; }

        public string FaultCodeDescription { get; set;}

        public string FaultMessage { get; set;}

        public string FaultType { get; set;}

        public string RepairDescription { get; set;}

        public string ChangePart { get; set;}
    }
}