using System.Collections.Generic;
using System.Linq;

namespace CSharpPrac
{
    public class Practice
    {
        public static void Main(string[] args)
        {
            try
            {
                FizzBuzz fb = new FizzBuzz();
                fb.ShowFizzBuzz();
            }
            catch (Exception ex)
            {
                //明日はエラー処理何か考える
                //と思ったけど忙しくてできなかった。
            }
            finally
            {
                Console.WriteLine("Program end...");
            }
        }
    }
}