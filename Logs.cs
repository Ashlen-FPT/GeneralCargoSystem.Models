using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralCargoSystem.Models
{
    public  class Logs
    {
        public int Id { get; set; }

        public string UserName { get; set; } = string.Empty;

        public string UserEmail { get; set; } = string.Empty;

        public string LogType { get; set; } = string.Empty;

        public DateTime DateTime { get; set; }

        public string AffectedTable { get; set; } = string.Empty;

        public string? AdditionalData { get; set; }
    }
}
