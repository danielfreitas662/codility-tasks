namespace Tasks;

public static class LongestSubstringWithoutRepeatingCharacters {
    public static int LengthOfLongestSubstring(string s) {
        int max = 0;
        for(int i = 0; i< s.Length; i++){
            max = Math.Max(max, FindSubstringMax(s[i..]));
        }
        return max;
    }

    public static int FindSubstringMax(string s){
        int max = 0;
        HashSet<char> values = new();
        foreach(char c in s){
            if(!values.Contains(c)){
                values.Add(c);
                max++;
            }else{
                break;
            }
        }
        return max;
    }
}