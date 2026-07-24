public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> map = new();

        foreach( var num in nums){
            if(map.ContainsKey(num)){
                //map[num] ++;
                return true;
            }
            else{
                map[num] = 1;
            }
        }  
        return false;
    }
}