public static IList<string> LetterCombinations(string digits)
    {
        IList<string> res = new List<string>();
        if (string.IsNullOrEmpty(digits)) return res;
        string[] mapping = new string[10]
        {
            "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"
        };
        res.Add("");
    }