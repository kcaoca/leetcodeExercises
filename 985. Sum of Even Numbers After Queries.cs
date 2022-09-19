/*https://leetcode.com/problems/sum-of-even-numbers-after-queries/
 */
public class Solution {
    public int[] SumEvenAfterQueries(int[] nums, int[][] queries) {
        int[] res = new int[queries.Length];
        int sum = nums.Where(x => x % 2 == 0).Sum();
        int i = 0;
        foreach (int[] query in queries) {
            if (nums[query[1]] % 2 == 0) {
                if ((nums[query[1]] + query[0]) % 2 == 0) {
                    sum += query[0];
                } else {
                    sum -= nums[query[1]];
                }
            } else {
                if ((nums[query[1]] + query[0]) % 2 == 0) {
                    sum += nums[query[1]] + query[0];
                } else {
                    sum = sum;
                }
            }
            nums[query[1]] += query[0];
            res[i++] = sum;
        }


        return res;
    }
}
/*Runtime: 500 ms, faster than 53.85% of C# online submissions for Sum of Even Numbers After Queries.
Memory Usage: 52.1 MB, less than 23.08% of C# online submissions for Sum of Even Numbers After Queries.
*/