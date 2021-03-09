using System;
using System.Text.RegularExpressions;

namespace AddressTranslator
{
    public class AddressRegex
    {

        public AddressRegex(string address)
        {
            this.OrginalAddress = address;
            this.ParseByRegex(address);
        }
        /// <summary>
        /// 縣市、包含一級行政區&二級行政區
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 鄉鎮市區 三級行政區
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// 村里
        /// </summary>
        public string Village { get; set; }

        /// <summary>
        /// 鄰
        /// </summary>
        public string Neighborhood { get; set; }

        /// <summary>
        /// 路街段道
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        ///巷 
        /// </summary>
        public string Lane { get; set; }

        /// <summary>
        /// 弄
        /// </summary>
        public string Alley { get; set; }
        /// <summary>
        /// 號
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// 樓
        /// </summary>
        public string Floor { get; set; }

        /// <summary>
        /// 剩下的地址
        /// </summary>
        public string Others { get; set; }
        /// <summary>
        /// 是否符合pattern規範
        /// </summary>
        public bool IsParseSuccessed { get; set; }
        /// <summary>
        /// 原始傳入的地址
        /// </summary>
        public string OrginalAddress { get; private set; }



        private void ParseByRegex(string address)
        {
            string strict_pattern = @"(?<City>(\S{2}[縣市]))(?<District>(\S{2}[鄉鎮市區]))(?<Village>\S+[村里])?(?<Neighborhood>\S+[鄰])?(?<Street>\S+[路道街段])?(?<Lane>\S+[巷])?(?<Alley>\S+[弄])?(?<Number>\S+[號])?(?<Floor>\S+[樓])?(?<Others>.+)?";
            string pattern = @"(?<City>\S+[縣市])(?<District>\S+?(市區|鎮區|鎮市|[鄉鎮市區]))(?<Village>\S+[村里])?(?<Neighborhood>\S+[鄰])?(?<Street>\S+[路道街段])?(?<Lane>\S+[巷])?(?<Alley>\S+[弄])?(?<Number>\S+[號])?(?<Floor>\S+[樓])?(?<Others>.+)?";
            Match match = Regex.Match(address, strict_pattern);

            if (match.Success)
            {
                this.IsParseSuccessed = true;
                this.City = match.Groups["City"].ToString();
                this.District = match.Groups["District"].ToString();
                this.Village = match.Groups["Village"].ToString();
                this.Neighborhood = match.Groups["Neighborhood"].ToString();
                this.Street = match.Groups["Street"].ToString();
                this.Lane = match.Groups["Lane"].ToString();
                this.Alley = match.Groups["Alley"].ToString();
                this.Number = match.Groups["Number"].ToString();
                this.Floor = match.Groups["Floor"].ToString();
                this.Others = match.Groups["Others"].ToString();
                return;

            }
            match = Regex.Match(address, pattern);
            if (match.Success)
            {
                this.IsParseSuccessed = true;
                this.City = match.Groups["City"].ToString();
                this.District = match.Groups["District"].ToString();
                this.Village = match.Groups["Village"].ToString();
                this.Neighborhood = match.Groups["Neighborhood"].ToString();
                this.Street = match.Groups["Street"].ToString();
                this.Lane = match.Groups["Lane"].ToString();
                this.Alley = match.Groups["Alley"].ToString();
                this.Number = match.Groups["Number"].ToString();
                this.Floor = match.Groups["Floor"].ToString();
                this.Others = match.Groups["Others"].ToString();
                return;

            }


        }
    }


}
