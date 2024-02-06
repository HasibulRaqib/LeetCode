public class Solution
{
    public string LongestPalindrome(string s)
    {
        if (s.Length <= 1)
        {
            return s;
        }

        int maxLen = 1;
        string maxStr = s.Substring(0, 1);

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i + maxLen; j <= s.Length; j++)
            {
                if (j - i > maxLen && IsPalindrome(s.Substring(i, j - i)))
                {
                    maxLen = j - i;
                    maxStr = s.Substring(i, j - i);
                }
            }
        }

        return maxStr;
    }

    private bool IsPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}
