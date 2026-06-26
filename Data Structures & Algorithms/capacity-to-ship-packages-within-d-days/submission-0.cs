public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int low = CalculateMax(weights);
        int high = CalculateSum(weights);

        while(low<=high)
        {
            int mid = low + (high -low)/2;
            int totalD = CalculateTotalD(weights,mid);
            if(totalD<=days)
            {
                high = mid -1;
            }
            else {
                low = mid+1;
            }
        }
        return low;
    }
    public int CalculateMax(int[] weights)
    {
        int max = weights[0];
        for(int i = 1; i < weights.Length; i++){
            max = Math.Max(weights[i],max);
        }
        return max;
    }
        public int CalculateSum(int[] weights)
    {
        int sum = 0;

        for (int i = 0; i < weights.Length; i++)
        {
            sum += weights[i];
        }

        return sum;
    }
    public int CalculateTotalD(int[] weights, int capacity){
        int days = 1;
        int load = 0;
        
        for(int i = 0; i < weights.Length; i++){
           if(load + weights[i]>capacity)
           {
            days = days+1;
            load = weights[i];
           }
           else
           {
            load += weights[i];
           }
        }
        return days;
    }
}