using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAndRegistration
{
    class paymenthistory
    {
        public override string ToString()
        {
            return invoiceDate;
        }

        public string Name { get; set; }
        public string Paid { get; set; }
        public string invoiceDate { get; set; }
        public string Amount { get; set; }
    }
}
