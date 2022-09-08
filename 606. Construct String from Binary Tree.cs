/*https://leetcode.com/problems/construct-string-from-binary-tree/
 * */
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
    public string Tree2str(TreeNode root) {
        return Tree2strrun(root);
    }
    //recrusive solution, slow
    public string Tree2strrun(TreeNode root, bool isLeft = false) {
        if (root == null) {
            if (isLeft)
                return " ";
            else
                return "";
        }
        if (root.left == null && root.right == null)
            return $"{root.val}";
        string l = Tree2strrun(root.left, true),
            r = Tree2strrun(root.right);
        l = l == "" ? "" : "(" + l.Trim() + ")";
        r = r == "" ? "" : "(" + r.Trim() + ")";
        return $"{root.val}{l}{r}";
    }
}