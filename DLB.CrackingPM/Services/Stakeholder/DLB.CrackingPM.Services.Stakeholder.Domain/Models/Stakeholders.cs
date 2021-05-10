using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLB.CrackingPM.Services.Stakeholder.Domain.Models
{
    public class Stakeholders
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int InfluenceOther { get; set; }
        public int DirectResourceControl { get; set; }
        public int InterestLevelTechnical { get; set; }
        public int InterestLevelNonTechnical { get; set; }
        public int PowerInProduct { get; set; }
        public int Knowledge { get; set; }
        public int Accessibility { get; set; }

    }
}
