using System;
public class Problem_192
{
    public bool BacktrackingSolution(int[] input)
    {
        return canJumpFromPosition(0, input);
    }

    private bool canJumpFromPosition(int position, int[] input) {
        if (position == (input.Length - 1)) {
            return true;
        }

        int furthestJump = Math.Min(position + input[position], input.Length - 1);
        for (int i = position + 1; i <= furthestJump; i++) {
            if (canJumpFromPosition(i, input))
                return true;

        }

        return false;
    }

    public bool TopDownSolution(int[] input) {
        
        return false;
    }

}