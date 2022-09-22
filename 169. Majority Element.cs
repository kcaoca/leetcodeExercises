/*https://leetcode.com/problems/majority-element/
 */
public class Solution {
    public int MajorityElement(int[] nums) {
        Array.Sort(nums);
        return nums[nums.Length / 2];
    }
}
/*Runtime: 119 ms, faster than 87.06% of C# online submissions for Majority Element.
Memory Usage: 44.1 MB, less than 5.87% of C# online submissions for Majority Element.
*/
