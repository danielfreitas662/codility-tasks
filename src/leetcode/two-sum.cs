namespace Tasks;

public static class TwoSumTest {
    public static int[] TwoSum(int[] nums, int target) {
        var result = new int[2];
        var dict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            if(dict.ContainsKey(target - nums[i])){
                result[0] = dict[target - nums[i]];
                result[1] = i;
                break;
            }
            dict[nums[i]] = i;
        }
        Console.WriteLine($"[{result[0]}, {result[1]}]");
        return result;
    }
}