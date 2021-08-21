using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class AddAdminModel
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public string Addresss { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public System.DateTime JoiningDate { get; set; }
        public string Marital_status { get; set; }
        public string Blood_group { get; set; }
        public int Salary { get; set; }
    }
}
