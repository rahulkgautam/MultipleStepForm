using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Multi_StepRegistrationForm.Models
{
    public class FormDetails
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}