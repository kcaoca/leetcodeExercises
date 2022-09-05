/**https://leetcode.com/problems/binary-tree-pruning
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
    public TreeNode PruneTree(TreeNode root) {
        if (root == null) {
            return null;
        }
        root.left = PruneTree(root.left);
        root.right = PruneTree(root.right);
        if (root.left == null && root.right == null) {
            return root.val == 1 ? root : null;
        }
        return root;
    }
}
/*
 * Runtime: 97 ms, faster than 87.18% of C# online submissions for Binary Tree Pruning.
Memory Usage: 36.5 MB, less than 91.03% of C# online submissions for Binary Tree Pruning.*/