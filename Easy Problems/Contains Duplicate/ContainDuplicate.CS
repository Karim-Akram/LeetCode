public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> Set =new HashSet<int>();
        foreach(int x in nums)
        {
            if (Set.Contains (x))
            return true;
            Set.Add(x);
        }
        return false;
