namespace CodeWars;

public class AllStarCodeChallenge18
{
    public static int StrCount(string str, char letter)
    {
        int count = 0;
    
        foreach (char c in str)
        {
            if (c == letter)
            {
    
                count++;
            }
        }
    
        return count;
    }
   
}