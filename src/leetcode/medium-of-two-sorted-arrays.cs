namespace Tasks;

public static class MediumOfTwoSortedArraysChallenge{
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int totalLength = nums1.Length + nums2.Length;
        double[] nums = new double[totalLength];

        int index1 = 0;
        int index2 = 0;
        double result = 0;
        for(int i = 0; i< totalLength; i++){
            if(index1 < nums1.Length && index2 < nums2.Length){
                if(nums1[index1] < nums2[index2]){
                    nums[i] = nums1[index1];
                    index1++;
                }
                else{
                    nums[i] = nums2[index2];
                    index2++;
                }
            }
            else if(index1 < nums1.Length){
                nums[i] = nums1[index1];
                index1++;
            }
            else if (index2 < nums2.Length){
                nums[i] = nums2[index2];
                index2++;
            }
            if(totalLength % 2 > 0 && i ==  totalLength / 2){
                result = nums[i];
                break;
            }
            else if(totalLength % 2 == 0 && i == totalLength / 2){
                result = (nums[i] + nums[i - 1]) / 2;
                break;
            }
        }
        return result;
    }
}