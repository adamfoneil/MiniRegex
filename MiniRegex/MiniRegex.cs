using System;

namespace MiniRegex
{
	public static class MiniRegex
	{
		public static bool IsMatch(string pattern, string input)
		{
			if (pattern.Length > input.Length) return false;

			char[] patternChars = pattern.ToCharArray();
			char[] inputChars = input.ToCharArray();
			int inputIndex = 0;

			for (int patternIndex = 0; patternIndex < patternChars.Length; patternIndex++)
			{
				if (char.IsNumber(patternChars[patternIndex]))
				{
					inputIndex += Convert.ToInt32(patternChars[patternIndex].ToString());
					patternIndex++;
				}

				if (!inputChars[inputIndex].Equals(patternChars[patternIndex])) return false;
				inputIndex++;
			}

			return true;
		}
	}
}