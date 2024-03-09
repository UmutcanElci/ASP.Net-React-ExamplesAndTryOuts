namespace Geeks;

public class MissingNumberInArray
{
    public int MissingNumber(int[] arr, int n)
    {
        int miss = 1;
        for (int i = 0; i < n-1; i++){
            if (arr[i] != miss){
                miss = arr[i];
                return  miss;
            }
             
        }
        
        return miss;
    }
}