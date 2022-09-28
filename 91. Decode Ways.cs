/*https://leetcode.com/problems/decode-ways/
 */
public class Solution {
    Dictionary<string, int> dict = new Dictionary<string, int>();
    public int NumDecodings(string s) {
        if (string.IsNullOrEmpty(s) || s[0] == '0') return 0;
        if (dict.ContainsKey(s)) return dict[s];
        int res = isValid(s) ? 1 : 0;
        if (s.Length > 1 && isValid(s.Substring(0, 1)))
            res += NumDecodings(s.Substring(1, s.Length - 1));
        if (s.Length > 2 && isValid(s.Substring(0, 2)))
            res += NumDecodings(s.Substring(2, s.Length - 2));
        dict.Add(s, res);
        return res;
    }
    private bool isValid(string s) {    // s.Length==1 or ==2
        if (string.IsNullOrEmpty(s) || s.Length > 2 || s[0] == '0')
            return false;
        if (s.Length == 1)
            return true;
        if (s[0] > '2' || (s[0] == '2' && s[1] > '6'))
            return false;
        return true;
    }
}
/*Runtime: 97 ms, faster than 61.03% of C# online submissions for Decode Ways.
Memory Usage: 35.7 MB, less than 51.28% of C# online submissions for Decode Ways.
*/