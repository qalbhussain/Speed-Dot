using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//This Script control the background
public class Background : MonoBehaviour {

    public Text text;
    public LevelManager levelManager;
    public SpriteRenderer spriteRenderer;
    public Color color1 = new Color(116,11,102);
    public Color color2 = new Color(9,103,103);
    private float duration = 3.0F;

    void OnMouseDown()
    {
        string score = text.text;
        int playerScore = int.Parse(score);
        int previousScore = PlayerPrefManager.GetPlayerScore();
        if (playerScore > previousScore)
        {
            PlayerPrefManager.SetPlayerScore(playerScore);
        }

        PlayerPrefManager.SetCurrentScore(playerScore);
        levelManager.LoadLevel("03 GameOver");
    }

    void Update()
    {
        float t = Mathf.PingPong(Time.time, duration) / duration;
        spriteRenderer.color = Color.Lerp(color1, color2, t);
    }
}
