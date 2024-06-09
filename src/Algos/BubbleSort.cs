namespace Algos;

public static class BubbleSort
{
    public static void Sort(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            // For each iteration of the outer loop an additional number
            // is sorted, so we can remove one more iteration from the inner.
            // -1 protects us from going out of bounds as we compare j to j + 1.
            for (int j = 0; j < nums.Length - i - 1; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    (nums[j + 1], nums[j]) = (nums[j], nums[j + 1]);
                }
            }
        }
    }
}
