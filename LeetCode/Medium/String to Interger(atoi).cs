public class Solution
{
    public int MyAtoi(string s)
    {
        int n = s.Length;
        int i = 0;
        int sign = 1;

        while (i < n && s[i] == ' ')
        {
            i++;
        }

        if (i < n && (s[i] == '-' || s[i] == '+'))
        {
            sign = (s[i] == '-') ? -1 : 1;
            i++;
        }

        int num = 0;
        while (i < n && char.IsDigit(s[i]))
        {
            int x = s[i] - '0';

            if (num > int.MaxValue / 10 || (num == int.MaxValue / 10 && x > int.MaxValue % 10))
            {
                return (sign == 1) ? int.MaxValue : int.MinValue;
            }

            num = num * 10 + x;
            i++;
        }

        return num * sign;
    }
}

