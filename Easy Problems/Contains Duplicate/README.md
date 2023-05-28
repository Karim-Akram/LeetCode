# 217. Contains Duplicate

<br>

## The Problem: [LeetCode Link](https://leetcode.com/problems/contains-duplicate/)

<br>

## code

```C#
// C#
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

    }
}
```
