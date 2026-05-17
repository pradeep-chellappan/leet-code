namespace LeetCodeCSharp.Solutions;

// https://leetcode.com/problems/two-sum/
// Given an array of integers and a target, return indices of the two numbers that add up to target.
// Time: O(n), Space: O(n)
public class TwoSum
{
    public int[] Solve(int[] nums, int target)
    {
        var seen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (seen.TryGetValue(complement, out int j))
                return [j, i];
            seen[nums[i]] = i;
        }

        return [];
    }
}
