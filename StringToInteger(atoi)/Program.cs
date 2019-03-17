using System;
using System.Text;

namespace StringToInteger_atoi_
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(MyAtoi("-91283472332"));
        }

        public static int MyAtoi(string str)
        {
            str = str.Trim();

            if (str.Length == 0)
            {
                return 0;
            }

            int index = 0;
            bool isNegative = false;
            if (str[0] == '-' || str[0] == '+')
            {
                isNegative = str[0] == '-' ? true : false;
                index = 1;
            }

            StringBuilder number = new StringBuilder();

            while (index < str.Length && char.IsNumber(str[index]) == true)
            {
                if (char.IsNumber(str[index]) == false)
                {
                    break;
                }

                int num = int.Parse(str[index].ToString());
                number.Append(num);

                index++;
            }

            if (number.Length == 0)
            {
                return 0;
            }

            int result = 0;
            var isSuccessfull = int.TryParse(number.ToString(), out result);

            if (isSuccessfull)
            {
                result *= isNegative == true ? -1 : 1;
                return result;
            }
            else
            {
                return isNegative == true ? int.MinValue : int.MaxValue;
            }
        }
    }
}
