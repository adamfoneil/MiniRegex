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

				// if either index goes past their respective array length, then we can assume a match
				if ((inputIndex > inputChars.Length - 1 || patternIndex > patternChars.Length - 1)) return true;

				if (!inputChars[inputIndex].Equals(patternChars[patternIndex])) return false;
				inputIndex++;
			}

			// if we made it here it means there was no mismatch to this point
			return true;
		}
	}
}