using System;
public class Problem_193
{
    public bool Solution(int[] input)
    {
        int len = input.Length;
        for (int i = 0; i < len;)
        {
            if (input[i] > 0)
            {
                i = i + input[i];
                if (i == (len - 1))
                    return true;
            }
            else
                return false;
        }
        return false;
    }

}