using UnityEngine;

public class GameController
{
    private static int collectableCount;
    private static bool dead;
    private static bool timeUp;

    public static float tempoFinal;
    public static int moedasPegas = 0;

    public static float timeLimit = 15f;
    public static float timeRemaining;

    public static bool gameWon
    {
        get { return collectableCount <= 0 && !dead && !timeUp; }
    }

    public static bool gameLost
    {
        get { return dead || timeUp; }
    }

    public static bool gameOver
    {
        get { return gameWon || gameLost; }
    }

    public static bool isDead { get { return dead; } }
    public static bool isTimeUp { get { return timeUp; } }

    public static void Init()
    {
        collectableCount = 4;
        moedasPegas = 0;
        dead = false;
        timeUp = false;
        timeRemaining = timeLimit;
    }

    public static void Collect()
    {
        collectableCount--;
        moedasPegas++;
        if (collectableCount <= 0)
        {
            tempoFinal = timeLimit - timeRemaining;
        }
    }

    public static void Die()
    {
        dead = true;
    }

    public static void TimeUp()
    {
        timeUp = true;
    }
}