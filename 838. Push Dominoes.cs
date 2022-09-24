/*https://leetcode.com/problems/push-dominoes/submissions/
 */
public class Solution {
    public string PushDominoes(string dominoes) {
        int n = dominoes.Length;
        int[] f = new int[n];
        int force = 0;
        for (int i = 0; i < n; i++) {
            if (dominoes[i] == 'R') {
                force = n;
            } else if (dominoes[i] == 'L')
                force = 0;
            else
                force = Math.Max(force - 1, 0);
            f[i] = force;
        }
        for (int i = n - 1; i >= 0; i--) {
            if (dominoes[i] == 'L')
                force = n;
            else if (dominoes[i] == 'R')
                force = 0;
            else
                force = Math.Max(force - 1, 0);
            f[i] -= force;
        }
        char[] r = new char[n];
        for (int i = 0; i < n; i++) {
            r[i] = f[i] > 0 ? 'R' : (f[i] < 0 ? 'L' : '.');
        }
        return new string(r);
    }
}
/*Runtime: 178 ms, faster than 15.38% of C# online submissions for Push Dominoes.
Memory Usage: 41.2 MB, less than 46.15% of C# online submissions for Push Dominoes.
*/