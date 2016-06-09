using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TROT.Models
{
    public enum UserType { Agent, Investor, TradePartner, Trustee, DerivativeMember, VentureFun, RealtyMarketing  }
    public class Agent
    {
        public int AgentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public UserType userType;
        public string Country { get; set; }

        public string State { get; set; }
        public string Zip { get; set; }

        //[DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}