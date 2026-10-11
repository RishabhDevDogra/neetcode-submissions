class Solution {
public:
    vector<vector<int>> subsets(vector<int>& nums) {
        vector<vector<int>> ans;
        vector<int> ds;

        func(0, nums, ans, ds);

        return ans;
    }

    void func(int ind, vector<int>& nums,
              vector<vector<int>>& ans, vector<int>& ds) {

        if (ind == nums.size()) {
            ans.push_back(ds);
            return;
        }

        // Pick
        ds.push_back(nums[ind]);
        func(ind + 1, nums, ans, ds);
        ds.pop_back();

        // Don't pick
        func(ind + 1, nums, ans, ds);
    }
};