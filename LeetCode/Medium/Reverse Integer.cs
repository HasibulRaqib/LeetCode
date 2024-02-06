public class Solution
{
    public int Reverse(int x)
    {
        if (x == int.MinValue)
        {
            return 0;
        }

        string s = Math.Abs(x).ToString();
        char[] chars = s.ToCharArray();
        Array.Reverse(chars);
        s = new string(chars);

        if (s.Length >= 10)
        {
            int c1 = int.Parse(s.Substring(0, 5));
            int c2 = int.Parse(s.Substring(5, 5));
            if (c1 > 21474 || c2 > 83647)
            {
                return 0;
            }
        }

        int num = int.Parse(s);
        return x < 0 ? -num : num;
    }
}
