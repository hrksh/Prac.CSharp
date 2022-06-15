using System;
namespace CSharpPrac
{
	public class SampleClass
	{
		private SampleClass()
		{
			//特に今は何もしない・・・
		}

		private static SampleClass sc = new SampleClass();

		public static SampleClass Inst { get { return sc; } }

		public void WriteToConsole(string targetString)
		{
			Console.WriteLine(targetString);
		}
	}
}

