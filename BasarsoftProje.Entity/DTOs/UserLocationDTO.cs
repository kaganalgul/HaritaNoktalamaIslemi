using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasarsoftProje.Entity.DTOs
{
    public class UserLocationDTO
    {
        public string Username { get; set; }

        public int UserNumber { get; set; }

        public Point Point { get; set; } = new Point();
    }
}
