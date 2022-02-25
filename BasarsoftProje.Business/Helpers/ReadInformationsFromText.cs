using BasarsoftProje.Entity.DTOs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasarsoftProje.Business.Helpers
{
    public static class ReadInformationsFromText
    {
        public static List<string> ReadInfoFromText()
        {
            List<string> userInfoList;
            List<string> empty = new List<string>();

            string fullPath = GetPath();

            userInfoList = new List<string>();

            if (!File.Exists(fullPath))
            {
                return empty;
            }
            else
            {
                using (StreamReader sr = File.OpenText(fullPath))
                {
                    string row = string.Empty;

                    while ((row = sr.ReadLine()) != null)
                    {
                        userInfoList.Add(row);
                    }
                }
            return userInfoList;
            }            
        }

        public static string GetPath()
        {
            string folder = Directory.GetCurrentDirectory();

            string fileName = "BasarsoftProje.txt";

            string fullPath = folder + fileName;

            return fullPath;
        }
    }
}
