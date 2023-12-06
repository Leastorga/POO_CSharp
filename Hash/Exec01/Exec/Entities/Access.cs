using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exec01.Entities
{
    class Access
    {

        public string Username { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Access))
            {
                return false;
            }
            Access other = obj as Access;
            return Username.Equals(other.Username);
        }
    }
}
