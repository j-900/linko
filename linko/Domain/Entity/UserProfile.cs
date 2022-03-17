using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linko.Domain
{
    public class UserProfile : MasterEntity
    {
      
        public string Username { set; get; }
        public string Password { set; get; }
        public string Email { set; get; }
        public int AccountNo { set; get; }
        public string FallName { set; get; }
        public string  ProfileImg { set; get; }
        public int Bio { set; get; }
        public bool IsDeleted { set; get; }
        public DateTime LastAccessDate { set; get; }

        public int DeleteAfterperiod { set; get; }

        public List<Account> Accounts { set; get; }
        public object DeleteDate { get; internal set; }
    }
}
