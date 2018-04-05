using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class UserProfile
    {
        public int UserProfileId { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public string FirstName { get; set; }
        public string LstName { get; set; }
        public string Login { get; set; }
        public string  Password { get; set; }
    }
}
