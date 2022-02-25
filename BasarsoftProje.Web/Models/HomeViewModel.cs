using BasarsoftProje.Entity;
using BasarsoftProje.Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasarsoftProje.Web.Models
{
    public class HomeViewModel
    {
        public UserLocationDTO userLocationDTOForPost { get; set; } = new UserLocationDTO();

        public List<UserLocationDTO> userLocationDTOList { get; set; } = new List<UserLocationDTO>();


    }
}
