/*https://leetcode.com/problems/meeting-rooms-iii
 * 
 * */
public class Solution {
    public int MostBooked(int n, int[][] meetings) {
        Dictionary<int, long> sche = new Dictionary<int, long>();   //because of the last test case, int is not enough
        Array.Sort(meetings, (x, y) => x[0].CompareTo(y[0]));
        int[] count = new int[n];
        for (int i = 0; i < n; i++) {
            sche.Add(i, 0);
        }
        for (int i = 0; i < meetings.Length; i++) {
            KeyValuePair<int, long> kv;
            var roomsAvailable = sche.OrderBy(x => x.Key).Where(x => x.Value <= meetings[i][0]).ToList();
            if (roomsAvailable.Count() > 0)
                kv = roomsAvailable[0];
            else
                kv = sche.OrderBy(x => x.Value).ThenBy(x => x.Key).FirstOrDefault();
            if (sche[kv.Key] < meetings[i][0]) {
                sche[kv.Key] = meetings[i][1];
            } else {
                sche[kv.Key] += meetings[i][1] - meetings[i][0];
            }
            count[kv.Key]++;
        }
        return Array.IndexOf(count, count.Max()); //count[0]; //
    }
}
/*
 * Runtime: 2060 ms, faster than 16.67% of C# online submissions for Meeting Rooms III.
Memory Usage: 72.2 MB, less than 16.67% of C# online submissions for Meeting Rooms III.
*/