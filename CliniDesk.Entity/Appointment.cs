using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniDesk.Entity
{
    internal class Appointment
    {
        public int Id { get; set; }
        public string PatientId { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public bool IsCompleted { get; set; }
    }
}
