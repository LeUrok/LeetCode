public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0 || x % 10 == 0 && x != 0) return false;
        if (x < 10) return true;

        int rev = 0;

        while (rev < x)
        {
            rev = rev * 10 + (x % 10);
            x = x / 10;
        }
        if (x == rev || rev / 10 == x)
            return true;

        return false;

    }
}