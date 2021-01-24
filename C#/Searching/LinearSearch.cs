using System;

public class LinearSearch {
    
    private static readonly Random random = new Random();

    static void Main() {
        int[] arr = new int[10];
        
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = random.Next();
        }
    }

    private static int LinearSearch(int[] arr, int val) {
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] == val) {
                return i;
            }
        }

        return -1;
    }
}
