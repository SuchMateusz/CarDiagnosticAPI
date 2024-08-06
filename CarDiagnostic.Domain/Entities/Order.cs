using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDiagnostic.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string DescriptionOrder { get; set; }
        public string ChangePart { get; set; }
        public Vehicle Vehicle { get; set; }
        public ICollection<FaultVehicle> FaultVehicles { get; set; }
        public DateTime CreateDataTime { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }
    }
}