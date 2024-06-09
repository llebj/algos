namespace Algos;

public class BinarySearch
{
    public static bool Run(int[] heystack, int needle)
    {
        var low = 0;
        var high = heystack.Length;
        var result = false;

        do
        {
            var mid = low + (int)Math.Floor((high - low) / 2.0);
            var value = heystack[mid];

            if (value == needle)
            {
                result = true;
                break;
            }
            else if (value < needle)
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        } while (low < high);

        return result;
    }
}
