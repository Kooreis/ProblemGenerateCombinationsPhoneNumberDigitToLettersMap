public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a phone number: ");
        String digits = scanner.next();
        List<String> result = letterCombinations(digits);
        System.out.println(result);
    }