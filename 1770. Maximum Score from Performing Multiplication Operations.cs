/*https://leetcode.com/problems/maximum-score-from-performing-multiplication-operations/
 * */
public class Solution {
    public int MaximumScore(int[] nums, int[] multipliers) {
        return dp(nums, multipliers, 0, nums.Length - 1, 0);
    }
    Dictionary<(int, int), int> cache = new Dictionary<(int, int), int>();
    private int dp(int[] nums, int[] multipliers, int left, int right, int mulIdx) {
        //int mulIdx = nums.Length - right + left - 1;
        if (mulIdx == multipliers.Length) return 0;
        if (cache.ContainsKey((left, mulIdx))) {
            return cache[(left, mulIdx)];
        }
        int v = Math.Max(
            nums[left] * multipliers[mulIdx] + dp(nums, multipliers, left + 1, right, mulIdx + 1),
            nums[right] * multipliers[mulIdx] + dp(nums, multipliers, left, right - 1, mulIdx + 1)
        );
        cache[(left, mulIdx)] = v;
        return v;
    }
}
/*
Runtime: 2192 ms, faster than 50.58% of C# online submissions for Maximum Score from Performing Multiplication Operations.
Memory Usage: 137.9 MB, less than 28.74% of C# online submissions for Maximum Score from Performing Multiplication Operations.
*/