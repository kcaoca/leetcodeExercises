/*https://leetcode.com/problems/concatenation-of-consecutive-binary-numbers/
 */
public class Solution {
    public int ConcatenatedBinary(int n) {
        long res = 0;
        for (int i = 1; i <= n; i++) {
            res = ((res << (int)Math.Log(i, 2) + 1) + i) % 1000000007;
        }
        return (int)res;
    }
}
/*Runtime: 119 ms, faster than 50.00% of C# online submissions for Concatenation of Consecutive Binary Numbers.
Memory Usage: 25.3 MB, less than 66.67% of C# online submissions for Concatenation of Consecutive Binary Numbers.
*/