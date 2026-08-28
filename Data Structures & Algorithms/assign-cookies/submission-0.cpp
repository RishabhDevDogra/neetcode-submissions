class Solution {
public:
    int findContentChildren(vector<int>& g, vector<int>& s) {
        int m = g.size();
        int n = s.size();

        sort(g.begin(), g.end());
        sort(s.begin(), s.end());

        int l = 0; // child
        int r = 0; // cookie

        while (l < m && r < n) {
            if (g[l] <= s[r]) {
                l++; // child is satisfied
            }
            r++; // use this cookie
        }

        return l;
    }
};