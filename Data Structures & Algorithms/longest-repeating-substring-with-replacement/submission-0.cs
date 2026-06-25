public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();

        int left = 0;
        int maxFreq = 0;
        int maxLen = 0;

        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];

            if (!freq.ContainsKey(c))
                freq[c] = 0;

            freq[c]++;

            maxFreq = Math.Max(maxFreq, freq[c]);

            while ((right - left + 1) - maxFreq > k)
            {
                freq[s[left]]--;
                left++;
            }

            maxLen = Math.Max(maxLen, right - left + 1);
        }

        return maxLen;
    }
}