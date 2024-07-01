def phone_number_combinations(phone_number):
    letters_to_combine = (digit_to_letters[digit] for digit in phone_number if digit in digit_to_letters)
    return [''.join(combination) for combination in product(*letters_to_combine)]