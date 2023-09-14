namespace MergeSort;
class Program
{

    static void MergeSort(int[] array)
    {
        if (array.Length < 2)
        {
            return;
        }

        int mid = array.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[array.Length - mid];

        for (int i = 0; i < mid; i++)
        {
            left[i] = array[i];
        }

        for (int i = mid; i < array.Length; i++)
        {
            right[i - mid] = array[i];
        }

        MergeSort(left);
        MergeSort(right);
        Merge(left, right, array);
    }

    static void Merge(int[] left, int[] right, int[] array)
    {
        int i = 0;
        int j = 0;
        int k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                array[k] = left[i];
                i++;
            }
            else
            {
                array[k] = right[j];
                j++;
            }

            k++;
        }

        while (i < left.Length)
        {
            array[k] = left[i];
            i++;
            k++;
        }

        while (j < right.Length)
        {
            array[k] = right[j];
            j++;
            k++;
        }
    }


    static void Main(string[] args)
    {
        int[] arrray = { 4, 2, 8, 6, 5, 1, 13, 3, 15, 9, 7, 14, 10, 11, 12 };

        // Print array before Merge Sort
        Console.WriteLine("\nArray before Merge Sort:");
        for (int i = 0; i < arrray.Length; i++)
        {
            Console.Write(arrray[i] + " ");
        }

        MergeSort(arrray);

        // Print array after Merge Sort
        Console.WriteLine("\nArray after Merge Sort:");
        for (int i = 0; i < arrray.Length; i++)
        {
            Console.Write(arrray[i] + " ");
        }
        Console.WriteLine("\n");

    }
}
