


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
