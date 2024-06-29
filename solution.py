Here is a Python console application that generates all combinations of a phone number using a digit-to-letters map:

```python
from itertools import product

digit_to_letters = {
    '2': 'abc',
    '3': 'def',
    '4': 'ghi',
    '5': 'jkl',
    '6': 'mno',
    '7': 'pqrs',
    '8': 'tuv',
    '9': 'wxyz',
}

def phone_number_combinations(phone_number):
    letters_to_combine = (digit_to_letters[digit] for digit in phone_number if digit in digit_to_letters)
    return [''.join(combination) for combination in product(*letters_to_combine)]

def main():
    phone_number = input("Enter a phone number: ")
    combinations = phone_number_combinations(phone_number)
    print("Combinations:")
    for combination in combinations:
        print(combination)

if __name__ == "__main__":
    main()
```

This program first defines a map from digits to letters, then defines a function `phone_number_combinations` that generates all combinations of a phone number using this map. It does this by creating a generator that yields the letters corresponding to each digit in the phone number, then using the `product` function from the `itertools` module to generate all combinations of these letters. The `main` function prompts the user for a phone number, generates all combinations of this number, and prints them.