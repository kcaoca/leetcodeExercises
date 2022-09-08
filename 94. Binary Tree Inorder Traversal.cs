/**https://leetcode.com/problems/binary-tree-inorder-traversal
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
    public IList<int> InorderTraversal(TreeNode root) {
        if (root == null)
            return new List<int>();
        IList<int> r = InorderTraversal(root.left);
        IList<int> res = r == null ? new List<int>() : r.ToList();
        res.Add(root.val);
        r = InorderTraversal(root.right);
        if (r != null)
            foreach (int v in r.ToList())
                res.Add(v);
        return res;
    }
}
/*Runtime: 140 ms, faster than 96.93% of C# online submissions for Binary Tree Inorder Traversal.
Memory Usage: 42.6 MB, less than 5.81% of C# online submissions for Binary Tree Inorder Traversal.
*/