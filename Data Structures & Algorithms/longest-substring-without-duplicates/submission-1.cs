public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> map = new Dictionary<char, int>();    
        int left=0,right=0,maxLen=0;
        int n = s.Length;
        while(right < n)
        {
            char c = s[right];

        if (map.ContainsKey(c) && map[c] >= left) {
            left = map[c] + 1;
        }

        map[c] = right;

        maxLen = Math.Max(maxLen, right - left + 1);

        right++;
        }
return maxLen;
    }
}
