using BasarsoftProje.Entity;
using BasarsoftProje.Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasarsoftProje.Business.Abstract
{
    public interface IInfoService
    {
        public void TakeUserInfo(UserLocationDTO userLocationDTO);

        public List<UserLocationDTO> SplitUserInfoList();
    }
}
