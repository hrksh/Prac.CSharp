using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpPrac
{
	public class FizzBuzz
	{
		List<int> list;

		public FizzBuzz()
		{
			list = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
				list.Add(i);
            }
		}

		public void ShowNumbers()
        {
			list.ForEach(x => Console.WriteLine(x));
        }

		public void ShowFizzBuzz()
        {
            string strNum;

			list.ForEach(x =>
            {
                switch (x)
                {
                    case int t when t % 15 == 0:
                        strNum = "FizzBuzz";
                        break;
                    case int t when t % 5 == 0:
                        strNum = "Buzz";
                        break;
                    case int t when t % 3 == 0:
                        strNum = "Fizz";
                        break;
                    default:
                        strNum = x.ToString();
                        break;
                }
                Console.WriteLine(strNum);
            });
        }
	}
}

