using System.Collections.Generic;
using System.Linq;

namespace CSharpPrac
{
    public class Practice
    {
        public static void Main(string[] args)
        {
            List<string> strList = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                strList.Add($"item_{i}");
            }

            strList.ForEach(x => SampleClass.WriteToConsole(x));
        }
    }
}