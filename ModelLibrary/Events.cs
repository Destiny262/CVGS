using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class Events
    {
        public Events()
        {

        }

        public int eventId { get; set; }
        public DateTime time { get; set; }
        public int registeredMembersId { get; set; }
        public string description { get; set; }
    }
}
