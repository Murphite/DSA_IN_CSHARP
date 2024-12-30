


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


https://leetcode.com/problems/reverse-vowels-of-a-string/description/?envType=study-plan-v2&envId=leetcode-75
Example 1:

Input: s = "IceCreAm"

Output: "AceCreIm"

Explanation:

The vowels in s are ['I', 'e', 'e', 'A']. On reversing the vowels, s becomes "AceCreIm".

Example 2:

Input: s = "leetcode"

Output: "leotcede"
using System;
using System.Collections.Generic;

public class Solution {
    public string ReverseVowels(string s) {
        // Define a set of vowels for quick lookup
        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        // Convert the string to a character array
        char[] chars = s.ToCharArray();

        // Use two pointers to reverse vowels
        int left = 0;
        int right = chars.Length - 1;

        while (left < right) {
            // Move left pointer until a vowel is found
            while (left < right && !vowels.Contains(chars[left])) {
                left++;
            }
            
            // Move right pointer until a vowel is found
            while (left < right && !vowels.Contains(chars[right])) {
                right--;
            }

            // Swap the vowels
            char temp = chars[left];
            chars[left] = chars[right];
            chars[right] = temp;

            // Move pointers inward
            left++;
            right--;
        }

        // Convert the character array back to a string
        return new string(chars);
    }
}


https://leetcode.com/problems/reverse-words-in-a-string/?envType=study-plan-v2&envId=leetcode-75
Example 1:

Input: s = "the sky is blue"
Output: "blue is sky the"
Example 2:

Input: s = "  hello world  "
Output: "world hello"
Explanation: Your reversed string should not contain leading or trailing spaces.

using System;
using System.Linq;

public class Solution {
    public string ReverseWords(string s) {
        // Step 1: Split the string into words, ignoring extra spaces
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
        // Step 2: Reverse the array of words
        Array.Reverse(words);
        
        // Step 3: Join the words with a single space
        return string.Join(" ", words);
    }
}
