using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class PaymentDetails
    {
        public string Payment_type { get; set; }
        public string Payment_status { get; set; }
        public int Card_no { get; set; }
        public int CVC { get; set; }
        public System.DateTime Payment_date { get; set; }
        public int Total_amount { get; set; }
        public int Paid_amount { get; set; }
        public int Due_amount { get; set; }
        public OrganizationModel Organization { get; set; }
    }
}
