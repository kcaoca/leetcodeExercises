/*  https://leetcode.com/problems/n-ary-tree-level-order-traversal/
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    Dictionary<int, List<int>> lists = new Dictionary<int, List<int>>();
    public IList<IList<int>> LevelOrder(Node root) {
        checkLevel(root, 0);
        var result = new List<IList<int>>();
        foreach (var l in lists) {
            result.Add(l.Value);
        }
        return result;
    }
    public void checkLevel(Node root, int level) {
        if (root == null)
            return;
        if (!lists.ContainsKey(level)) {
            lists.Add(level, new List<int>() { root.val });
        } else {
            lists[level].Add(root.val);
        }
        foreach (Node n in root.children) {
            checkLevel(n, level + 1);
        }
    }
}

/*
 Runtime: 214 ms, faster than 76.84% of C# online submissions for N-ary Tree Level Order Traversal.
Memory Usage: 45.5 MB, less than 48.95% of C# online submissions for N-ary Tree Level Order Traversal.
*/