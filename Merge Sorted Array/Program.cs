using System;

namespace Merge_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 4, 0, 0, 0, 0 };
            int[] nums2 = new int[] { 2, 3, 5, 6 };
            Merge(nums1, 2, nums2, 3);
            Console.WriteLine("Hello World!");
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // here m and n are the no of elements that we are merging into one.
            int i = m - 1; // index from nums1
            int j = n - 1; // index from num2
            int k = nums1.Length - 1; //merging array size as it has enough space to hold nums2.
            
            while(i >= 0 && j >= 0)
            {
                nums1[k--] = nums1[i] > nums2[j] ? nums1[i--] : nums2[j--];
            }

            while (j >= 0)
            {
                nums1[k--] = nums2[j--];
            }

            Array.Sort(nums1);
        }
    }
}
