/**https://leetcode.com/problems/pseudo-palindromic-paths-in-a-binary-tree
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
    public int PseudoPalindromicPaths(TreeNode root) {
        if (root == null) return 0;
        getLeaves(root, new int[0]);
        return count;
    }
    private int count = 0;
    private void getLeaves(TreeNode root, int[] vals) {
        if (root == null) return; var vv = vals.ToList();
        if (vv.IndexOf(root.val) >= 0) {
            vv.Remove(root.val);
        } else {
            vv.Add(root.val);
        }
        vals = vv.ToArray();
        if (root.left == null && root.right == null)
            if (vals.Length <= 1)   //only if 1 or 0 will be counted
                count++;
        if (root.left != null)
            getLeaves(root.left, vals);
        if (root.right != null)
            getLeaves(root.right, vals);
    }

}
/*Runtime: 470 ms, faster than 100.00% of C# online submissions for Pseudo-Palindromic Paths in a Binary Tree.
Memory Usage: 71.9 MB, less than 33.33% of C# online submissions for Pseudo-Palindromic Paths in a Binary Tree.

*/