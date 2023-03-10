
        int[] numbers = { 5, 2, 8, 3, 1 };
        int temp;
        
        // outer loop
        for (int i = 0; i < numbers.Length; i++) {

            // inner loop
            for (int j = i + 1; j < numbers.Length-1; j++) {
                if (numbers[i] > numbers[j]) {
                    temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }

        }
        
        Console.WriteLine("Sorted numbers: ");
        for (int i = 0; i < numbers.Length; i++) {
            Console.WriteLine(numbers[i]);
        }