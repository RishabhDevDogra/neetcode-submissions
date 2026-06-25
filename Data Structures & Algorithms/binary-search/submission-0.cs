public class Solution {
    public int Search(int[] nums, int target) {
        int low = 0;
        int high = nums.Length -1;
        while(low<=high)
        {
            int mid = low + (high - low)/2;
            if(nums[mid] == target){
                return mid;
            }
            //exist in th
            if(nums[mid] > target){
                high = mid - 1;
            }
            else {
                low = mid +1;
            }
        }
        return -1;
    }
}
