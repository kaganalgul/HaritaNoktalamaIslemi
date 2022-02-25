using BasarsoftProje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasarsoftProje.Business.Abstract
{
    public interface IPointService
    {
        public List<Point> GetPoints();
    }
}
