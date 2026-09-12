public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) return false;
        if (x == 0) return true;

        List<int> arr = new List<int>();

        while (x > 0)
        {
            arr.Add(x % 10);
            x = x / 10;
        }

        for (int i = 0; i < arr.Count / 2; i++)
        {
            if (arr[i] != arr[arr.Count - 1 - i])
                return false;
        }

        return true;
        
    }
}