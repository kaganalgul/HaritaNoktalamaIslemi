using BasarsoftProje.Business.Abstract;
using BasarsoftProje.Business.Helpers;
using BasarsoftProje.Entity;
using BasarsoftProje.Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasarsoftProje.Business.Concrete
{
    public class PointManager : IPointService
    {
        public List<Point> GetPoints()
        {
            InfoManager infoManager = new InfoManager();
            List<UserLocationDTO> userInfoList = new List<UserLocationDTO>();
            List<Point> points = new List<Point>();
            userInfoList = infoManager.SplitUserInfoList();

            foreach (var item in userInfoList)
            {
                Point point = new Point();
                point.Xaxis = item.Point.Xaxis;
                point.Yaxis = item.Point.Yaxis;

                points.Add(point);
            }
            return points;
        }
    }
}
