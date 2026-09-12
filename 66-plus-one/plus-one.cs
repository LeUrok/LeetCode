public class Solution {
    public int[] PlusOne(int[] digits) {
        int i = digits.Length - 1;
        int f = 1;

        while (i >= 0 && f == 1)
        {
            if (digits[i] + 1 <= 9)
                f = 0;
            digits[i] = (digits[i] + 1) % 10;
            i--;
        }

        
        if (f == 1)
        {
            int[] arr = new int[digits.Length + 1];
            arr[0] = 1;
            for (i = 0; i < digits.Length; i++)
                arr[i + 1] = digits[i];
            return arr;
        }

        return digits;
    }
}