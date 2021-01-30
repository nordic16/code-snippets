using System;

public class LinearSearch {
    
    private static readonly Random random = new Random();

    static void Main() {
        int[] arr = new int[10];
        
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = random.Next();
        }
        
        int val = random.Next();
        int index = LinearSearch(arr, val);
        
        Console.WriteLine($"Value {val} found on index {index}");
    }

    // Loops through the array, returning the index of val.
    // In case val doesn't exist in the array, this function returns -1.
    private static int LinearSearch(int[] arr, int val) {
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] == val) {
                return i;
            }
        }

        return -1;
    }
}
