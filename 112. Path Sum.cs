/*https://leetcode.com/problems/path-sum/
 */
/**
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
    public bool HasPathSum(TreeNode root, int targetSum) {
        if (root == null) return false;
        if (root.left == null && root.right == null) {
            if (root.val == targetSum)
                return true;
            else
                return false;
        }
        return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
    }
}
/*Runtime: 146 ms, faster than 62.64% of C# online submissions for Path Sum.
Memory Usage: 40.3 MB, less than 82.93% of C# online submissions for Path Sum.
*/