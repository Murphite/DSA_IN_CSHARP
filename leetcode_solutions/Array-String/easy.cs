


//1768.Merge Strings Alternately
//https://leetcode.com/problems/merge-strings-alternately/?envType=study-plan-v2&envId=leetcode-75
//Input: word1 = "abc", word2 = "pqr"
//Output: "apbqcr"

using System.Text;

public class Solution
{
	public string MergeAlternately(string word1, string word2)
	{
		int maxLength = Math.Max(word1.Length, word2.Length);
		var merged = new StringBuilder();

		for (int k = 0; k < maxLength; k++)
		{
			if (k < word1.Length)
				merged.Append(word1[k]);

			if (k < word2.Length)
				merged.Append(word2[k]);
		}

		return merged.ToString();
	}
}


//1071. Greatest Common Divisor of Strings
//https://leetcode.com/problems/greatest-common-divisor-of-strings/description/?envType=study-plan-v2&envId=leetcode-75
//Input: str1 = "ABCABC", str2 = "ABC"
//Output: "ABC"
//Input: str1 = "LEET", str2 = "CODE"
//Output: ""


public class Solution
{
	public string GcdOfStrings(string str1, string str2)
	{
		if ((str1 + str2) != (str2 + str1))
			return "";

		int gcdLength = Gcd(str1.Length, str2.Length);

		return str1.Substring(0, gcdLength);
	}

	private int Gcd(int a, int b)
	{
		while (b != 0)
		{
			int temp = b;
			b = a % b;
			a = temp;
		}
		return a;
	}

}


//https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/description/?envType=study-plan-v2&envId=leetcode-75
public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        // Find the maximum number of candies a kid has
        int maxCandies = candies.Max();

        // Initialize the result list
        List<bool> result = new List<bool>();

        // Check for each kid if adding extraCandies makes them have the most candies
        foreach (int candy in candies) {
            result.Add(candy + extraCandies >= maxCandies);
        }

        return result;
    }
}


public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int count = 0; // Count of flowers that can be planted
        
        for (int i = 0; i < flowerbed.Length; i++) {
            // Check if the current plot is empty and adjacent plots (if any) are also empty
            if (flowerbed[i] == 0 && 
                (i == 0 || flowerbed[i - 1] == 0) && 
                (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0)) {
                flowerbed[i] = 1; // Plant a flower
                count++; // Increment the count
                
                if (count >= n) {
                    return true; // If we can plant enough flowers, return true
                }
            }
        }
        
        return count >= n; // Return true if enough flowers can be planted
    }
}

