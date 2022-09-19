/*https://leetcode.com/problems/clone-graph/
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if (node == null) return null;
        Queue<Node> que = new Queue<Node>();
        Dictionary<Node, Node> dict = new Dictionary<Node, Node>();
        que.Enqueue(node);
        dict.Add(node, new Node(node.val));
        Node ans = new Node();
        while (que.Count > 0) {
            var curr = que.Dequeue();
            foreach (Node neighbor in curr.neighbors) {
                if (!dict.ContainsKey(neighbor)) {
                    que.Enqueue(neighbor);
                    dict.Add(neighbor, new Node(neighbor.val));
                }
                dict[curr].neighbors.Add(dict[neighbor]);
            }
        }
        return dict[node];
    }
}
/*Runtime: 244 ms, faster than 41.09% of C# online submissions for Clone Graph.
Memory Usage: 41.6 MB, less than 83.85% of C# online submissions for Clone Graph.
*/