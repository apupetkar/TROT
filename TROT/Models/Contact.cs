using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TROT.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Message { get; set; }
    }
}