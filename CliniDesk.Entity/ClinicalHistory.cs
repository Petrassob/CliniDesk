using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniDesk.Entity
{
    internal class ClinicalHistory
    {
        public int Id { get; set; }
        public string PatientId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Notes { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
    }
}
