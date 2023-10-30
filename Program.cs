using System;

class Program
{
    static void Main()
    {
        int[] record = new int[] { 19, 2, 0, 87, 1, 40, 80, 77, 77, 77, 77 };

        Console.WriteLine("Original Record:");
        PrintArray(record);

        // Simulating malware behavior
        int[] modifiedRecord = SimulateMalware(record);

        Console.WriteLine("\nRecord after Malware Simulation:");
        PrintArray(modifiedRecord);
    }

    // Function to simulate malware behavior on the record
    static int[] SimulateMalware(int[] record)
    {
        int[] modifiedRecord = new int[record.Length];

        for (int i = 0; i < record.Length; i++)
        {
            int leftNeighbor = i > 0 ? record[i - 1] : int.MaxValue;
            int rightNeighbor = i < record.Length - 1 ? record[i + 1] : int.MaxValue;

            if (record[i] <= leftNeighbor || record[i] <= rightNeighbor)
            {
                modifiedRecord[i] = 0;
            }
            else
            {
                modifiedRecord[i] = record[i];
            }
        }

        return modifiedRecord;
    }

    // Function to print an array
    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
