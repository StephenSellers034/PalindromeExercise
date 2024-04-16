using System;
namespace PalindromeExercise
{
	public class WordSmith
	{
		public bool IsAPalindrome(string palin)
		{
			var reversed = "";

			for(int i = palin.Length - 1; i >= 0; i--)
			{
				reversed += palin.ToLower()[i];
			}
			if(reversed == palin)
			{
				return true;
			}
			else
			{
				return false;
			}
		}	
	}
}

