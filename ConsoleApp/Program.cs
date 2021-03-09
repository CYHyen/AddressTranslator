using AddressTranslator;
using System;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //台北市南港區三重路66號14樓
            string address = @"台中市東勢區本街&本街1巷";
            AddressRegex target = new AddressRegex(address);
            Console.WriteLine(target.OrginalAddress);
            Console.WriteLine("市:" + target.City);
            Console.WriteLine("區:" + target.District);
            Console.WriteLine("里:" + target.Village);
            Console.WriteLine("鄰:" + target.Neighborhood);
            Console.WriteLine("路:" + target.Street);
            Console.WriteLine("巷:" + target.Lane);
            Console.WriteLine("弄:" + target.Alley);
            Console.WriteLine("號:" + target.Number);
            Console.WriteLine("樓:" + target.Floor);

            string myaddress = @"台北市中正區羅斯福路四段136巷6弄6-1號";
            AddressRegex _target = new AddressRegex(myaddress);
            Console.WriteLine(_target.OrginalAddress);
            Console.WriteLine("市:" + _target.City);
            Console.WriteLine("區:" + _target.District);
            Console.WriteLine("里:" + _target.Village);
            Console.WriteLine("鄰:" + _target.Neighborhood);
            Console.WriteLine("路:" + _target.Street);
            Console.WriteLine("巷:" + _target.Lane);
            Console.WriteLine("弄:" + _target.Alley);
            Console.WriteLine("號:" + _target.Number);
            Console.WriteLine("樓:" + _target.Floor);

            //宜蘭縣蘇澳鎮區界路
            string _myaddress = @"宜蘭縣蘇澳鎮區界路6-1號";
            AddressRegex __target = new AddressRegex(_myaddress);
            Console.WriteLine(__target.OrginalAddress);
            Console.WriteLine("市:" + __target.City);
            Console.WriteLine("區:" + __target.District);
            Console.WriteLine("里:" + __target.Village);
            Console.WriteLine("鄰:" + __target.Neighborhood);
            Console.WriteLine("路:" + __target.Street);
            Console.WriteLine("巷:" + __target.Lane);
            Console.WriteLine("弄:" + __target.Alley);
            Console.WriteLine("號:" + __target.Number);
            Console.WriteLine("樓:" + __target.Floor);

        }
    }

}
