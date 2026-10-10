class Solution {
public:
    vector<vector<int>> combinationSum(vector<int>& candidates, int target) {
        vector<vector<int>> ans;
        vector<int> ds;

        findCombinations(0, target, candidates, ans, ds);

        return ans;
    }

    void findCombinations(int ind, int target, vector<int>& arr,
                          vector<vector<int>>& ans, vector<int>& ds) {

        if (ind == arr.size()) {
            if (target == 0) {
                ans.push_back(ds);
            }
            return;
        }

        // Pick the element
        if (arr[ind] <= target) {
            ds.push_back(arr[ind]);

            // Stay at same index because we can reuse the element
            findCombinations(ind, target - arr[ind], arr, ans, ds);

            ds.pop_back();
        }

        // Don't pick the element
        findCombinations(ind + 1, target, arr, ans, ds);
    }
};