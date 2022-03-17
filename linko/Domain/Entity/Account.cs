using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace linko.Domain
{
    public class Account : MasterEntity
    {

        public int UserId { set; get; }
        public string AccountName { set; get; }
        public string AccountType { set; get; }
        public string Prefix { set; get; }
        public string link { set; get; }
        public object DeleteDate { get; internal set; }
    }
}
