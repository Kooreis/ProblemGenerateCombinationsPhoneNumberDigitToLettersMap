Here is a C# console application that generates all combinations of a phone number using a digit-to-letters map:

```C#
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a phone number: ");
        string digits = Console.ReadLine();
        IList<string> result = LetterCombinations(digits);
        foreach (var combination in result)
        {
            Console.WriteLine(combination);
        }
    }

    public static IList<string> LetterCombinations(string digits)
    {
        IList<string> res = new List<string>();
        if (string.IsNullOrEmpty(digits)) return res;
        string[] mapping = new string[10]
        {
            "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"
        };
        res.Add("");
        for (int i = 0; i < digits.Length; i++)
        {
            IList<string> temp = new List<string>();
            string chars = mapping[digits[i] - '0'];
            foreach (var c in chars)
            {
                foreach (var r in res)
                {
                    temp.Add(r + c);
                }
            }
            res = temp;
        }
        return res;
    }
}
```

This program prompts the user to enter a phone number. It then generates all possible letter combinations for that phone number based on a digit-to-letters map and prints them to the console.