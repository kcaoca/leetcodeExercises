/*https://leetcode.com/problems/find-duplicate-file-in-system/
 * */
public class Solution {
    public IList<IList<string>> FindDuplicate(string[] paths) {
        Dictionary<string, IList<string>> fileConts = new Dictionary<string, IList<string>>();
        foreach (string path in paths) {
            string[] files = path.Split(' ');
            if (files.Length <= 1) continue;
            for (int i = 1; i < files.Length; i++) {
                string[] fileInfo = files[i].Split('(');
                string _path = files[0] + "/" + fileInfo[0];
                string _cont = fileInfo[1].Substring(0, fileInfo[1].Length - 1);
                if (!fileConts.ContainsKey(_cont)) {
                    fileConts.Add(_cont, new List<string>() { _path });
                } else {
                    fileConts[_cont].Add(_path);
                }
            }
        }
        return fileConts.Values.Where(x => x.Count > 1).ToList();
    }
}
/*Runtime: 313 ms, faster than 47.50% of C# online submissions for Find Duplicate File in System.
Memory Usage: 54.1 MB, less than 27.50% of C# online submissions for Find Duplicate File in System.
*/