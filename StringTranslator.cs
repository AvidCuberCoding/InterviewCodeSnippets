using System;

//Given a string with a pattern of alphabet, number, alphabet, number, translate into a string consisting of only letters corresponding to the number to the right of the number in the original string.					
public class StringTranslator
{
	public static String TranslateString(String rawString)
	{
		String translatedString = "";
		char repeatedLetter = ' ';
		if (rawString.Length < 2)
		{
			return ("String not long enough");
		}

		for (int i = 0; i < rawString.Length; i++)
		{
			if (i % 2 == 1)
			{
				repeatedLetter = rawString[i - 1];
				int timesDuplicated = (int)Char.GetNumericValue(rawString[i]);
				String duplicatedLetters = new String(repeatedLetter, timesDuplicated);
				translatedString += duplicatedLetters;
			}
		}

		return translatedString;
	}

	public static void Main(String[] args)
	{
		Console.WriteLine(TranslateString("A4B2C5"));
		Console.WriteLine(TranslateString("V3D5X7"));
	}
}