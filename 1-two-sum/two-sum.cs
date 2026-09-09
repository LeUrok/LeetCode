public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];

            if (dict.TryGetValue(complement, out int ind))
                return new int[] { ind, i};
            
            dict[nums[i]] = i;
        }

        return new int[0];
    }
}