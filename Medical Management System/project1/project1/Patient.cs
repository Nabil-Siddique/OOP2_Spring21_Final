using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public class Patient
    {
        public int PatientID { get; set; }

        public int Serial { get; set; }
        public string  PatientName { get; set; }
        public string Address { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public long phone { get; set; }

        public string HostName { get; set; }
    }
}
