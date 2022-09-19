/*https://leetcode.com/problems/sum-of-prefix-scores-of-strings/submissions/
 * */
public class Solution {
    public int[] SumPrefixScores(string[] words) {
        Trie trie = new Trie();
        foreach (string word in words) {
            trie.Insert(word);
        }
        int[] ans = new int[words.Length];
        for (int i = 0; i < words.Length; i++) {
            ans[i] = trie.Count(words[i]);
        }
        return ans;
    }
}
public class Trie {
    public class TrieNode {
        public TrieNode[] children = new TrieNode[26];
        public int count;
    }

    public TrieNode root = new TrieNode();
    public void Insert(string str) {
        TrieNode node = root;
        for (int i = 0; i < str.Length; i++) {
            int index = str[i] - 'a';
            if (node.children[index] == null)
                node.children[index] = new TrieNode();
            node = node.children[index];
            node.count++;
        }
    }

    public int Count(string str) {
        int result = 0;
        TrieNode node = root;
        for (int level = 0; level < str.Length; level++) {
            int index = str[level] - 'a';
            node = node.children[index];
            result += node.count;
        }
        return result;
    }
}
/*Runtime: 1452 ms, faster than 100.00% of C# online submissions for Sum of Prefix Scores of Strings.
Memory Usage: 244.3 MB, less than 100.00% of C# online submissions for Sum of Prefix Scores of Strings.
 */