public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int low = 1;
        int high = CalculateMax(piles);
        while(low<=high)
        {
            int mid = low + (high-low)/2;
            int totalH = CalculateTotalH(piles,mid);
            if(totalH<=h)
            {
                high = mid - 1; 
            }
            else {
                low = mid+1;
            }
        }
        return low;

    }
    //return the total hours used to eat the bananas
    public int CalculateTotalH(int[] piles, int speed)
    {
        int totalH = 0;
        for (int i = 0; i < piles.Length; i++)
        {
            totalH += (int)Math.Ceiling((double)piles[i] / speed);
        }
        return totalH;
    }
    //returns the maxiumum from the array 
    public int CalculateMax(int[] piles)
    {
        int max = piles[0];
        for(int i = 1;i<piles.Length;i++)
        {
            max = Math.Max(piles[i],max);
        }
        return max;
    }
}