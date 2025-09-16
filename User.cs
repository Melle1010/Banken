using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    public class User
    {


        public int Id { get; set; }
        public required string Username { get; set; }
        public required string PinCode { get; set; }
        public bool IsAdmin { get; set; }
        public List<Account> Accounts { get; set; }


    }
}
