namespace Geeks;

public class FindDublicatesInArray2
{
    public List<int> duplicates(long[] arr, int n)
    {
        //Hashset does not allow duplicated elements
        HashSet<int> seen = new HashSet<int>();
        HashSet<int> duplicates = new HashSet<int>();

        for (int i = 0; i < n; i++)
        {
            int num = (int)arr[i];
            if (seen.Contains(num))
            {
                duplicates.Add(num);
            }
            else
            {
                seen.Add(num);
            }
        }

        List<int> result = duplicates.ToList();
        result.Sort();

        return result.Count == 0 ? new List<int> { -1 } : result;
    }
}