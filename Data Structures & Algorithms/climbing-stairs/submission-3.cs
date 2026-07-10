public class Solution {
    public int ClimbStairs(int n) {     
        if(n <=2)
        return n;

        int prev1 = 1;
        int prev = 2;
        for(int i = 3; i<=n;i++)
        { 
            int curr = prev+prev1;
            prev1= prev;
            prev = curr;
        }
        return prev;
    }
}
