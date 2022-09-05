/**987. Vertical Order Traversal of a Binary Tree
 * https://leetcode.com/problems/vertical-order-traversal-of-a-binary-tree/submissions/
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    Dictionary<(int, int), SortedSet<int>> records = new Dictionary<(int, int), SortedSet<int>>();
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        calc(root, 0, 0);
        var results = new List<IList<int>>(); int col = int.MinValue;
        var o = records.OrderBy(x => x.Key.Item1).ThenBy(x => x.Key.Item2).ToList();
        foreach (var kv in o) {
            if (kv.Key.Item1 > col) {
                List<int> colV = new List<int>();
                colV.AddRange(kv.Value.ToList());
                results.Add(colV);
                col = kv.Key.Item1;
            } else {
                List<int> colV = results.Last().ToList();
                colV.AddRange(kv.Value.ToList());
                results[results.Count - 1] = colV;
            }
        }
        return results;
    }
    private void calc(TreeNode root, int x, int y) {
        if (root == null) return;
        if (!records.ContainsKey((x, y))) {
            records.Add((x, y), new SortedSet<int>(Comparer<int>.Create((m, n) => m >= n ? 1 : -1)) { root.val });
        } else {
            records[(x, y)].Add(root.val);
        }
        calc(root.left, x - 1, y + 1);
        calc(root.right, x + 1, y + 1);
    }
}
/*Runtime: 215 ms, faster than 55.84% of C# online submissions for Vertical Order Traversal of a Binary Tree.
Memory Usage: 41.7 MB, less than 60.91% of C# online submissions for Vertical Order Traversal of a Binary Tree.
*/