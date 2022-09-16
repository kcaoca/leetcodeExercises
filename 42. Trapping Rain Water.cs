/*https://leetcode.com/problems/trapping-rain-water/
 */
///DP solution
public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        if (n < 3) return 0;
        int res = 0;
        int[] lefts = new int[n];
        int[] rights = new int[n];
        for (int i = 0; i < n - 1; i++) {
            lefts[i] = i == 0 ? height[0] : Math.Max(lefts[i - 1], height[i]);
        }
        for (int i = n - 1; i >= 0; i--) {
            rights[i] = i == n - 1 ? height[i] : Math.Max(rights[i + 1], height[i]);
        }
        for (int i = 0; i < n - 1; i++) {
            res += Math.Min(lefts[i], rights[i]) - height[i];
        }
        return res;
    }
}
/*Runtime: 183 ms, faster than 20.31% of C# online submissions for Trapping Rain Water.
Memory Usage: 39.4 MB, less than 95.34% of C# online submissions for Trapping Rain Water.
*/

///2 pointer solution
public class Solution {
    public int Trap(int[] height) {
        int l = 0, r = height.Length - 1;
        if (r < 2) return 0;
        int maxL = height[l], maxR = height[r];
        int res = 0;
        while (l < r) {
            if (maxL < maxR) {
                res += maxL - height[l];
                maxL = Math.Max(maxL, height[++l]);
            } else {
                res += maxR - height[r];
                maxR = Math.Max(maxR, height[--r]);
            }
        }
        return res;
    }
}
/*Runtime: 128 ms, faster than 73.48% of C# online submissions for Trapping Rain Water.
Memory Usage: 39.9 MB, less than 41.70% of C# online submissions for Trapping Rain Water.
*/