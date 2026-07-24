public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        return false;

        Dictionary<char,int> map = new();

        foreach(char c in s)
        {
            if(map.ContainsKey(c)){
                map[c] ++;
            }
            else{
                map[c] = 1;
            }
        }
        foreach(var c in t)
        {
            if (!map.ContainsKey(c))
            {
                return false;
            }
            map[c]--;

            if (map[c] < 0)
                return false;
        }
        return true;
    }
}
