public class Solution {
    public bool Search(int[] nums, int target) {
        int low = 0;
        int high = nums.Length-1;
        
        while(low<=high)
        {
            int mid = low +(high-low)/2;

            if(nums[mid]==target)
            {
                return true;
            }
            if(nums[low]==nums[mid]&& nums[mid] == nums[high])
            {
                low++;
                high--;
                continue;
            }
            
        if (nums[low] <= nums[mid]) // left half sorted
        {
            if (target >= nums[low] && target < nums[mid])
                high = mid - 1;
            else
                low = mid + 1;
        }
        else // right half sorted nums[l] >= nums[mid]
        {
            if (target > nums[mid] && target <= nums[high])
                low = mid + 1;
            else
                high = mid - 1;
        }
        }
        return false;
    }
}