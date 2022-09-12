/*https://leetcode.com/problems/bag-of-tokens/
 * 
*/
public class Solution {
    public int BagOfTokensScore(int[] tokens, int power) {
        Array.Sort(tokens);
        if (tokens.Length == 0 || power < tokens[0]) return 0;
        int sIdx = 0, bIdx = tokens.Length, score = 0;
        while (sIdx < bIdx) {
            if (power - tokens[sIdx] >= 0) {
                power = power - tokens[sIdx];
                score++;
                sIdx++;
            } else if (score > 0) {
                if (bIdx > sIdx + 1) {
                    power += tokens[--bIdx];
                    score--;
                } else {
                    return score;
                }
            }
        }
        return score;
    }
}
/*Runtime: 88 ms, faster than 100.00% of C# online submissions for Bag of Tokens.
Memory Usage: 39.4 MB, less than 11.11% of C# online submissions for Bag of Tokens.*/