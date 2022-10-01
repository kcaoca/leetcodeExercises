/*https://leetcode.com/problems/minimum-time-to-make-rope-colorful/
 */
public class Solution {
    public int MinCost(string colors, int[] neededTime) {
        if (colors.Length <= 1) return 0;
        int curr = 0, prev = 0, res = 0;
        while (curr++ < colors.Length - 1) {
            if (colors[curr] == colors[prev]) {
                res += Math.Min(neededTime[prev], neededTime[curr]);
                prev = neededTime[prev] > neededTime[curr] ? prev : curr;
            } else {
                prev = curr;
            }
        }
        return res;
    }
}
/*Runtime: 271 ms, faster than 94.17% of C# online submissions for Minimum Time to Make Rope Colorful.
Memory Usage: 58 MB, less than 8.74% of C# online submissions for Minimum Time to Make Rope Colorful.
*/