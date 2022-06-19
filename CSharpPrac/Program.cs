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
                //今日は遊んでしまったのでコメントのみ
            }
            finally
            {
                Console.WriteLine("Program end...");
            }
        }
    }
}