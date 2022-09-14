/*https://leetcode.com/problems/find-original-array-from-doubled-array/submissions/
 * 
 */
 public class Solution {
    public int[] FindOriginalArray(int[] changed) {
        if (changed == null || (changed.Length % 2 == 1))
            return new int[] { }; 0
        List<int> arr = changed.ToList();
        arr.Sort();
        List<int> result = new List<int>();
        while (arr.Count > 0) {
            int v = arr[arr.Count - 1];
            if (v % 2 == 1) return new int[] { };
            int half = v / 2;
            if (arr.Remove(half)) {
                result.Insert(0, half);
                arr.RemoveAt(arr.Count - 1);
            } else
                return new int[] { };
        }
        return result.ToArray();
    }
}

/*Runtime: 3497 ms, faster than 8.00% of C# online submissions for Find Original Array From Doubled Array.
Memory Usage: 51.3 MB, less than 100.00% of C# online submissions for Find Original Array From Doubled Array.
*/