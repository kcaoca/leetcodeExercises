/*https://leetcode.com/problems/utf-8-validation/
 * */
public class Solution {
    public bool ValidUtf8(int[] data) {
        if (data == null || data.Length < 1)
            return false;
        int len = 0;
        for (int i = 0; i < data.Length; i++) {
            if (data[i] < 128) continue;
            int o = ones(data[i]);
            if (len == 0 && o <= 4) {
                if (o > 1)
                    len = o - 1;
                else if (o == 1)
                    return false;
            } else {
                if (o != 1)
                    return false;
                else {
                    len--;
                }
            }
        }
        return len == 0;
    }
    private int ones(int d) {
        int ones = 0;
        for (int i = 7; i >= 0; i--) {
            if ((d >> i & 1) == 1) {
                ones++;
            } else
                break;
        }
        return ones;
    }
}
/*Runtime: 187 ms, faster than 37.50% of C# online submissions for UTF-8 Validation.
Memory Usage: 41.6 MB, less than 70.83% of C# online submissions for UTF-8 Validation.
*/