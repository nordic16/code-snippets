using System;

public class Program {
	
	// Used to generate pseudo-random values.
    private static readonly Random random = new Random();
	
    public static void Main(string[] args) {
	int[] arr = new int[6] {1, 5, -1, 23, 8, -25};
        
        // Outputs all elements in the array nicely formatted.
        Console.WriteLine($"BEFORE SORTING:\n[{string.Join(", ", arr)}]");
			    
        insertionSort(arr);
			
		Console.WriteLine($"AFTER SORTING:\n[{string.Join(", ", arr)}]");
    }
	
	private static void insertionSort(int[] arr) {
		for (int i = 1; i < arr.Length; i++) {
			int key = arr[i];
			int j = i - 1;
				
			while (j >= 0 && key < arr[j]) {
				arr[j + 1] = arr[j];
				j--;
			}
				
			arr[j + 1] = arr[i];
			}
		}
	}
}