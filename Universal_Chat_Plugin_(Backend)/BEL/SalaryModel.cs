using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class SalaryModel
    {
        public int Id { get; set; }
        public string Paid_Month { get; set; }
        public string Salary_status { get; set; }
        public int Card_no { get; set; }
        public int CVC { get; set; }
        public System.DateTime Payment_date { get; set; }
        public int Total_Salary { get; set; }
        public int Paid_Salary { get; set; }
        public int Due_Salary { get; set; }
        public int AdminId { get; set; }
    }
}
