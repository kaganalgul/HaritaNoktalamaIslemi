using BasarsoftProje.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasarsoftProje.Entity
{
    public class Location : IBaseEntity
    {
        public Point Point { get; set; }
    }
}
