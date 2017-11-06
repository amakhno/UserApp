using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserApp.Models
{
    public class User
    {
        public bool isAuthorised { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}