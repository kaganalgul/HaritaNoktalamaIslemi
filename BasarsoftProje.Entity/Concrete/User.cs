using BasarsoftProje.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasarsoftProje.Entity
{
    public class User : IBaseEntity
    {
        public int Number { get; set; }

        public string Username { get; set; }
    }
}
