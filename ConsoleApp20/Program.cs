using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new[] { 1, 2, 3, 4, 6, 12 };
            var arr2 = new[] { 4, 5, 6, 7, 8, 9, 10 };
            var result = MergedArray(arr1, arr2);
            foreach (int e in result)
                Console.Write($"{e} ");
            Console.ReadLine();
        }

        private static int[] MergedArray(int[] inputArr1, int[] inputArr2)
        {
            int al1 = inputArr1.Length;
            int al2 = inputArr2.Length;
            int[] outputArr = new int[al1 + al2];
            int i = 0, j = 0, k = 0;
            while (i < inputArr1.Length && j < inputArr2.Length)
            {
                if (inputArr1[i] < inputArr2[j])
                {
                    outputArr[k++] = inputArr1[i++];

                }
                else if (inputArr1[i] > inputArr2[j])
                {
                    outputArr[k++] = inputArr2[j++];

                }
                else
                {
                    outputArr[k++] = inputArr2[j++];
                    outputArr[k++] = inputArr1[i++];
                }
            }
            while (i < inputArr1.Length)
            {
                outputArr[k++] = inputArr1[i++];
            }

            while (j < inputArr2.Length)
            {
                outputArr[k++] = inputArr2[j++];
            }

            return outputArr;
        }
    }
}
