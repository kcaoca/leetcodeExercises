using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int NumberOfWeakCharacters(int[][] properties) {
        properties.IndexOf()
        int count = 0;
        properties = properties.OrderBy(x => x[0]).ThenBy(x => x[1]).ToArray();
        properties
        Queue<int[]> onstage = new Queue<int[]>() { properties[0] };
        for (int i = 1; i < properties.Length; i++) {
            if (properties[i][0] > onstage[0][0]) {
                for (int j = 0; j < onstage.Count; j++) {
                    if (properties[i][1] > onstage[j][1]) {
                        count++;
                    }
                }
            } else {
                onstage.Enqueue(properties[i]);
            }
        }
    }
}