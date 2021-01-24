using System;

class Program
{
    private static readonly Random random = new Random();

    static void Main()
    {
        int[] arr = new int[100];

        for (int i = 0; i < arr.Length; i++)
        {
            int rand = random.Next(0, 100);

            arr[i] = rand;
        }


        Array.Sort(arr);

        int index = BinarySearch(arr, 0, arr.Length - 1, 5);

        Console.WriteLine("5 found at: " + index);
    }

    /// <summary>
    /// A simple implementation of the Binary Search algorithm
    /// NOTE: arr must be sorted.
    /// </summary>
    /// <param name="arr">The array to look for a value.</param>
    /// <param name="startPos">The position where the algo starts looking for a specific number. Usually, it should be set to 0.</param>
    /// <param name="endPos">The position where the algo starts looking for a specific number. Usually, it should be set to the index of the last element on arr.</param>
    /// <param name="x">The value to be searched.</param>
    /// <returns></returns>
    static int BinarySearch(int[] arr, int startPos, int endPos, int x)
    {

        // If endPos is smaller than smartPos, it means that the algo has analyzed all possible places, and the number could not be found.
        if (endPos >= startPos)
        {
            int mid = startPos + (endPos - startPos) / 2;

            // If the number in the middle of the array is bigger than x,
            //  discard the 2nd half of the array (the one that contains numbers bigger than x).
            if (arr[mid] > x) 
            {
                return BinarySearch(arr, startPos, mid - 1, x);
            }

            // If the number in the middle of the array is smaller than x, 
            // discard the 1st half of the array (the one that contains numbers less than x).
            else if (arr[mid] < x)
            {
                return BinarySearch(arr, mid + 1, endPos, x);
            }
            
            // Returns the index where the number was found.
            else
            {
                return mid;
            }
        
        // Number was not found.
        } else
        {
            return -1;
        }
    }
}

