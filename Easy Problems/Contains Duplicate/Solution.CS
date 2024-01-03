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

// Using Array.Sort function

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
     Array.Sort(nums); 

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                return true;
            }
        }

        return false;
     
        
    }
}
