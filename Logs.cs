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

        public string UserName { get; set; }

        public string UserEmail { get; set; }

        public string LogType { get; set; }

        public DateTime DateTime { get; set; }

        public string AffectedTable { get; set; }
    }
}
