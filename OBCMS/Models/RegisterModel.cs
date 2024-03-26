using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBCMS.Models
{
    public class RegisterModel
    {
        

        public string? FIRST_NAME {get; set; } 
        public string? LAST_NAME {get; set; } 
        public string? USER_NAME {get; set; } 
        public string? PASSWORD {get; set; } 
        public string? CONFIRM_PASSWORD {get; set; }
        public string? EMAIL{get; set; } 
        public string? PHONENUMBER {get; set; } 
        public string? ACCOUNT_TYPE {get; set; } 

    }
}