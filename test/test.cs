using System;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {	
			string s = "abcde";
			string goal = "deabc";
			Console.WriteLine(IsRotatedString(s, goal));
		}	
		static bool IsRotatedString(string s, string goal) 
		{
			s = s + s;
			if (s.CountOf(goal) != -1)
			{
				return true;
			}
			return false;
		}
    }
}
