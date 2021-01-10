using System;

public class Program {
	
	// Used to generate pseudo-random values. Should not be used for security-like programs.
    private static readonly Random random = new Random();
	
    public static void Main(string[] args) {
	    int[] arr = new int[6] {1, 5, -1, 23, 8, -25};
        
        // Outputs all elements in the array nicely formatted.
	    Console.WriteLine($"BEFORE SORTING:\n[{string.Join(", ", arr)}]");
			    
	    insertionSort(arr);
			
	    Console.WriteLine($"AFTER SORTING:\n[{string.Join(", ", arr)}]");
    }
	
	// Insertion sort is known for its simplicity and versatility.
	// It consists of shifting every single value bigger than key one place to the right
	// inserting key at the right index right after.
	private static void insertionSort(int[] arr) {
	    for (int i = 1; i < arr.Length; i++) {
			
		    // Since this is gonna be overwritten later, it must be stored in a variable. 
		    int key = arr[i];
			
		    // Index of the predecessor.
		    int j = i - 1;
				
		    //Shift every value bigger than key one place to the right.
		    while (j >= 0 && key < arr[j]) {
			    arr[j + 1] = arr[j];
			    j--;
		    }
			
		    // Inserts key at the right index.
		    arr[j + 1] = key;
		    }
	    }
    }
}
