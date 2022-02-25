using BasarsoftProje.Business.Abstract;
using BasarsoftProje.Business.Helpers;
using BasarsoftProje.Entity;
using BasarsoftProje.Entity.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasarsoftProje.Business.Concrete
{
    public class InfoManager : IInfoService
    {
        public void TakeUserInfo(UserLocationDTO userLocationDTO)
        {
            string fullPath = ReadInformationsFromText.GetPath();
            try
            {
                string userLocationString = $"{userLocationDTO.Username}-{userLocationDTO.UserNumber}-({userLocationDTO.Point.Xaxis},{userLocationDTO.Point.Yaxis})";

                if (!File.Exists(fullPath))
                {
                    using (StreamWriter sw = File.CreateText(fullPath))
                    {
                        sw.WriteLine(userLocationString);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(fullPath))
                    {
                        sw.WriteLine(userLocationString);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public List<UserLocationDTO> SplitUserInfoList()
        {
            List<string> listForHtml = ReadInformationsFromText.ReadInfoFromText();
            List<UserLocationDTO> userLocationDTOs = new List<UserLocationDTO>();
            foreach (var item in listForHtml)
            {
                UserLocationDTO userLocationDtoForSplit = new UserLocationDTO();

                List<string> itemList = item.Split("-").ToList();

                string locationString = itemList[2].Substring(1, itemList[2].Length - 2);
                List<string> locationList = locationString.Split(",").ToList();

                userLocationDtoForSplit.Username = itemList[0];
                userLocationDtoForSplit.UserNumber = int.Parse(itemList[1]);
                userLocationDtoForSplit.Point.Xaxis = locationList[0];
                userLocationDtoForSplit.Point.Yaxis = locationList[1];

                userLocationDTOs.Add(userLocationDtoForSplit);
            }
            return userLocationDTOs;
        }

        
    }

}

