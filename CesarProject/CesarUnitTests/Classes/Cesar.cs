using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCesar.Classes
{
    class Cesar
    {
         Dictionary<int,string> mapRomanWithNumbers =
           new Dictionary<int, string>(){
                                  {1, "I"},
                                  {2, "II"},
                                  {3, "III"},
                                  {4, "IV"},
                                  {5, "V"},
                                  {6, "VI"},
                                  {7, "VII"},
                                  {8, "VIII"},
                                  {9, "IX"},
           };

        public string getRomanNumber(int number)
        {
        
            string strNumber = Convert.ToString(number);
            List<string> romanNumber = new List<string>{ };
            var intList = strNumber.Select(x => Convert.ToInt32(x.ToString())).ToList();
            if (number < 4000)
            {
                for (int i = intList.Count(); i > 0; i--)
                {
                    var intListNumber = intList.ElementAtOrDefault(i - 1);
                    if (i == intList.Count() && i != 0)
                    {
                        for (int y = 0; y < mapRomanWithNumbers.Count(); y++)
                        {
                            var keyMapRoman = mapRomanWithNumbers.ElementAt(y).Key;
                            if (intListNumber == keyMapRoman)
                            {
                                var valueMapRoman = mapRomanWithNumbers[y + 1];
                                romanNumber.Insert(0, valueMapRoman);
                            }
                        }
                    }
                    if (i == intList.Count - 1)
                    {
                        mapRomanWithNumbers =
                        new Dictionary<int, string>(){
                                  {1, "XX"},
                                  {2, "XX"},
                                  {3, "XXX"},
                                  {4, "XL"},
                                  {5, "L"},
                                  {6, "LX"},
                                  {7, "LXX"},
                                  {8, "LXXX"},
                                  {9, "XC"}, };

                        for (int y = 1; y < mapRomanWithNumbers.Count(); y++)
                        {
                            var keyMapRoman = mapRomanWithNumbers.ElementAt(y).Key;
                            if (intListNumber == keyMapRoman)
                            {
                                var valueMapRoman = mapRomanWithNumbers[y + 1];
                                romanNumber.Insert(0, valueMapRoman);

                            }
                        }
                    }

                    if (i == intList.Count - 2)
                    {
                        mapRomanWithNumbers = new Dictionary<int, string>(){
                                  {1, "C"},
                                  {2, "CC"},
                                  {3, "CCC"},
                                  {4, "CD"},
                                  {5, "D"},
                                  {6, "DC"},
                                  {7, "DCC"},
                                  {8, "DCCC"},
                                  {9, "CM"}, };

                        for (int y = 0; y < mapRomanWithNumbers.Count(); y++)
                        {
                            var keyMapRoman = mapRomanWithNumbers.ElementAt(y).Key;
                            if (intListNumber == keyMapRoman)
                            {
                                var valueMapRoman = mapRomanWithNumbers[y + 1];
                                romanNumber.Insert(0, valueMapRoman);
                            }
                        }
                    }
                    if (i == intList.Count - 3)
                    {
                        mapRomanWithNumbers =
                        new Dictionary<int, string>(){
                                  {1, "M"},
                                  {2, "MM"},
                                  {3, "MMM"}, };

                        for (int y = 0; y < mapRomanWithNumbers.Count(); y++)
                        {
                            var keyMapRoman = mapRomanWithNumbers.ElementAt(y).Key;
                            if (intListNumber == keyMapRoman)
                            {
                                var valueMapRoman = mapRomanWithNumbers[y + 1];
                                romanNumber.Insert(0, valueMapRoman);

                            }
                        }
                    }
                }
                string sRoman = String.Join(",", romanNumber);
                sRoman = String.Concat(sRoman.Split(","));
                return sRoman;
            }
            else 
            {
                Console.WriteLine("Write a number below 4000");
                return null;
            }
        }
    }
}
