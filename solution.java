Here is a Java console application that generates all combinations of a phone number using a digit-to-letters map.

```java
import java.util.*;

public class Main {
    private static final String[] KEYS = {"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a phone number: ");
        String digits = scanner.next();
        List<String> result = letterCombinations(digits);
        System.out.println(result);
    }

    public static List<String> letterCombinations(String digits) {
        List<String> ret = new LinkedList<String>();
        combination("", digits, 0, ret);
        return ret;
    }

    private static void combination(String prefix, String digits, int offset, List<String> ret) {
        if (offset >= digits.length()) {
            ret.add(prefix);
            return;
        }
        String letters = KEYS[(digits.charAt(offset) - '0')];
        for (int i = 0; i < letters.length(); i++) {
            combination(prefix + letters.charAt(i), digits, offset + 1, ret);
        }
    }
}
```

This program prompts the user to enter a phone number. It then generates all possible letter combinations for that phone number based on a digit-to-letters map, similar to the one found on a telephone keypad. The combinations are printed to the console.