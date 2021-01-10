using System;

public class Program {
	
	// Used to generate pseudo-random values.
    private static readonly Random random = new Random();
	
    public static void Main(string[] args) {
        int[] arr = new int[40];
		
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = random.Next(int.MinValue, int.MaxValue);
        }
        
        // Outputs all elements in the array nicely formatted.
        Console.WriteLine($"BEFORE SORTING:\n[{string.Join(", ", arr)}]");
			    
        bubbleSort(arr);
			
		Console.WriteLine($"AFTER SORTING:\n[{string.Join(", ", arr)}]");
        }
        
	// Bubble sort is a very simple and easy to understand sorting algorithm.
	// It consists of comparing if the next value is out of place, then swaps it with the currrent one.
	// NOTE: bubble sort is not recommended for very large collections.
    private static void bubbleSort(int[] arr) {
            
		for (int i = 0; i < arr.Length; i++) {
			for (int j = 0; j < arr.Length - 1; j++) {
					
				// If the current value is bigger than the next, swap their orders.
				if (arr[j] > arr[j + 1]) {
					// Perform interchange
						
					int temp = arr[j + 1];
					arr[j + 1] = arr[j];
					arr[j] = temp;
					}
				}
			}
        }
    }