namespace Geeks;

public class FindDublicatesInArray
{
    public List<int> duplicates(long[] arr, int n)
    {
        //That's true but sometimes took more time than expected
        List<int> arr2 = new List<int>();
        for(int i = 0; i<n; i++){
            for(int j = i+1; j<n; j++){
                if(arr[i] == arr[j]){
                    if (!arr2.Contains((int)arr[i])) 
                    {
                        arr2.Add((int)arr[i]);
                    }
                }
            }
        }
        if(!arr2.Any()){
            arr2.Add(-1);
        }
        arr2.Sort();
        return arr2;    
        
        
            
    }
}