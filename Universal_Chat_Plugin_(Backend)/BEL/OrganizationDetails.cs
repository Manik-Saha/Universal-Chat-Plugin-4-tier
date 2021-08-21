using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class OrganizationDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Username { get; set; }
        public ICollection<PaymentModel> Payments { get; set; }

    }
}
