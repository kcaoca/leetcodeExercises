/** https://leetcode.com/problems/path-sum-ii/submissions/
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
    List<IList<int>> res = new List<IList<int>>();
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        if (root == null) return new List<IList<int>>();
        dfs(root, targetSum, (new List<int>()).ToArray());
        return res;
    }

    private void dfs(TreeNode root, int targetSum, int[] vList) {
        List<int> _r = vList.ToList();
        _r.Add(root.val);
        if (root.left == null && root.right == null && (_r.Sum() == targetSum)) {
            res.Add(_r);
            return;
        }
        if (root.left != null) {
            dfs(root.left, targetSum, _r.ToArray());
        }
        if (root.right != null) {
            dfs(root.right, targetSum, _r.ToArray());
        }
    }
}
/*Runtime: 319 ms, faster than 5.00% of C# online submissions for Path Sum II.
Memory Usage: 48.3 MB, less than 6.18% of C# online submissions for Path Sum II.
*/

public class Solution {
    List<IList<int>> res = new List<IList<int>>();
    Dictionary<TreeNode, List<int>> dict = new Dictionary<TreeNode, List<int>>();
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        dfs(root, targetSum, null);
        return res;
    }

    private void dfs(TreeNode root, int targetSum, TreeNode parent) {
        if (root == null) return;
        if (parent == null)
            dict.Add(root, new List<int>() { root.val });
        else {
            dict.Add(root, dict[parent].Append(root.val).ToList());
        }
        if (root.left == null && root.right == null && (dict[root].Sum() == targetSum)) {
            res.Add(dict[root]);
            return;
        }
        dfs(root.left, targetSum, root);
        dfs(root.right, targetSum, root);
    }
}
/*Runtime: 150 ms, faster than 97.35% of C# online submissions for Path Sum II.
Memory Usage: 48.3 MB, less than 6.18% of C# online submissions for Path Sum II.
*/