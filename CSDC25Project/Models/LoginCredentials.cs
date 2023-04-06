using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSDC25Project.Models
{
    public class LoginCredentials
    {

        public string User_primary_id { get; set; }
        public int Role_id { get; set; }
        public string User_name { get; set; }
        public string User_Password { get; set; }
        public int Login_Attempts { get; set; }
    }
}