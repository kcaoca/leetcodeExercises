/*https://leetcode.com/problems/find-k-closest-elements/
 */
public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        int l = 0, r = arr.Length - k;
        while (l < r) {
            int mid = (r + l) / 2;
            if (x - arr[mid] <= arr[mid + k] - x)
                r = mid;
            else
                l = mid + 1;
        }
        return arr.Skip(l).Take(k).ToList();
    }
}
/*Runtime: 343 ms, faster than 39.71% of C# online submissions for Find K Closest Elements.
Memory Usage: 47.3 MB, less than 30.14% of C# online submissions for Find K Closest Elements.
*/