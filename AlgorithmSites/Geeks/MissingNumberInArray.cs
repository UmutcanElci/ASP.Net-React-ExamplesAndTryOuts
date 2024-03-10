namespace Geeks;

public class MissingNumberInArray
{
    
        public int MissingNumber(int[] arr, int n)
        {
            int expectedSum = (n * (n + 1)) / 2; 
            int actualSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                actualSum += arr[i];
            }

            return expectedSum - actualSum;
        }
    

}