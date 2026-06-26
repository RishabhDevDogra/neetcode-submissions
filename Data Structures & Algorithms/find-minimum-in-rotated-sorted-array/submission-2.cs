public class Solution {
    public int FindMin(int[] nums)
{
    int l = 0;
    int r = nums.Length - 1;
    int ans = int.MaxValue;

    while (l <= r)
    {
       

        int mid = l + (r - l) / 2;

        if (nums[l] <= nums[mid])
        {
            ans = Math.Min(ans, nums[l]);
            l = mid + 1;
        }
        else
        {
            ans = Math.Min(ans, nums[mid]);
            r = mid - 1;
        }
    }

    return ans;
}
}