namespace Algorithms;

// Given two crystal balls that will break if dropped from a high enough
// distance, determine the exact spot in which they will break in the most
// optimized way.
public class TwoCrystalBalls
{
    // The constraint of only having two attempts to find the solution means
    // that there will always be a portion of the array that needs to be walked.
    // The optimum solution then calls for a reduction in the distance that
    // needs to be walked, hence the jump of sqrt(N).
    // This results in a time complexity of O(sqrt(N)).
    public static int Run(bool[] breaks)
    {
        var jump = (int)Math.Floor(Math.Sqrt(breaks.Length));
        var i = jump;

        // Jump until the first ball breaks.
        while (i < breaks.Length && !breaks[i])
        {
            i += jump;
        }

        // Move back to the last known safe height.
        i -= jump;

        // Walk until we break the remaining ball.
        for (var j = i; j < breaks.Length; j++)
        {
            if (breaks[j])
            {
                return j;
            }
        }

        return -1;
    }
}
