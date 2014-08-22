using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Sample.Repository
{
   public class UserInfo
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string PhoneNo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
    }
}
