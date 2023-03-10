  
int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = SumArray(numbers);
        Console.WriteLine("The sum of the array is: " + sum);

Console.ReadKey();

 int SumArray(int[] arr) {
        int sum = 0;
        for (int i = 1; i < arr.Length; i++) {
            sum += arr[i];
        }
        return sum;
    }

