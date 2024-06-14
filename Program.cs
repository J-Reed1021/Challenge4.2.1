namespace Challenge4._2._1
{



    class Program
    {
      static void Main()
      {
        Console.Write("Input the number of elements to be stored in the array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        Dictionary<int, int> frequency = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());

            if (frequency.ContainsKey(arr[i]))
                frequency[arr[i]]++;
            else
                frequency[arr[i]] = 1;
        }

        Console.WriteLine("Frequency of all elements of array: ");
        foreach (var item in frequency)
        {
            Console.WriteLine($"{item.Key} occurs {item.Value} times");
        }
      }
    }
}
