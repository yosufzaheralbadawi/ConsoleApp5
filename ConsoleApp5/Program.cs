namespace ConsoleApp5
{
    internal class Program
    {

        //1



        //static void Main()
        //{

        //    Console.Write("Enter the value of n: ");
        //    int n = int.Parse(Console.ReadLine());


        //    for (int i = 0; i < n; i++)
        //    {

        //        for (int j = 0; j < n; j++)
        //        {

        //            if (i == j)
        //                Console.Write("1 ");
        //            else
        //                Console.Write("0 ");
        //        }

        //        Console.WriteLine();
        //    }
        //}


        //2


        //static void Main()
        //{

        //    Console.Write("Enter the size of the array: ");
        //    int size = int.Parse(Console.ReadLine());

        //    int[] arr = new int[size];


        //    Console.WriteLine("Enter the elements of the array:");
        //    for (int i = 0; i < size; i++)
        //    {
        //        Console.Write($"Element [{i + 1}]: ");
        //        arr[i] = int.Parse(Console.ReadLine());
        //    }


        //    int sum = 0;
        //    for (int i = 0; i < size; i++)
        //    {
        //        sum += arr[i];
        //    }


        //    Console.WriteLine($"The sum of all elements in the array is: {sum}");
        //}


        //3

        //static void Main()
        //{

        //    Console.Write("Enter the size of the arrays: ");
        //    int size = int.Parse(Console.ReadLine());


        //    int[] arr1 = new int[size];
        //    int[] arr2 = new int[size];
        //    int[] mergedArray = new int[2 * size];


        //    Console.WriteLine("Enter elements of the first array:");
        //    for (int i = 0; i < size; i++)
        //    {
        //        Console.Write($"Element [{i + 1}]: ");
        //        arr1[i] = int.Parse(Console.ReadLine());
        //    }


        //    Console.WriteLine("Enter elements of the second array:");
        //    for (int i = 0; i < size; i++)
        //    {
        //        Console.Write($"Element [{i + 1}]: ");
        //        arr2[i] = int.Parse(Console.ReadLine());
        //    }


        //    for (int i = 0; i < size; i++)
        //    {
        //        mergedArray[i] = arr1[i];           
        //        mergedArray[size + i] = arr2[i];   
        //    }


        //    Array.Sort(mergedArray);


        //    Console.WriteLine("Merged and sorted array:");
        //    foreach (int num in mergedArray)
        //    {
        //        Console.Write(num + " ");
        //    }
        //}

        //4

        //static void Main()
        //{

        //    Console.Write("Enter the size of the array: ");
        //    int size = int.Parse(Console.ReadLine());


        //    int[] arr = new int[size];
        //    Console.WriteLine("Enter the elements of the array:");
        //    for (int i = 0; i < size; i++)
        //    {
        //        Console.Write($"Element [{i + 1}]: ");
        //        arr[i] = int.Parse(Console.ReadLine());
        //    }


        //    int[] frequency = new int[size];
        //    bool[] visited = new bool[size]; 


        //    for (int i = 0; i < size; i++)
        //    {
        //        if (visited[i]) 
        //            continue;

        //        int count = 1; 

        //        for (int j = i + 1; j < size; j++)
        //        {
        //            if (arr[i] == arr[j])
        //            {
        //                count++;
        //                visited[j] = true; 
        //            }
        //        }

        //        frequency[i] = count;
        //    }


        //    Console.WriteLine("Element | Frequency");
        //    for (int i = 0; i < size; i++)
        //    {
        //        if (!visited[i]) 
        //            Console.WriteLine($"   {arr[i]}   |     {frequency[i]}");
        //    }
        //}



        //5

        //static void Main()
        //{

        //    Console.Write("Enter the size of the array: ");
        //    int size = int.Parse(Console.ReadLine());


        //    int[] arr = new int[size];
        //    Console.WriteLine("Enter the elements of the array:");
        //    for (int i = 0; i < size; i++)
        //    {
        //        Console.Write($"Element [{i + 1}]: ");
        //        arr[i] = int.Parse(Console.ReadLine());
        //    }


        //    int max = arr.Max();
        //    int min = arr.Min();


        //    Console.WriteLine($"\nMaximum element: {max}");
        //    Console.WriteLine($"Minimum element: {min}");
        //}


        //6


        //static void Main()
        //{
        //    int[] arr = { 12, 35, 1, 10, 34, 1 };
        //    Array.Sort(arr);
        //    Array.Reverse(arr);

        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] < arr[0])
        //        {
        //            Console.WriteLine("The second largest element is: " + arr[i]);
        //            return;
        //        }
        //    }

        //    Console.WriteLine("No second largest element found.");
        //}

        //7



        //static void Main()
        //{

        //    Console.Write("Enter the size of the array: ");
        //    int n = int.Parse(Console.ReadLine());


        //    int[] arr = new int[n];
        //    Console.WriteLine("Enter the elements of the array:");
        //    for (int i = 0; i < n; i++)
        //    {
        //        arr[i] = int.Parse(Console.ReadLine());
        //    }


        //    int maxDistance = 0;
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = i + 1; j < n; j++)
        //        {
        //            if (arr[i] == arr[j])
        //            {
        //                maxDistance = Math.Max(maxDistance, j - i);
        //            }
        //        }
        //    }

        //    Console.WriteLine("The longest distance between two equal cells is: " + maxDistance);
        //}


        //9

        //static void Main()
        //{

        //    Console.WriteLine("Enter a sentence:");
        //    string input = Console.ReadLine();


        //    string result = ReverseWords(input);


        //    Console.WriteLine("Reversed: " + result);
        //}

        //static string ReverseWords(string input)
        //{

        //    string[] words = input.Split(' ');


        //    Array.Reverse(words);


        //    return string.Join(" ", words);
        //}




        //10



        //static void Main()
        //{

        //    Console.Write("Enter number of rows: ");
        //    int rows = int.Parse(Console.ReadLine());

        //    Console.Write("Enter number of columns: ");
        //    int cols = int.Parse(Console.ReadLine());


        //    int[,] array1 = new int[rows, cols];
        //    int[,] array2 = new int[rows, cols];


        //    Console.WriteLine("Enter elements for the first array:");
        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //            Console.Write($"Element [{i},{j}]: ");
        //            array1[i, j] = int.Parse(Console.ReadLine());
        //            array2[i, j] = array1[i, j]; 
        //        }
        //    }


        //    Console.WriteLine("Second array after copying:");
        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //            Console.Write(array2[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}


        //11



        //static void Main()
        //{
            
        //    Console.Write("Enter size: ");
        //    int size = int.Parse(Console.ReadLine());

        //    int[] arr = new int[size];

          
        //    Console.WriteLine("Enter elements:");
        //    for (int i = 0; i < size; i++)
        //    {
        //        arr[i] = int.Parse(Console.ReadLine());
        //    }

            
        //    Console.WriteLine("Reverse order:");
        //    for (int i = size - 1; i >= 0; i--)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        //}

    }
}
