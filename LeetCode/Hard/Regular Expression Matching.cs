public enum Result
{
    TRUE,
    FALSE
}

public class Solution
{
    private Result?[][] memo;

    public bool IsMatch(string text, string pattern)
    {
        memo = new Result?[text.Length + 1][];
        for (int i = 0; i < memo.Length; i++)
        {
            memo[i] = new Result?[pattern.Length + 1];
        }

        return Dp(0, 0, text, pattern);
    }

    public bool Dp(int i, int j, string text, string pattern)
    {
        if (memo[i][j] != null)
        {
            return memo[i][j] == Result.TRUE;
        }

        bool ans;

        if (j == pattern.Length)
        {
            ans = i == text.Length;
        }
        else
        {
            bool firstMatch = (i < text.Length &&
                               (pattern[j] == text[i] ||
                                pattern[j] == '.'));

            if (j + 1 < pattern.Length && pattern[j + 1] == '*')
            {
                ans = (Dp(i, j + 2, text, pattern) ||
                       (firstMatch && Dp(i + 1, j, text, pattern)));
            }
            else
            {
                ans = firstMatch && Dp(i + 1, j + 1, text, pattern);
            }
        }

        memo[i][j] = ans ? Result.TRUE : Result.FALSE;
        return ans;
    }
}

