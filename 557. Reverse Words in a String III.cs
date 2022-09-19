/*https://leetcode.com/problems/reverse-words-in-a-string-iii/
 */
public class Solution {
    public string ReverseWords(string s) {
        string[] words = s.Split(' ');
        for (int i = 0; i < words.Length; i++) {
            words[i] = new string(words[i].Reverse().ToArray());
        }
        return string.Join(' ', words);
    }
}
/*Runtime: 158 ms, faster than 32.89% of C# online submissions for Reverse Words in a String III.
Memory Usage: 41.2 MB, less than 49.11% of C# online submissions for Reverse Words in a String III.
*/