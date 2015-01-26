using System.IO;
using System;

class Program
{
    /// <summary>
    /// Determines whether the string is a palindrome.
    /// </summary>
    public static bool IsPalindrome(string value)
    {
	int min = 0;
	int max = value.Length - 1;
	while (true)
	{
	    if (min > max)
	    {
		return true;
	    }
	    char a = value[min];
	    char b = value[max];
	    if (char.ToLower(a) != char.ToLower(b))
	    {
		return false;
	    }
	    min++;
	    max--;
	}
    }

    static void Main()
    {
	Console.WriteLine(IsPalindrome("malayalam"));
    }
}