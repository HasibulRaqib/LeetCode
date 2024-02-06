using System;

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1 || numRows >= s.Length)
            return s;

        int n = s.Length;
        int[] arr = new int[n];
        int i = 0, c = 1;
        bool flag = true;

        while (i < n)
        {
            if (i < n && c == 1)
            {
                flag = true;
            }
            if (i < n && c == numRows)
            {
                flag = false;
            }
            if (i < n && !flag)
            {
                arr[i] = c;
                c--;
                i++;
            }
            else if (i < n && flag)
            {
                arr[i] = c;
                c++;
                i++;
            }
        }

        string[] str = new string[numRows];
        for (int j = 0; j < numRows; j++)
            str[j] = "";

        for (int j = 0; j < n; j++)
            str[arr[j] - 1] += s[j];

        string res = "";
        for (int j = 0; j < numRows; j++)
            res += str[j];

        return res;
    }
}
