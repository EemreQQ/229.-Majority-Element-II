public class Solution
{
    public IList<int> MajorityElement(int[] nums)
    {
        Dictionary<int, int> d = new Dictionary<int, int>();
        List<int> list = new List<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (d.Keys.Contains(nums[i])) 
                d[nums[i]]++;
            else 
                d.Add(nums[i], 1);
            if (d[nums[i]] > nums.Length / 3 && list.Contains(nums[i]) == false)               
                list.Add(nums[i]);
        }
        return list;
    }
}