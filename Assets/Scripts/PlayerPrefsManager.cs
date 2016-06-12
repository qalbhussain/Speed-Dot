using UnityEngine;
using System.Collections;

public class PlayerPrefManager : MonoBehaviour
{

    const string CURRENT_SCORE = "current_score";
    const string PLAYER_SCORE = "player_score";
   
    public static void SetPlayerScore(int score)
    {
        PlayerPrefs.SetInt(PLAYER_SCORE, score);
    }

    public static int GetPlayerScore()
    {
       return PlayerPrefs.GetInt(PLAYER_SCORE);
    }

    public static void SetCurrentScore(int cScore)
    {
        PlayerPrefs.SetInt(CURRENT_SCORE, cScore);
    }

    public static int GetCurrentScore()
    {
        return PlayerPrefs.GetInt(CURRENT_SCORE);
    }
}
