namespace Tasks;

public static class BubbleSortClass{
    private static void Swap(int[] array, int i, int j){
        (array[j], array[i]) = (array[i], array[j]);
    }

    public static void Sort(int[] array){
        for(int i = 0; i< array.Length -1; i++){
            for(int j = 0; j < j-i-1; j++){
                if(array[i] < array[i+1]){
                    Swap(array, i, i + 1);
                }
            }
        }
    }
}