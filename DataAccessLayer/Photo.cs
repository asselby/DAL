using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class Photo
    {
        public int PhotoId { get; set; }
        public string Picture { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
