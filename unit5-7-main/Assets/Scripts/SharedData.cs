
public static class SharedData
{
    // This data will be shared across difference scenes

    
    static int score = 1000;

    public static string GetScoreText()
    {
        string text = score.ToString();
        return text;
    }

    public static int GetScore()
    {
        
        return score;
    }


    public static void SetScore( int newScore )
    {
        score = newScore;
    }


}
