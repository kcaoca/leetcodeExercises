/*https://leetcode.com/problems/number-of-dice-rolls-with-target-sum/
 */
public class Solution {
    Dictionary<(int, int), int> dict = new Dictionary<(int, int), int>();
    public int NumRollsToTarget(int n, int k, int target) {
        if (n * k < target || n > target) return 0;
        if (n == 1 && target <= k) return 1;
        if (dict.ContainsKey((n, target))) return dict[(n, target)];
        int res = 0;
        for (int i = 1; i <= k && i <= target; i++) {
            res += NumRollsToTarget(n - 1, k, target - i);
            res = res % 1000000007;
        }
        dict.Add((n, target), res);
        return res;
    }
}
/*Runtime: 104 ms, faster than 30.00% of C# online submissions for Number of Dice Rolls With Target Sum.
Memory Usage: 27.2 MB, less than 68.75% of C# online submissions for Number of Dice Rolls With Target Sum.
*/