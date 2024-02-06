using System;

class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {

        int n = nums1.Length;
        int m = nums2.Length;

        int[] merged = new int[n + m];
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            merged[k++] = nums1[i];
        }
        for (int i = 0; i < m; i++)
        {
            merged[k++] = nums2[i];
        }
        Array.Sort(merged);
        int total = merged.Length;

        if (total % 2 == 1)
        {

            return (double)merged[total / 2];
        }
        else
        {
            int middle1 = merged[total / 2 - 1];
            int middle2 = merged[total / 2];
            return ((double)middle1 + (double)middle2) / 2.0;
        }
    }
}
