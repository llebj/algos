namespace Algorithms;

public class LinearSearch
{
    public static bool Run(int[] haystack, int needle)
    {
        for (int i = 0; i < haystack.Length; ++i)
        {
            if (haystack[i] == needle)
            {
                return true;
            }
        }

        return false;
    }
}
