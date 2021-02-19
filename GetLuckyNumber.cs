using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    class GetLuckyNumber
    {
        public static int GetLuckNumber(string Dob)
        {
            string[] res = Dob.Split('-');
            int date = int.Parse(res[0]);
            int mon = ConvertMonToNum(res[1]);
            int year = int.Parse(res[2]);
            int sum = date + mon + year;
            while (sum > 9)
            {
                sum = GetSumOfDigits(sum);
            }
            return sum;

        }

        private static int GetSumOfDigits(int sum)
        {
            int count = 0;
            while (sum > 0)
            {
                int digit = sum % 10;
                count = count + digit;
                sum = sum / 10;
            }
            return count;
        }

        public static int ConvertMonToNum(string month)
        {
            month = month.ToLower();
            string[] str = { "jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec" };
            for (int i = 0; i < str.Length; i++)
            {
                if (month.Contains(str[i]))
                {
                    return i + 1;
                }
            }
            return 0;
        }
            static void Main(string[] args)
            {
                Console.WriteLine(GetLuckNumber("1995-april-18"));
            }
        }
    }